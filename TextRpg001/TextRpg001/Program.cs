using System;

class FightUnit
{
    protected string name = "None";
    protected int att = 10;
    protected int currHp = 50;
    protected int maxHp = 100;

    
    public void StatusRender()
    {
        Console.WriteLine(name + " 능력치---------------------------\n");
        Console.WriteLine("공격력 : " + att);
        Console.WriteLine("체력 : " + currHp + " / " + maxHp);
        Console.WriteLine("----------------------------------------\n");
    }
}

class Player : FightUnit
{
    public void PrintHp()
    {
        int originCurrHp = currHp - new Potion().HpPotionStat();
        // 그 객체의 멤벼변수와 관련된 코드를 2번 이상 사용하면 메서드로 만들어라.
        if (currHp >= maxHp)
        {
            if (currHp == maxHp)
            {
                Console.WriteLine(". 체력을 더 이상 회복할수 없습니다.");
                return;
            }
            Console.WriteLine(". 체력을 회복합니다.\n");
            Console.WriteLine("현재 플레이어의 HP :  " + originCurrHp + " => " + maxHp + " 이 되었습니다.");
        }
        else if(currHp < maxHp)
        {
            Console.WriteLine(". 체력을 회복합니다.\n");
            Console.WriteLine("현재 플레이어의 HP :  " + originCurrHp + " => " + currHp + " 이 되었습니다.");
        }
    }
    public int Status()
    {
        if(currHp <= maxHp)
        {
            Potion potion = new Potion();
            currHp = potion.HpPotion(currHp, maxHp);
            PrintHp();
            Console.WriteLine("");
            Console.Write("진행을 위해 아무 키 입력해주십시오.");
            Console.ReadKey();
            if (currHp > maxHp)
            {
                return currHp = maxHp;
            }
        }
        return currHp;
    }
}// 코드 재활용성을 향상시키기 위한 문법이 상속이다. (같은 코드 두번 치기 싫다.)
class Monster : FightUnit
{

}// 코드 재활용성을 향상시키기 위한 문법이 상속이다. (같은 코드 두번 치기 싫다.)
class Potion
{
    int hpPotion = 30;
    public int HpPotionStat()
    {
        int _hpPotion = hpPotion;
        return _hpPotion;
    }
    public int HpPotion(int _currHp , int _maxHp)
    {
        if (_maxHp <= _currHp)
        {
            return _currHp = _maxHp;
        }
        else
        {
            return _currHp += hpPotion;
        }
    }
}
enum STARTSELECT
{
    SELECTTOWN ,
    SELECTBATTLE ,
    NONESELECT
}
namespace TextRpg001
{
    
    class Program
    {
        // 시작한다.
        // 마을로 갈지 싸움터로 갈지
        static STARTSELECT StartSelect()
        {
            Console.Clear();
            Console.WriteLine("1. 마을");
            Console.WriteLine("2. 배틀");
            Console.Write("어디로 가시겠습니까? : ");
            
            //ConsoleKeyInfo keyInfo = Console.ReadKey();
            switch (Console.ReadKey().Key)
            {
                case ConsoleKey.D1:
                    Console.WriteLine("\n");
                    Console.WriteLine("마을로 이동합니다.");
                    Console.Write("진행을 위해 아무 키 입력해주십시오.");
                    Console.ReadKey();
                    return STARTSELECT.SELECTTOWN;
                case ConsoleKey.NumPad1:
                    Console.WriteLine("\n");
                    Console.WriteLine("마을로 이동합니다.\n");
                    Console.Write("진행을 위해 아무 키 입력해주십시오.");
                    Console.ReadKey();
                    return STARTSELECT.SELECTTOWN;
                case ConsoleKey.D2:
                    Console.WriteLine("\n");
                    Console.WriteLine("싸움터로 이동합니다.\n");
                    Console.Write("진행을 위해 아무 키 입력해주십시오.");
                    Console.ReadKey();
                    return STARTSELECT.SELECTBATTLE;
                case ConsoleKey.NumPad2:
                    Console.WriteLine("\n");
                    Console.WriteLine("싸움터로 이동합니다.\n");
                    Console.Write("진행을 위해 아무 키 입력해주십시오.");
                    Console.ReadKey();
                    return STARTSELECT.SELECTBATTLE;
                default:
                    Console.WriteLine("\n");
                    Console.WriteLine("잘못된 선택입니다.\n");
                    Console.Write("진행을 위해 아무 키 입력해주십시오.");
                    Console.ReadKey();
                    return STARTSELECT.NONESELECT;
            }
        }
        static void Town(Player _player)
        {
            while (true)
            {
                Console.Clear();
                _player.StatusRender();
                Console.WriteLine("마을에서 무슨 일을 하시겠습니까?\n");
                Console.WriteLine("1. 체력을 회복한다.");
                Console.WriteLine("2. 무기를 강화한다.");
                Console.WriteLine("3. 마을을 나간다.");
                Console.WriteLine("\n\n");
                switch (Console.ReadKey().Key)
                {
                    case ConsoleKey.D1: // 체력 회복
                        _player.Status();

                        break;
                    case ConsoleKey.NumPad1: // 체력 회복
                        _player.Status();

                        break;
                    case ConsoleKey.D2: // 무기강화

                        break;
                    case ConsoleKey.NumPad2: // 무기강화

                        break;
                    case ConsoleKey.D3:
                        Console.WriteLine(". 마을을 나가겠습니다.\n");
                        Console.Write("진행을 위해 아무 키 입력해주십시오.");
                        Console.ReadKey();
                        return;
                    case ConsoleKey.NumPad3:
                        Console.WriteLine(". 마을을 나가겠습니다.\n");
                        Console.Write("진행을 위해 아무 키 입력해주십시오.");
                        Console.ReadKey();
                        return;
                }
            }
        }
        static void Battle(Player _player)
        {
            Monster newMonster = new Monster();
            while (true)
            {
                Console.Clear();
                _player.StatusRender();
                newMonster.StatusRender();
                Console.ReadKey();
            }
        }
        static void Main(string[] args)
        {
            // 첫 시작 시 마을로 갈지 싸움터로 갈지 고른다.
            // 입장하게 하고 싶다면
            // 반복문과 조건문 중 어떤 걸 사용해야하나.
            // while (true)
            //{
            //    // 객체화 하지 않고도
            //    // 쓸 수 있는 함수
            //    // static 함수
            //    // 정적 멤버변수
            // ReadKey는 키를 입력받기 전까지 기다려준다.
            //    ConsoleKeyInfo keyInfo = Console.ReadKey();
            //    Console.WriteLine(keyInfo.Key);
            //}
            Player newPlayer = new Player();
            while (true)
            {
                STARTSELECT SelectCheck = StartSelect();
                switch (SelectCheck)
                {
                    case STARTSELECT.SELECTTOWN:
                        Town(newPlayer);
                        break;
                    case STARTSELECT.SELECTBATTLE:
                        Battle(newPlayer);
                        break;
                    case STARTSELECT.NONESELECT:
                        break;
                    default:
                        break;
                }
            }
        }
    }
}