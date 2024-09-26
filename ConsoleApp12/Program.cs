using System;

namespace ConsoleApp12
{
    class Program
    {
        static void Main(string[] args)
        {
            //タプル型の戻り値
            (string name, int age) GetMember()
            {
                var n = "Queens";
                var a = 18;
                return (n, a); //タプル型のリテラル
            }
            var m = GetMember();
            Console.WriteLine(m.name); //出力値: Queens
            Console.WriteLine(m.age); //出力値: 18

        }
    }
}
