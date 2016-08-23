using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace MyRPG
{
    // 游戏人物（包括游戏玩家和敌人）
    class Character
    {
        // 静态数组，存放所有character对象
        public static List<Character> aryCharacters = new List<Character>();

        // 基础属性
        public int HP { get; set; } // HP
        // public int MP { get; set; } // MP
        public int Atk { get; set; }   // 攻击
        public int Def { get; set; }    // 防御
        // 后续属性待定

        public string Name { get; set; }    // 名字

        // 构造函数
        public Character(string name,int hp, int atk, int def)
        {
            Name = name;
            HP = hp;
            Atk = atk;
            Def = def;

            aryCharacters.Add(this);
        }
    }

    // 我方人物
    class Player : Character
    {
        // 静态数组，存放所有player对象
        public static List<Player> aryPlayers = new List<Player>();

        // 构造函数
        public Player(string name, int hp, int atk, int def) : base(name,hp, atk, def)
        {
            aryPlayers.Add(this);
        }
    }

    // 敌方人物
    class Enemy : Character
    {
        // 静态数组，存放所有enemy对象
        public static List<Enemy> aryEnemies = new List<Enemy>();

        // 构造函数
        public Enemy(string name, int hp, int atk, int def) : base(name, hp, atk, def)
        {
            aryEnemies.Add(this);
        }
    }
}
