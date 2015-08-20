using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Dice
{
    public int d1, d2, d3, d4, d5, d6;
    public Dice() { d1 = 0; d2 = 0; d3 = 0; d4 = 0; d5 = 0; d6 = 0; }
};

namespace MoonCake
{
    class Program
    {
        static void draw(int a,int b,int c) {
            string s1, s2, s3;
            string[,] s = new string[3, 7];
            s[0, 1] = ("┃        ┃");
            s[1, 1] = ("┃   ●   ┃");
            s[2, 1] = ("┃        ┃");

            s[0, 2] = ("┃   ○   ┃");
            s[1, 2] = ("┃        ┃");
            s[2, 2] = ("┃   ○   ┃");

            s[0, 3] = ("┃ ○     ┃");
            s[1, 3] = ("┃   ○   ┃");
            s[2, 3] = ("┃     ○ ┃");

            s[0, 4] = ("┃ ●  ● ┃");
            s[1, 4] = ("┃        ┃");
            s[2, 4] = ("┃ ●  ● ┃");

            s[0, 5] = ("┃ ○  ○ ┃");
            s[1, 5] = ("┃   ○   ┃");
            s[2, 5] = ("┃ ○  ○ ┃");

            s[0, 6] = ("┃ ○  ○ ┃");
            s[1, 6] = ("┃ ○  ○ ┃");
            s[2, 6] = ("┃ ○  ○ ┃");

            s1 = s[0, a] + s[0, b] + s[0, c] + '\n';
            s2 = s[1, a] + s[1, b] + s[1, c] + '\n';
            s3 = s[2, a] + s[2, b] + s[2, c] + '\n';
            Console.Write("┏━━━━┓┏━━━━┓┏━━━━┓\n");
            Console.Write(s1);
            Console.Write(s2);
            Console.Write(s3);
            Console.Write("┗━━━━┛┗━━━━┛┗━━━━┛\n");
        }
        static void gaming() {
            Random random = new Random();
            int i,j;
            int[] a = new int[6];
            string s1, s2, s3,s4,s5,s6;
            string[,] s = new string[3, 7];
            s[0, 1] = ("┃        ┃");
            s[1, 1] = ("┃   ●   ┃");
            s[2, 1] = ("┃        ┃");

            s[0, 2] = ("┃   ○   ┃");
            s[1, 2] = ("┃        ┃");
            s[2, 2] = ("┃   ○   ┃");

            s[0, 3] = ("┃ ○     ┃");
            s[1, 3] = ("┃   ○   ┃");
            s[2, 3] = ("┃     ○ ┃");

            s[0, 4] = ("┃ ●  ● ┃");
            s[1, 4] = ("┃        ┃");
            s[2, 4] = ("┃ ●  ● ┃");

            s[0, 5] = ("┃ ○  ○ ┃");
            s[1, 5] = ("┃   ○   ┃");
            s[2, 5] = ("┃ ○  ○ ┃");

            s[0, 6] = ("┃ ○  ○ ┃");
            s[1, 6] = ("┃ ○  ○ ┃");
            s[2, 6] = ("┃ ○  ○ ┃");
            for (j = 0; j != 20; j++)
            {
                Console.Clear();
                for (i = 0; i != 6; i++) { a[i] = Convert.ToInt32(random.Next(1, 7)); }
                s1 = s[0, a[0]] + s[0, a[1]] + s[0, a[2]] + '\n';
                s2 = s[1, a[0]] + s[1, a[1]] + s[1, a[2]] + '\n';
                s3 = s[2, a[0]] + s[2, a[1]] + s[2, a[2]] + '\n';
                s4 = s[0, a[3]] + s[0, a[4]] + s[0, a[5]] + '\n';
                s5 = s[1, a[3]] + s[1, a[4]] + s[1, a[5]] + '\n';
                s6 = s[2, a[3]] + s[2, a[4]] + s[2, a[5]] + '\n';
                Console.Write("┏━━━━┓┏━━━━┓┏━━━━┓\n");
                Console.Write(s1);
                Console.Write(s2);
                Console.Write(s3);
                Console.Write("┗━━━━┛┗━━━━┛┗━━━━┛\n");
                Console.Write("┏━━━━┓┏━━━━┓┏━━━━┓\n");
                Console.Write(s4);
                Console.Write(s5);
                Console.Write(s6);
                Console.Write("┗━━━━┛┗━━━━┛┗━━━━┛\n");
                System.Threading.Thread.Sleep(200);
            }
        }
        static int result(int[] a)
        {
            Dice d = new Dice();
            int i;
            int[] n = new int[6];
            for (i = 0; i != 6; i++)
            {
                if (a[i] == 1) { d.d1++; }
                if (a[i] == 2) { d.d2++; }
                if (a[i] == 3) { d.d3++; }
                if (a[i] == 4) { d.d4++; }
                if (a[i] == 5) { d.d5++; }
                if (a[i] == 6) { d.d6++; }
                n[i] = a[i]; 
            }
            gaming();
            Console.Clear();
            draw(n[0], n[1], n[2]);
            draw(n[3], n[4], n[5]);
            if (d.d4 == 6) return 11;
            else if (d.d1 == 6 || d.d2 == 6 || d.d3 == 6 || d.d5 == 6 || d.d6 == 6) return 7;
            else if (d.d4 == 5) return 9;
            else if (d.d4 == 4 && d.d1 == 1) return 10;
            else if (d.d4 == 4) return 8;
            else if (d.d1 == 5 || d.d2 == 5 || d.d3 == 5 || d.d5 == 5 || d.d6 == 5) return 6;
            else if (d.d1 == 1 && d.d2 == 1 && d.d3 == 1 && d.d4 == 1 & d.d5 == 1 & d.d6 == 1) return 5;
            else if (d.d1 == 4 || d.d2 == 4 || d.d3 == 4 || d.d5 == 4 || d.d6 == 4) return 4;
            else if (d.d4 == 3) return 3;
            else if (d.d4 == 2) return 2;
            else if (d.d4 == 1) return 1;
            else return 0;
        }
        static void MCG()
        {
            Random random = new Random();

            int i;
            int[] a = new int[6];
            for (i = 0; i != 6; i++) { a[i] = Convert.ToInt32(random.Next(1, 7)); }
            Console.Write("result: ");
            for (i = 0; i != 6; i++) { Console.Write(" {0} ", a[i]); }
            Console.WriteLine("");
            int r = result(a);
            Console.WriteLine();
            switch (r)
            {
                case 0: Console.WriteLine("很遗憾，木有奖"); break;
                case 1: Console.WriteLine("一秀"); break;
                case 2: Console.WriteLine("二举"); break;
                case 3: Console.WriteLine("三红"); break;
                case 4: Console.WriteLine("四进"); break;
                case 5: Console.WriteLine("对堂"); break;
                case 6: Console.WriteLine("五子"); break;
                case 7: Console.WriteLine("六朴黑"); break;
                case 8: Console.WriteLine("状元！！！！"); break;
                case 9: Console.WriteLine("五红！！！！！"); break;
                case 10: Console.WriteLine("状元插金花~~"); break;
                case 11: Console.WriteLine("满堂红！！！！！！"); break;
            }
            Console.WriteLine("");
            Console.WriteLine("按任意键继续...");
            Console.ReadKey();
            Console.WriteLine("");
        }
        static void Main(string[] args)
        {
            string m;
            char c;
            while (true)
            {
                Console.WriteLine("           博饼程序");
                Console.WriteLine("请选择功能:");
                Console.WriteLine("1.博饼");
                Console.WriteLine("2.退出");
                m = Console.ReadLine();
                c = m[0];
                if (c == '1') MCG();
                else if (c == '2') break;
                else 
                { Console.WriteLine("输入错误！"); Console.WriteLine(""); }
                Console.Clear();
            }
        }

    }
}