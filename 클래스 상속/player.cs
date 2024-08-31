using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 클래스_상속
{
    /*
     *  클래스 : 플레이어와 몬스터 전투 시스템을 제작
     *  플레이어, 몬스터 를 표현하기 위해 class라는 키워드를 사용하겠다.
     *  class Player {  }
     */

    /*
     *  플레이어
     *  기능 : 플레이어의 기능을 만든다.
     *  1. 공격한다
     *  2. 휴식한다
     *  3. 도망친다
     */

    internal class player
    {
        public int HP;
        public int AttackPower;

        public void Attack(Monster monster)
        {
            // 슬라임의 현재 체력 - 플레이어의 공격력
            monster.HP = monster.HP - AttackPower;
            Console.WriteLine("플레이어의 공격!");
            Console.WriteLine($"몬스터의 현재 체력 : {monster.HP}");
        }



        public void BeAttacked(player player)
        {
            //  플레이어의 체력 - 슬라임의 공격력
        }
    }
}
