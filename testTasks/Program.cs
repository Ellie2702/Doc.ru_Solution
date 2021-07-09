using System;

namespace testTasks
{
    class Program
    {

        public static void num_sum(int n)
        {
            char[] nums = n.ToString().ToCharArray();

            int sum = 0;
            for(int i = 0; i < nums.Length; i++)
            {
                sum += Convert.ToInt32(nums[i].ToString());
                Console.WriteLine(nums[i]);
            }

            Console.WriteLine(sum.ToString());
        }

        public static void how_many_cent(int count)
        {
            int p = 1;
            int n = 5;
            int d = 10;
            int q = 25;

            int balance = 0;
            int pc = 0, nc = 0, dc = 0, qc = 0;

            if(count < 0 || count == 0)
            {
                Console.WriteLine("Nickels: " + nc.ToString() + "\nPennies: " + pc.ToString() + "\nDimes: " + dc.ToString() + "\nQuarters: " + qc.ToString());
            } else
            {
                if (count > q)
                {
                    qc = count / q;
                    balance = count % q;
                }

                if (count < q && count > d)
                {
                    dc = count / d;
                    balance = count % d;
                }
                else if (count > q && balance > d)
                {
                    dc = balance / d;
                    balance = balance % d;
                }

                if (count < d && count > n)
                {
                    nc = count / n;
                    balance = count % n;
                }
                else if (count > d && balance > n)
                {
                    nc = balance / n;
                    balance = balance % n;
                }

                if (count < n && count > p)
                {
                    pc = count / p;
                    balance = count % p;
                }
                else if (count > n && balance > p)
                {
                    pc = balance / p;
                    balance = balance % p;
                }

                Console.WriteLine("Nickels: " + nc.ToString() + "\nPennies: " + pc.ToString() + "\nDimes: " + dc.ToString() + "\nQuarters: " + qc.ToString());
            }
        }

        public static void reverse_num(int n)
        {
            char[] nums = n.ToString().ToCharArray();
            char temp = ' ';

            for(int i = 0; i < nums.Length; i++)
            {
                for(int j = 0; j < nums.Length - 1; j++)
                {

                    if(Convert.ToInt32(nums[j+1].ToString()) > Convert.ToInt32(nums[j].ToString()))
                    {
                        temp = nums[j + 1];
                        nums[j + 1] = nums[j];
                        nums[j] = temp;
                    }
                }
            }

            string res = " ";

            for(int i = 0; i < nums.Length; i++)
            {
                res += nums[i].ToString();
            }

            Console.WriteLine(res);
        }

        public static void stroke_sum(int s, int[][] arr)
        {
            int sum = 0;
            for(int i = 0; i < arr[s-1].Length; i++)
            {
                sum += arr[s-1][i];
            }

            Console.WriteLine(sum.ToString());
        }

        public static int always_five()
        {
            char[] arr = new char[] { 'a', 'b', 'c', 'd', 'e' };
            return arr.Length;
        }

        static void Main(string[] args)
        {
            
            Console.WriteLine("Напишите число:\n");
            string n = Console.ReadLine();

            num_sum(Convert.ToInt32(n));

            Console.WriteLine("Количество центов:\n");
            string cent = Console.ReadLine();

            how_many_cent(Convert.ToInt32(cent));

            Console.WriteLine("Введите число для сортировки");
            string num = Console.ReadLine();

            reverse_num(Convert.ToInt32(num));

            int[][] triangel = new int[5][];
            triangel[1] = new int[2] { 3, 5 };
            triangel[2] = new int[3] { 7, 9, 11 };
            triangel[3] = new int[4] { 13, 15, 17, 19 };
            triangel[4] = new int[5] { 21, 23, 25, 27, 29 };


            Console.WriteLine("Введите номер строки треугольника:");
            int sNum = Convert.ToInt32(Console.ReadLine());

            if(sNum <= triangel.Length)
            {
                stroke_sum(sNum, triangel);
            } else
            {
                Console.WriteLine("В треугольнике меньше строк!");
            }

            Console.WriteLine("Вот ваша пятёрка!");
            int five = always_five();
            Console.WriteLine(five.ToString());
            Console.ReadLine();
        }
    }
}
