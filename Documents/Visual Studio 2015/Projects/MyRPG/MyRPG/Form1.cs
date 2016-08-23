using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace MyRPG
{
    public partial class Form1 : Form
    {
        // 测试人物
        private Player testPlayer = new Player("Player1", 100, 10, 5);
        private Player testPlayer2 = new Player("Player2", 100, 10, 5);
        private Enemy testEnemy = new Enemy("Enemy1", 50, 10, 0);
        private Enemy testEnemy2 = new Enemy("Enemy2", 50, 8, 2);
        // 测试标签，显示一些信息
        private Label testLabel = new Label()
        {
            Location = new Point(300, 200),
            Text = "...",
            AutoSize = true,
            BorderStyle = BorderStyle.FixedSingle,
            Font = new Font("楷体", 18)
        };

        // 利用标签来表示人物
        private Label playerLabel = new Label()
        {
            Location = new Point(300, 300),
            Text = "Player1",
            AutoSize = true,
            BorderStyle = BorderStyle.FixedSingle
        };
        private Label playerLabel2 = new Label()
        {
            Location = new Point(400, 300),
            Text = "Player2",
            AutoSize = true,
            BorderStyle = BorderStyle.FixedSingle
        };
        private Label enemyLabel = new Label()
        {
            Location = new Point(300, 100),
            Text = "Enmey1",
            AutoSize = true,
            BorderStyle = BorderStyle.FixedSingle
        };
        private Label enemyLabel2 = new Label()
        {
            Location = new Point(400, 100),
            Text = "Enemy2",
            AutoSize = true,
            BorderStyle = BorderStyle.FixedSingle
        };

        // Dictionary连接Character和Label
        private Dictionary<Character, Label> characterToLabel = new Dictionary<Character, Label>();

        // 线程继续事件
        private static AutoResetEvent controlEvent = new AutoResetEvent(false);

        // 战斗逻辑线程
        Thread fightThread;

        // 战斗画面添加控件委托
        private delegate void ControlHandler(Control c);
        private ControlHandler addControlHandler;
        private ControlHandler removeControlHandler;
        // 更新CharacterLabel回调
        private delegate void UpdateLabelHandler();
        private UpdateLabelHandler updateLabelHandler;
        // 更新TestLabel回调
        private delegate void UpdateTestLabelHandler(string str);
        private UpdateTestLabelHandler updateTestLabelHandler;

        public Form1()
        {
            // 添加标签
            InitializeComponent();
            updateLabelCallback();
            fightScene.Controls.Add(playerLabel);
            fightScene.Controls.Add(playerLabel2);
            fightScene.Controls.Add(enemyLabel);
            fightScene.Controls.Add(enemyLabel2);
            fightScene.Controls.Add(testLabel);

            // 链接人物和标签
            characterToLabel.Add(testPlayer, playerLabel);
            characterToLabel.Add(testPlayer2, playerLabel2);
            characterToLabel.Add(testEnemy, enemyLabel);
            characterToLabel.Add(testEnemy2, enemyLabel2);

            // 添加“战斗画面添加控件”的回调函数
            addControlHandler += addControlCallback;
            // 添加“战斗画面移动控件”的回调函数
            removeControlHandler += removeControlCallback;
            // 添加CharacterLabel更新的回调函数
            updateLabelHandler += updateLabelCallback;
            // 添加TestLabel更新的回调函数
            updateTestLabelHandler += updateTestLabelCallback;

            // 启动战斗主逻辑线程
            fightThread = new Thread(fightLogic);
            fightThread.Start();
        }

        // 战斗是否结束，0表示未结束，1表示玩家胜利，2表示敌人胜利
        private int IsBattleFinished()
        {
            if (Enemy.aryEnemies.Count == 0)
                return 1;
            if (Player.aryPlayers.Count == 0)
                return 2;
            return 0;
        }

        // 战斗画面重绘
        private void fightScene_Paint(object sender, PaintEventArgs e)
        {
            ;
        }

        // 战斗画面添加控件回调
        private void addControlCallback(Control c)
        {
            fightScene.Controls.Add(c);
        }
        // 战斗画面移除控件回调
        private void removeControlCallback(Control c)
        {
            if (fightScene.Controls.Contains(c))
            {
                fightScene.Controls.Remove(c);
                c.Dispose();
            }
        }
        // CharacterLabel更新回调
        private void updateLabelCallback()
        {
            playerLabel.Text = string.Format("Player\nHP: {0}\nAtk: {1}\nDef {2}", testPlayer.HP, testPlayer.Atk, testPlayer.Def);
            playerLabel2.Text = string.Format("Player2\nHP: {0}\nAtk: {1}\nDef {2}", testPlayer2.HP, testPlayer2.Atk, testPlayer2.Def);
            enemyLabel.Text = string.Format("Enemy\nHP: {0}\nAtk: {1}\nDef {2}", testEnemy.HP, testEnemy.Atk, testEnemy.Def);
            enemyLabel2.Text = string.Format("Enemy2\nHP: {0}\nAtk: {1}\nDef {2}", testEnemy2.HP, testEnemy2.Atk, testEnemy2.Def);
        }
        // TestLabel更新回调
        private void updateTestLabelCallback(string str)
        {
            testLabel.Text = str;
        }

        // 战斗主逻辑
        private void fightLogic()
        {
            #region 战斗主逻辑
            while (IsBattleFinished() == 0)
            {
                // 遍历所有游戏角色
                for (int i = 0; i < Character.aryCharacters.Count; i++)
                {
                    Character c = Character.aryCharacters[i];
                    if (c is Player)
                    {
                        // 玩家执行操作
                        Player player = c as Player;
                        System.Diagnostics.Debug.WriteLine("Player Motion!");

                        #region 初始化操作框
                        Panel fightPanel = new Panel()
                        {
                            Location = new Point(100, 250),
                            Size = new Size(103, 205),
                            BorderStyle = BorderStyle.FixedSingle
                        };
                        Button attackBtn = new Button()
                        {
                            Location = new Point(1, 1),
                            Size = new Size(100, 50),
                            Text = "攻击",
                        };
                        attackBtn.Click += (sender, e) =>
                        {
                            // 本来应该是选择目标的！！
                            // 明天再写吧
                            testEnemy.HP -= testPlayer.Atk - testEnemy.Def;
                            Invoke(updateLabelHandler);

                            controlEvent.Set();
                        };
                        fightPanel.Controls.Add(attackBtn);
                        fightScene.Invoke(addControlHandler, fightPanel);
                        #endregion

                        controlEvent.WaitOne();

                        fightScene.Invoke(removeControlHandler, fightPanel);

                        // 测试信息
                        testLabel.Invoke(updateTestLabelHandler, string.Format("{0} Attack!", player.Name));
                        Thread.Sleep(1000);
                    }
                    else if (c is Enemy)
                    {
                        // 敌人执行操作
                        Enemy enemy = c as Enemy;

                        // 敌人随机选择我方角色
                        Random rd = new Random();
                        Player playerAttacked = Player.aryPlayers[rd.Next(Player.aryPlayers.Count)];

                        // 敌人攻击选中目标，暂时只有普攻
                        playerAttacked.HP -= enemy.Atk - playerAttacked.Def;
                        Invoke(updateLabelHandler);

                        // 测试信息
                        testLabel.Invoke(updateTestLabelHandler, string.Format("{0} Attack {1} !!!", enemy.Name, playerAttacked.Name));
                        Thread.Sleep(1000);
                    }
                }
            }
            #endregion
        }

        // 窗体关闭，注销所有线程
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            fightThread.Abort();
        }
    }
}
