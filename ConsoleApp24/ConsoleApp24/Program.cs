using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp24
{
    struct vector
    {
        int[] arr;
        
        public vector(int n=3)
        {
            Random r = new Random();
            arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                arr[i] = r.Next(10);
            }
        }
        public void Print()
        {
            Console.WriteLine(arr);
        }
        public int mult(int n1)
        {
            int rez = 0;
            for (int i = 0; i < 3; i++)
            {
                rez = arr[i] * n1;
            }
            return rez;
        }

        public void sum()
        {
            int sum = 0;
            for (int i = 0; i < 3; i++)
            {
                sum += arr[i];
            }
        }
        public void minus()
        {
            int min = 0;
            for (int i = 0; i < 3; i++)
            {
                min -= arr[i];
            }
        }
    }

    struct num10
    {
        public int number { get; set; }
        public void Print()
        {
            Console.WriteLine(number);
        }
        public void binary()
        {
            string Binary = Convert.ToString(number, 2);
        }
        public void octal()
        {
            string octal = Convert.ToString(number, 8);
        }
        public void hexadecimal()
        {
            string hexadecimal = Convert.ToString(number, 16);
        }

    }

    struct RGB
    {
        public int r { get; set; }
        public int g { get; set; }
        public int b { get; set; }
        public void print()
        {
            Console.WriteLine($"RGB: {r}\t {g}\t {b}\n");
        }
        public void HEX()
        {
            string hexadecimal = Convert.ToString(r, 16);
            string hexadecimal2 = Convert.ToString(g, 16);
            string hexadecimal3 = Convert.ToString(b, 16);
            Console.WriteLine($"HEX: #{hexadecimal}\t{hexadecimal2}\t{hexadecimal3}\n");
        }
        public void HSV(RGB rgb)
        {
            double delta, min;
            double h = 0, s, v;
            min = Math.Min(Math.Min(rgb.r, rgb.g), rgb.b);
            v = Math.Max(Math.Max(rgb.r, rgb.g), rgb.b);
            delta = v - min;

            if (v == 0.0)
                s = 0;
            else
                s = delta / v;

            if (s == 0)
                h = 0.0;

            else
            {
                if (rgb.r == v)
                    h = (rgb.g - rgb.b) / delta;
                else if (rgb.r == v)
                    h = 2 + (rgb.b - rgb.g) / delta;
                else if (rgb.b == v)
                    h = 4 + (rgb.r - rgb.g) / delta;

                h *= 60;

                if (h < 0.0)
                    h = h + 360;
            }
        }
        public void CMYK()
        {
            int C = 0, M = 0, Y = 0, K=0;
            r = Convert.ToInt32((100 - C) * (100 - K) * 255.0 / 10000);
            g = Convert.ToInt32((100 - M) * (100 - K) * 255.0 / 10000);
            b = Convert.ToInt32((100 - Y) * (100 - K) * 255.0 / 10000);

        }
    }

    class program
    {
        static void Main(string[] args)
        {
            vector obj1 = new vector(5);
            Console.WriteLine("Печать объекта класса obj1");
            Console.WriteLine(obj1.mult(5));
        }
    }

}


    

