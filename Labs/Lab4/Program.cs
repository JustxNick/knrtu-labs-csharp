﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace laba4
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> lol = new List<int>();

            for (int i = 0; i < 5; i++)
            {
                int num = Convert.ToInt32(Console.ReadLine());
                lol.Add(num);
            }

            int k = 1;
            foreach (int i in lol)
            {
                Console.WriteLine($"Element {k}: {i}");
                k++;
            }
            
            Console.WriteLine("Enter a num in the last if list: ");
            int n = Convert.ToInt32(Console.ReadLine());
            lol.Add(n);

            k = 1;
            Console.WriteLine("Changed List:");
            foreach (int i in lol)
            {
                Console.WriteLine($"Element {k}: {i}");
                k++;
            }
            
            Console.WriteLine();
            List<int> kek = new List<int>(3);
            for (int i = 0; i < 3; i++)
            {
                int ad = Convert.ToInt32(Console.ReadLine());
                kek.Add(ad);
            }
            
            k = 1;
            Console.WriteLine("Second list: ");
            foreach (int i in kek)
            {
                Console.WriteLine($"Element {k}: {i}");
                k++;
            }
            Console.WriteLine();

            int p = 2;
            foreach (int i in kek)
            {
                lol.Insert(p, i);
                p++;
            }

            k = 1;
            Console.WriteLine("Changed first list: ");
            foreach (int i in lol)
            {
                Console.WriteLine($"Element {k}: {i}");
                k++;
            }
            Console.WriteLine();
            
            // insert max index
            lol.Insert(k / 2, lol.IndexOf(lol.Max()));

            Console.WriteLine($"Size of first list: {k}");
            Console.WriteLine($"Maximal element: {lol.Max()}");
            Console.WriteLine($"Minimal element: {lol.Min()}");

            int[] arr = new int[3];

            k = 0;
            foreach (int i in kek)
            {
                arr[k] = i;
                k++;
            }

            Console.WriteLine("Array from second list: ");
            foreach (int i in arr)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine();

            kek.RemoveAt(1);

            Console.WriteLine("Element from second list: ");
            foreach (int i in kek)
            {
                Console.Write($"{i} ");
            }
        }
        //2 variant
        public static void Task1()
        {
            List<int> list = new List<int>(5);
            for (int i = 0; i < 5; i++)
            {
                list.Add(i);
            }
            Write(list);
            list.Add(list.Count);
            Write(list);
            List<int> secList = new List<int>(3);
            for (int i = 0; i < 3; i++)
            {
                secList.Add(i);
            }
            Write(secList);
            list.InsertRange(3, secList);
            Write(list);
            Console.WriteLine(list.Count);
            int min = list[0];
            int max = list[0];
            foreach (int el in list)
            {
                if (el < min)
                {
                    min = el;
                }

                if (el > max)
                {
                    max = el;
                }
            }

            Console.WriteLine("Минимальный " + min);
            Console.WriteLine("Максимальный " + max);
            int[] arr = secList.ToArray();
            foreach (int el in arr)
            {
                Console.Write(el + " ");
            }
            secList.RemoveAt(2);
            Write(secList);
            list.RemoveAt(list.IndexOf(max));
            Write(list);
        }

        static void Write(List<int> list)
        {
            foreach (int el in list)
            {
                Console.Write(el + " ");
            }

            Console.WriteLine();
        }
    }
}
