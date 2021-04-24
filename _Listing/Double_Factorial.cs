using System;

namespace Training_Listing._Listing
{
    class Double_Factorial
    {
        static int Main()
        {
            int x = 0;
            Console.WriteLine ( "Введите число X для вычисления X!!" );
            try
            {
                x = Int32.Parse ( Console.ReadLine ( ) );
            }
            catch
            {
                Console.WriteLine ( "Неккоректный ввод !" );
            }

            Console.WriteLine ( "{0}!! = {1}", x, factorial ( x ) );
            Console.ReadKey ( );

            return 0;
        }

        //метод для вычисления двойного факториала
        static ulong factorial(int n)
        {
            ulong result, factorial = 1;

            //проверка на чётность
            if ( n % 2 == 0 )
            {
                result = 0;
                // "n/2" - вычисления количества необходимых итераций для цикла 
                for ( int k = 1; k <= (n / 2); k++ )
                {
                    //result += 2 - перебор всех чётных в числе n
                    //перемножение всех чётных и запись их в "factorial"
                    factorial *= (result += 2);
                }
            }
            else
            {
                result = 1;
                for ( int k = 1; k <= (n / 2); k++ )
                {
                    //result += 2 - перебор всех нечётных в числе n
                    //перемножение всех нечётных и запись их в "factorial"
                    factorial *= (result += 2);
                }
            }

            //возвращение результата метода
            return factorial;
        }
    }
}
