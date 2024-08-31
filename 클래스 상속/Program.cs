namespace 클래스_상속
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("클래스 상속");

            player player = new player();
            player.HP = 100;
            player.AttackPower = 10;

            slime slime = new slime();
            slime.HP = 50;
            slime.AttackPower = 5;

            Bear bear = new Bear();
            bear.HP = 30;
            bear.AttackPower = 3;
            
            player.Attack(slime);

            slime.Attack(player);

            bear.Attack(player);

            slime.BeAttacked(player);

            bear.BeAttacked(player);

            slime.SpecialAttack();  //   슬라임이 분열했다.
            bear.SpecialAttack();   //  곰이 울부짖었다.

            Parent parent = new child(2, 3);
            parent.ShowInfo();
        }
    }
}
