internal class Program
{
    private static void Main(string[] args)
    {
        int Input(string text) 
        {
        Console.Write(text);
        return Convert.ToInt32(Console.ReadLine()); 
        }

        void Task19() 
        {
            // Напишите программу, которая принимает на вход пятизначное число и
            // проверяет, является ли оно палиндромом.
            //14212->нет
            //12821->да
            //23432->да
        int N = 5;
        int counter = 0; /// no in for(i=0...;i++){...}        
            Console.WriteLine($"напиши число из {N} символов:");
        string number= Console.ReadLine();
            if (number.Length == N & N%2!=0)
            {
                while (counter < N / 2) ///for(i=0; i<N/2; i++)
                {
                    if (number[counter] == number[N - counter - 1])
                    {
                        Console.WriteLine($"{number[counter]}={number[N - counter - 1]}");
                    }
                    else 
                    { 
                        Console.WriteLine($"{number[counter]}!={number[N - counter - 1]}");
                        break;
                    }
                    counter++; /// no in for(..){...}
                }
                //Console.WriteLine($"{number} палиндром."); (??????????????)
                
            }
            else Console.WriteLine($"количество символов не соответствует {N} или введено чётное количество символов");
            
        //Console.WriteLine(number);
        }

        //Task19();

        void Task21() 
        {
            //Напишите программу, которая принимает на вход координаты двух точек и
            //находит расстояние между ними в 3D пространстве.
            //A(3, 6, 8); B(2, 1, -7), -> 15.84
            //A(7, -5, 0); B(1, -1, 9)-> 11.53

            double Dis(double a, double b) 
            {
                return Math.Pow((a - b),2);
            }
            double x1 = Input("x1=");
            double y1 = Input("y1=");
            double z1 = Input("z1=");
            double x2 = Input("x2=");
            double y2 = Input("y2=");
            double z2 = Input("z2=");

            Console.WriteLine($"Расстояние между двумя точками в 3D пространстве " +
                $"= {Math.Round(Math.Sqrt(Dis(x2, x1) + Dis(y2, y1) + Dis(z2, z1)),2)}");
        }
        //Task21();

        void Task23() 
        {
            //Напишите программу, которая принимает на вход число(N) и
            //выдаёт таблицу кубов чисел от 1 до N.
            //3-> 1, 8, 27
            //5-> 1, 8, 27, 64, 125

            int N = Input("Введи число N =");
            for (int i = 1; i <= N; i++)
            {
                Console.Write($"{i}^{i} = { Math.Pow(i, i)}");
                Console.WriteLine();
            }
        }
        Task23();


    }
}