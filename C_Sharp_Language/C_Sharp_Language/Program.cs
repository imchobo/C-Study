using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Language
{
    class Using_System
    {
        //static void Main(string[] args)
        //{
        //    /*
        //    using System;
        //    { < 기능 묶음의 시작.
        //        주인공이 움직이는 코드
        //        주인공이 말하는 코드
        //        주인공이 달리는 코드
        //    } <
        //    */
        //}
    } // using System 등등 무엇인지 설명
    class Class
    {
        // 내부의 내용은 중요하지 않다.
        //static void Main(string[] args)
        //{
            
        //}
    } // 클래스
    class NameSpace
    {
        //static void Main(string[] args)
        //{
        //    // 협업할 때 있어서 중요시 된다. 새로운 Scripts 라 생각 하는게 마음 편하다.
        //    // 새로운 식별자가 겹쳐지지 않게 하기 위함.
        //}
    } // 네임스페이스
    class CodeStartAndReading
    {
        // 코드 리딩 방법 , 기초 디버깅 방법

        // 코드는 항상 위에서 아래로 읽어준다.

        // 쪼개서 읽지 말기.

        // 디버깅 중 코드 한 줄씩 실행. f10을 누른다

        // f12를 누르면 그 클래스를 타고 가서 확인 할 수 있다.

    } // 코드 읽는 법
    class MemberVar
    {
        //int Gold = 10;
        //int Exp = 100;
        //int Att = 100;
        //int Def = 100;
        //int Hp = 100;
    } // 멤버 변수
    class MemberFunc
    {
        /*
         RPG를 만든다 -> 프로젝트 만든다.
         주인공이 있다. -> 클래스 (객체)
         주인공이 공격력이 있다. -> 멤버변수 (명사)
         주인공이 공격력으로 때린다. -> 멤버함수 (행동)
         */
        // 명사 만으로는 부족하다.
        int att;
        int hp;
        // 행동이 필요하다.
        void Fight()
        {

        }
        void SkillUse()
        {

        }
        void Talk()
        {

        }
    } // 멤버함수
    class LocalVar
    {
        //static void Main(string[] args)
        //{
        //    /* 함수안에 있는 녀석들을 지역변수라고 합니다.
        //       함수안에 있다면 지역변수라고 합니다.
        //       지역변수 규칙
        //      {
        //          함수 안에서 사용된 지역변수는 내부에서만 사용 가능.
        //      }
        //    */
        //    int att = 0; // 마우스 커서를 변수 위로 올려놓으면 값도 나온다.
        //    att = 50;

        //    // 객체화라고 하는 굉장히 중요한 작업.
        //    // 클래스는 설계도 이다.
        //    // Player의 설계도로 플레이어를 만드는데
        //    // 그 이름을 NewPlayer라고 만들어라.

        //    Player NewPlayer = new Player();
    }// 지역변수
    class ClassAcces
    {
        //static void Main(string[] vs)
        //{
        //    // 설계도를 사용하기.
        //    Player newPlayer = new Player();

        //    /* 
        //       만들어진 객체의 내용을 사용하기 위해
        //       객체의 이름. 을 사용한다.

        //       여기서 접근제한 지정자로 기본적인(변수,함수)에 private 가 생략되어 있기에
        //       보이지 않을 것이다.
               
        //       클래스 안에 있는 변수나 함수를 사용하고자 한다면
        //       변수 , 함수 생성할 때 자료형 앞에 public void 함수() , public int 변수; 이런식으로 사용한다.

        //       결론적으론 클래스를 다른사람들이 이용할 때 잘못쓰기도 힘들게 만들어 놔라.
        //    */
        //    newPlayer.att = 0;
        //    newPlayer.Fight();
        //}
    } // 클래스 사용법
    class FuncEx
    {
        // 플레이어에게 전달해 주겠다.
        int hp = 100;
        public void Damage1(int _Dmg)
        {
            hp = hp - _Dmg;
        }
        // 두개가 될수도 있다.
        // 개수는 100개 이상도 넣어줄 수 있다. (매개변수를 말하는 중) (다른 말론 인자값이라고 할 수 있음.)
        public void Damage2(int _Dmg, int _SubDmg)
        {
            hp = hp - _Dmg;
            hp = hp - _SubDmg;
        }
        //static void Main(string[] args)
        //{
        //    Player newPlayer = new Player();
        //    newPlayer.SetHp(1000); // 이렇게 된다면 hp가 1000이 된다.

        //    /* 
        //       뭔가 증가하는 코드를 사용하고 싶다.
        //       newPlayer.hp = newPlayer.hp + 1;
        //       newPlayer.att = newPlayer.att + 1;
               
        //       이런식으로 사용하면 코드가 복잡해지기에 별로 좋은 코드는 아니다.
        //       그래서 함수를 사용한다.
               
        //       함수란 보통 클래스 외부와의 소통을 위해서 만든다.
               
        //       Damage는 맞는다는 뜻.
               
        //       (int _Dmg) 를 넣는다는 것은 외부에서
               
        //       한개의 int 값을 넣어서
               
        //       플레이어에게 전달해 주겠다.
        //    */
        //}
    }
    class Player
    {
        // LocalVar class 쪽에 객체화 시켜주기 위한 변수
        public int att;
        private int hp;

        public void Fight()
        {
            //함수 안에서 사용된 지역변수는 내부에서만 사용 가능. ( 그래서 이름 겹쳐져도 상관없음 )
            //int att;
            Console.WriteLine("플레이어가 싸운다.");
        }
        public void SetHp(int _Hp)
        {
            // 함수를 사용하면 f10 하나하나 디버깅 할 수 있다.
            // 내 HP가 0이 되는 순간만 체크 가능하며
            // 내 Hp가 1000 이 되는 순간도 체크 가능하다.
            // 그러므로 hp라는 변수명의 기능이 무엇인지 명확해진다.
            hp = _Hp;
        }
        public void LVUP()
        {
            // 상태라는 것은 멤버변수
            // 어떤 상태가 변화하는 순간.
            // 각각 증감 할 수 있다.
            att = 1000;
            hp = 10000;
        }
        
        //static void Main(string[] args)
        //{
        //    FuncEx newFuncEx = new FuncEx();

        //    newFuncEx.Damage1(10); // FuncEx 라는 클래스에서 볼 수 있음.
        //    newFuncEx.Damage2(10 , 20);
        //}
    } // 게임에서 사용하기 위해서 여기까지 설계했다.

    // 컨트롤 시프트 u 대문자로 변경하는 단축키
    struct STRUCTDATA
    {
        // 클래스와 비슷한데 안되는 것이 있다.
        // 리터럴 초기화가 안된다.
        //  = 0 안된다.
        // = 0이 기본이다.
        public int a;
        public int b;

        public void Func()
        {
            // 메서드 내부에서는 리터럴 초기화 가능.
            a = 100;
            b = 100;
        }
    }
    class Struct
    {
        static void Test(STRUCTDATA _data)
        {
            _data.a = 100;
        }
        //static void Main(string[] args)
        //{
        //    STRUCTDATA newData = new STRUCTDATA(); // 클래스와 동일한 방식.
            
        //    newData.a = 10;
        //    newData.b = 10;
        //    // 참조형과 값형이 있다.
        //    // 클래스를 객체화하면 그건 참조형이다.
        //    Test(newData); // 변경 하지 않는 값. Struct 는 값 형이다.
        //}
    } // 값 형 읽는 용도.
    
    // 다른 언어에선 정수형 상수라고 하는데 C# 에선 그냥 상수 이다.
    // 보통 어떤 상태를 표현하는 것 중
    // 나만의 것을 가지고 싶을 때 사용한다.
    // 열거형이라고 불리며 사용법.
    // 명찰에 가까운 값이다.
    enum ITEMTYPE
    {
        // 내가 값의 범위를 지정한 새로운 자료형을
        // 만들어 낼 수 있다는 장점이 있고
        // switch 문과 궁합이 좋다.
        EQUIP ,
        POTION ,
        QUEST ,
        NONESELECT
    }
    class Item
    {
        public ITEMTYPE itemType = ITEMTYPE.EQUIP;

        public void PotionTypeSetting()
        {
            itemType = ITEMTYPE.POTION;
        }
    }
    class _22Enum
    {
        // 기본 자료형 - > 이미 있다. int 같은 것들

        // 사용자 정의자료형중 하나.
        // class (참조형 사용자정의), struct (값형 사용자 정의), enum (값형 사용자 정의)이렇게 세가지가 있다.
        //static void Main(string[] args)
        //{
        //    Item newItem = new Item();
        //    newItem.itemType = ITEMTYPE.POTION;
        //    newItem.PotionTypeSetting();
        //    // 값형이고.
        //    // int라고 생각해도 된다.
        //    // 사용방법 제외하고는 그냥 int라고 생각해도 된다.

        //    Console.WriteLine(ITEMTYPE.POTION);

        //    ITEMTYPE type = ITEMTYPE.POTION;

        //    switch (type)
        //    {
        //        case ITEMTYPE.EQUIP:
        //            break;
        //        case ITEMTYPE.POTION:
        //            break;
        //        case ITEMTYPE.QUEST:
        //            break;
        //        case ITEMTYPE.NONESELECT:
        //            break;
        //        default:
        //            break;
        //    }
        //}
    }// 열거형 값형.

    class FightUnit
    {
        //          public      protected   private
        // 범위     외부까지     자식까지     나만
        protected int att = 10;
        protected int hp = 100;
        public void Damage(FightUnit _otherUnit)
        {
            // 나는 fightUnit 지만
            // 이안에서 플레이어의 기능을 쓰고 싶은것.
            // 다운 캐스팅
            // 다운 캐스팅은 최대한 지양(피하라)한다.
            // 플레이어를 실수로 몬스터로 변경할 수도 있게 된다.
            // PLAYER otherPlayer = _otherUnit;

            //this.hp -= _otherUnit.att;

        }
    }
    // 내려준다 , 상속 시킨다.
    // C#에서 클래스 상속이란 오직 하나만 가능.
    // 클래스 상속을 여러개 받는 언어들도 존재하지만 (대표적 C++)
    // C#은 아니다.
    class PLAYER : FightUnit
    {
        int lv = 1;
        public int Heal()
        {
            return hp + 100;
        }
    }
    class MONSTER : FightUnit
    {
        
    }

    class _23Inheritance // 상속
    {
        // 상속이란
        // 코드 재활용성을 향상시키기 위해서
        // (똑같은 코드 2번 치기 싫다.)
        // 어떤 계열이 있느냐를 파악하는 감.
        // 공통되는 기능을 하는 멤버변수와 함수를 걷어내기 위함.
        // 새로운 클래스에 그 모든 멤버변수와 함수를 넣는다.
        // 상속시킨다.
        static void Main(string[] args)
        {
            PLAYER newPlayer = new PLAYER();
            MONSTER newMonster = new MONSTER();
            
            // 플레이어의 부분을 모두 다 포기하겠다.
            // 업캐스팅
            // 자식이 부모형이 되는 것.
            // 그러므로써 자식의 능력은 버린다.
            newPlayer.Damage(newMonster); // 상속 받은 메서드를 사용하여 newMonster 에게 공격 받는다.
            newMonster.Damage(newPlayer);
        }
    }
}
