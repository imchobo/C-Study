using System;
class Player
{
    int att = 10;
    int currHp = 50;
    int maxHp = 100;

    public void StatusRender()
    {
        Console.WriteLine("----------------------------------------");
        Console.WriteLine("공격력 : " + att);
        Console.WriteLine("체력 : " + currHp + " / " + maxHp);
        Console.WriteLine("----------------------------------------");
    }
    
    public int Status()
    {
        Potion potion = new Potion();

        if(currHp <= maxHp)
        {
            currHp = potion.HpPotion(currHp, maxHp);
            if (currHp > maxHp)
            {
                return currHp = maxHp;
            }
        }
        return currHp;
    }
}
class Monster
{

}

class Potion
{
    int hpPotion = 30;

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

// 에러나 혹은 잘못된 선택에 관한것도 만든다.
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
            Console.WriteLine("어디로 가시겠습니까?");
            // 리턴이란 구문은 리턴이 되는 순간
            // 함수를 완전히 종료시킨다.
            // 즉 리턴을 한번했다면 그 아래
            // 아무리 많은 코드가 있어도.
            // 사용이 없다.
            //ConsoleKeyInfo keyInfo = Console.ReadKey();

            Console.WriteLine("");

            switch (Console.ReadKey().Key)
            {
                case ConsoleKey.D1:
                    Console.WriteLine("");
                    Console.WriteLine("마을로 이동합니다.");
                    Console.ReadKey();
                    return STARTSELECT.SELECTTOWN;
                case ConsoleKey.NumPad1:
                    Console.WriteLine("");
                    Console.WriteLine("마을로 이동합니다.");
                    Console.ReadKey();
                    return STARTSELECT.SELECTTOWN;
                case ConsoleKey.D2:
                    Console.WriteLine("");
                    Console.WriteLine("싸움터로 이동합니다.");
                    Console.ReadKey();
                    return STARTSELECT.SELECTBATTLE;
                case ConsoleKey.NumPad2:
                    Console.WriteLine("");
                    Console.WriteLine("싸움터로 이동합니다.");
                    Console.ReadKey();
                    return STARTSELECT.SELECTBATTLE;
                default:
                    Console.WriteLine("");
                    Console.WriteLine("잘못된 선택입니다.");
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
                Console.WriteLine("마을에서 무슨 일을 하시겠습니까?");
                Console.WriteLine("1. 체력을 회복한다.");
                Console.WriteLine("2. 무기를 강화한다.");
                Console.WriteLine("3. 마을을 나간다.");

                switch (Console.ReadKey().Key)
                {
                    case ConsoleKey.D1: // 체력 회복
                        _player.Status();

                        break;
                    case ConsoleKey.NumPad1: // 체력 회복


                        break;
                    case ConsoleKey.D2: // 무기강화


                        break;
                    case ConsoleKey.NumPad2: // 무기강화


                        break;
                    case ConsoleKey.D3:


                        return;
                    case ConsoleKey.NumPad3:


                        return;
                }
            }
        }
        static void Battle()
        {
            Console.WriteLine("아직 개장하지 않았습니다.");
            Console.ReadKey();
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
                        Battle();
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