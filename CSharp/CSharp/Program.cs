using System;
using System.Xml.Linq;

enum SelectStage
{
    selectTown,
    selectBattleZone,
    NoneSelect
}
namespace TextRPG
{
    class FightUnit
    {
        protected string name = "None";
        protected int currHp = 50;
        protected int maxHp = 100;
        protected int att = 10;

        
        public void StatusRenderer()
        {
            Console.WriteLine("\n" + name + "-------------------------------------------------");
            Console.WriteLine("현재 체력 : " + currHp + " / " + maxHp);
            Console.WriteLine("공격력 : " + att);
            Console.WriteLine("-------------------------------------------------------");
        }
        
    }
    class Player : FightUnit
    {
        //private string name = "PLAYER";
        public string Name()
        {
            return name = "Player";
        }
        public int HealHp()
        {
            int originHp = currHp;
            if (currHp < maxHp)
            {
                currHp = new Item().HpPotion(currHp);
                if (currHp > maxHp)
                {
                    currHp = maxHp;
                    Console.WriteLine("현재 체력 : " + originHp + " => " + currHp);
                    return currHp;
                }
                Console.WriteLine("현재 체력 : " + originHp + " => " + currHp);
            }
            else if (currHp >= maxHp)
            {
                Console.WriteLine("더 이상 체력 회복할 수 없습니다.");
                return currHp;
            }
            return currHp;
        }
    }
    class Monster : FightUnit
    {
        public string Name()
        {
            return name = "Monster";
        }
    }
    class Item
    {
        private int hpPotion = 30;
        private int weaponUpgrade = 1;
        private int randomValue = 0;
        public int HpPotion(int _hp)
        {
            return _hp + hpPotion;
        }
        public int WeaponUpgrade(int _randomValue) // 오늘 랜덤 강화 시스템
        {
            Random _weapon = new Random();
            randomValue = _weapon.Next(0 , 1);
            
            return randomValue;
        }
    }

    class Stage
    {
        static public SelectStage StageSelect()
        {
            Console.Clear();

            Console.WriteLine("1. 마을로 갑니다.");
            Console.WriteLine("2. 배틀존으로 갑니다.\n");
            
            switch (Console.ReadKey().Key)
            {
                case ConsoleKey.D1:

                    return SelectStage.selectTown;
                
                case ConsoleKey.NumPad1:
                
                    return SelectStage.selectTown;
                
                case ConsoleKey.D2:
                 
                    return SelectStage.selectBattleZone;
                
                case ConsoleKey.NumPad2:
                
                    return SelectStage.selectBattleZone;

                default:
                    return SelectStage.NoneSelect;
            }
        }

        public void TownZone(Player _player)
        {
            while (true)
            {
                Console.Clear();
                _player.Name();
                _player.StatusRenderer();
                Console.WriteLine("1. 포션으로 체력 회복.\n2. 무기 강화하기\n3. 마을 벗어나기\n\n");
                switch(Console.ReadKey().Key)
                {
                    case ConsoleKey.D1:
                        Console.WriteLine(". 포션으로 체력을 회복합니다.");
                        _player.HealHp();
                        Console.ReadKey();
                        break;
                    case ConsoleKey.NumPad1:
                        Console.WriteLine(". 포션으로 체력을 회복합니다.");
                        _player.HealHp();
                        Console.ReadKey();
                        break;
                    case ConsoleKey.D2: // 무기강화

                        break;
                    case ConsoleKey.NumPad2:

                        break;
                    case ConsoleKey.D3:
                        Console.WriteLine(". 마을을 떠납니다.");
                        Console.ReadKey();
                        return;
                    case ConsoleKey.NumPad3:
                        Console.WriteLine(". 마을을 떠납니다.");
                        Console.ReadKey();
                        return;
                }
            }
        }
        public void BattleZone(Player _player , Monster _monster)
        {
            _player.Name();
            _player.StatusRenderer();
            _monster.Name();
            _monster.StatusRenderer();
            Console.ReadKey();
            switch (Console.ReadKey().Key)
            {
                case ConsoleKey.D1:

                    break;
                case ConsoleKey.NumPad1:

                    break;
                case ConsoleKey.D2:

                    break;
                case ConsoleKey.NumPad2:

                    break;
                case ConsoleKey.D3:

                    break;
                case ConsoleKey.NumPad3:

                    break;
            }
        }
    }

    class Game
    {
        static void Main(string[] args)
        {
            Player newPlayer = new Player();
            Monster newMonster = new Monster();
            Stage newStage = new Stage();
            while (true)
            {
                SelectStage selectStage = Stage.StageSelect();
                switch (selectStage)
                {
                    case SelectStage.selectTown:
                        Console.Write("번을 선택하셨습니다.\n\n마을로 이동합니다.");
                        Console.ReadKey();
                        newStage.TownZone(newPlayer);
                        break;
                    case SelectStage.selectBattleZone:
                        Console.WriteLine("번을 선택하셨습니다.\n\n배틀존으로 이동합니다.");
                        Console.ReadKey();
                        newStage.BattleZone(newPlayer, newMonster);
                        break;
                    case SelectStage.NoneSelect:
                        Console.WriteLine("\n잘못된 키를 입력하셨습니다.");
                        Console.ReadKey();
                        break;
                    default:
                        break;
                }
            }

        }
        

    }
}
