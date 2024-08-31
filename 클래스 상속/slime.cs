using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

//  클래스 상속
//  클래스와 클래스 사이에 상속 관계를 가져야 하는 경우가 언제인가요?
//  unit -> 공격, 스탑, 홀드, 정찰
//  

//  상속 - 자식 한테 넘겨준다. ((모든)자식 한테 넘겨주지 않을 수도 있다.)
//  모든 유닛이 공격, 스탑, 홀드, 정찰 기능을 갖는다.
//  라바, 오버로드도 공격을 해야한다.

//  어떻게 상속을 하지 말지 결정하는가
//  IS-A : B(자식)는 A(부모)이다. 상속을 해라.
//  HAS-A : B가 A를 소요하고 있다. 상속을 사용하지 말라.


interface IAttack
{
    public void Attack();
}

class Unit
{
    public void Hold() { }

    public void Stop() { }

    public void Patrol() { }
}


class AttackableUnit : Unit, IAttack
{
    public void Attack()
    {
        Console.WriteLine("공격했다.");
    }
}

class UnassailableUnit : Unit
{

}


namespace 클래스_상속
{

    class Monster
    {
        public int HP;
        public int AttackPower;


        //  virtual 키워드를 수식받는 함수는 자식에서 같은 이름의 함수를 찾는다.
        public virtual void Attack(player player)
        {
            player.HP = player.HP - AttackPower;
            //Console.WriteLine("몬스터가 플레이어를 공격함");

        }

        /*
         *  형변환 : Monster class Type slime, Bear class Type
         *  if(변수 is 데이터 타입) -> True or False
         *  
         *  (변수 as 데이터 타입) -> 형변환을 하고, null을 반환
         *  
         *  변수?. -> 변수가 null이 아닐 때만 접근 하라.
         *  
         *  if(monster ! = null)
         */

        public virtual void BeAttacked(player player)
        {
            HP = HP - player.AttackPower;
            Console.WriteLine("플레이어가 몬스터를 공격함");
        }

        public void SpecialAttack()
        {
            Monster monster = new slime(); //   monster 안에 slime 데이터가 들어있으면 True

            if(monster is slime)
            {
                (monster as slime)?.Divide();
            }

            monster = new Bear();

            if(monster is Bear)
            {
                (monster as Bear)?.Howing();
            }


        }
        public void sound()
        {

        }
    }

    /*
     *  플레이어가 몬스터 클래스로 모든 몬스터를 공격할 수 있게 되었다.
     *  문제점 : slime도 몬스터라고 출력이 되고, Wolf도 몬스터라고 출력이 된다.
     *  slime은 슬라임이 공격했다, Wolf는 늑대가 공격했다
     */




    internal class slime : Monster
    {
        //  new 키워드를 사용한 트릭
        //  부모의 함수와는 다른 새로운 함수로 표현한다.
        //public new void Attack(player player)
        //{
        //    Console.WriteLine("새로운 공격(슬라임)");
        //}
        //
        //public void Attack(player player)
        //{
        //    base.Attack(player);
        //    Console.WriteLine("슬라임의 공격!");
        //}

        //  문법적으로 virtual 키워드를 수식받은 함수가 override 키워드를 수식 받는
        //  함수로 사용하라
        public override void Attack(player player)
        {
            base.Attack(player);
            Console.WriteLine("슬라임의 공격!");
        }

        public override void BeAttacked(player player)
        {
            base.BeAttacked(player);
            Console.WriteLine("슬라임이 공격 받음.");
        }

        public void Divide()
        {
            Console.WriteLine("슬라임이 분열 했다.");
        }
    }

     class Bear : Monster
     {
        public void Attack(player player)
        {
            Console.WriteLine("곰이 공격했다.");
        }
        public override void BeAttacked(player player)
        {
            base.BeAttacked(player);
            Console.WriteLine("곰이 공격 받음.");
        }

        public void Howing()
        {
            Console.WriteLine("곰이 울부 짖었다.");
        }
    }
}

