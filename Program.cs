﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeWork13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();

            Console.WriteLine(rand.Next(1, 30));

            //Task2();
            //Task3();
            //Task4();
            Task5();
        }
        /// <summary>
        /// 1.	Создать коллекцию List <int>. 
        /// Вывести на экран позицию и значение элемента, 
        /// являющегося вторым максимальным значением в коллекции 
        /// a.Удалить все нечетные элементы списка List<int>
        /// </summary>
        static void Task1()
        {
            List<int> list = InputList<int>();
            int max1 = list[0];
            int max2 = list[0];
            int index1 = 0;
            int index2 = 0;

            for(int i = 0; i < list.Count; i++)
            {
                if (max1 < list[i])
                {
                    max2 = max1;
                    max1 = list[i];
                    index2 = index1;
                    index1 = i;
                }
                Console.WriteLine($"Второй максимальный элемент: {max2}, его индекс: {index2}");

                for (i = 0; i < list.Count; i++)
                {
                    if (list[i] % 2 != 0)
                    {
                        list.RemoveAt(i);
                    }
                }
                foreach(int item in list)
                {
                    Console.WriteLine(item + " ");
                }
                Console.WriteLine();
            }
        }
        static List<T> InputList<T>()
        {
            List<T> list = new List<T>();
            Random rand = new Random ();
            for(int i = 0; i < rand.Next(1, 30); i++)
            {
                var temp = Convert.ChangeType(rand.Next(1, 30), typeof(T));
                
                list.Add((T)temp);
            }
            return list;
        }

        /// <summary>
        /// 2.	Дана коллекция типа List<double>. 
        ///     Вывести на экран элементы списка, 
        ///     значение которых больше среднего арифметического всех элементов коллекции.
        /// </summary>
        static void Task2()
        {
            List<double> list = InputList<double>();

            double sum = 0;
            for(int i = 0; i < list.Count; i++)
            {
                sum += list[i];
            }
            double average = sum / list.Count;

            List<double> result = list.Where(a => a > average).ToList();

            Console.WriteLine("average: " + average);

            foreach(var i in list)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            foreach (var i in result)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }

        /// <summary>
        /// 3.	Дан файл, в котором записан набор чисел. 
        /// Переписать в другой файл все числа в обратном порядке.
        /// </summary>
        static void Task3()
        {
            List<int> list = InputList<int>();
            foreach(int item in list)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            List<int> result = new List<int>();

            for(int i = list.Count - 1; i > 0; i--)
            {
                result.Add(list[i]);
            }

            Stack<int> result2 = new Stack<int>();

            for(int i = 0; i < list.Count; i++)
            {
                result2.Push(list[i]);
            }
            foreach(int i in result2)
            {
                Console.Write(i + " ");
            }
        }
        static void Task4()
        {
            string filePath = @"C:\temp\employees.txt";

            try
            {
                var employees = File.ReadAllLines(filePath).Select(line => new Employee(line)).ToList();

                var lowerSalaryEmployees = employees.Where(e => e.Salary < 10000);
                var higherSalaryEmployees = employees.Where(e => e.Salary >= 10000);

                foreach (var employee in lowerSalaryEmployees.Concat(higherSalaryEmployees))
                {
                    Console.WriteLine(employee);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Произошла ошибка: " + ex.Message);
            }
        }
        static void Task5()
        {
            DiskKatalog catalog = new DiskKatalog();

            Disk cd1 = new Disk("Исполнитель 1");
            cd1.AddSong("Песня 1");
            cd1.AddSong("Песня 2");
            catalog.AddCD("CD1", cd1);

            Disk cd2 = new Disk("Исполнитель 2");
            cd2.AddSong("Песня 3");
            catalog.AddCD("CD2", cd2);

            catalog.PrintCatalog();

            Console.WriteLine("\nПоиск по исполнителю 'Исполнитель 1':");
            catalog.SearchByArtist("Исполнитель 1");

            Console.WriteLine("\nСодержимое CD1:");
            catalog.PrintCD("CD1");

            cd1.RemoveSong("Песня 1");
            catalog.RemoveCD("CD2");

            Console.WriteLine("\nКаталог после изменений:");
            catalog.PrintCatalog();
        }
    }
}
