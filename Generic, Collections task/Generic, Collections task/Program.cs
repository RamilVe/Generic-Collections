using System;
using System.Collections;
using System.Collections.Generic;

namespace Generic__Collections_task
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //ArrayList

            ArrayList arrList = new ArrayList();

            arrList.Add("Hikmet");
            arrList.Add(12);
            arrList.Add(5.4f);
            arrList.AddRange(new ArrayList { "Abbas", true, 'b' });

            arrList.Insert(2, 300);
            arrList.InsertRange(3, new ArrayList { 74, 32, 55 });

            arrList.Remove("Hikmet");
            arrList.RemoveAt(5);


            foreach (var item in arrList)
            {
                Console.WriteLine(item);
            }

            //Console.WriteLine("=======ArrList1=====");
            ArrayList arrList1 = new ArrayList { 12, 78, 1, 56,  27};

            arrList1.Sort();
            arrList1.Reverse();
            Console.WriteLine(arrList1.Contains(15));
            Console.WriteLine(arrList1.Contains(1));
            //arrList1.Clear();

            arrList1.IndexOf(11);

            ArrayList subarrList1 = arrList1.GetRange(1, 2);
            Console.WriteLine(subarrList1);

            foreach (var item in subarrList1)
            {
                Console.WriteLine(item);
            }

            foreach (var item in arrList1)
            {
                Console.WriteLine(item);
            }

            //int[] numbers = new int[5];
            //arrList1.CopyTo(numbers);
            //foreach (var item in numbers)
            //{
            //    Console.WriteLine(item);
            //}

            //List

            List<string> cities = new List<string>();
            cities.Add("New York");
            cities.Add("London");
            cities.Add("Baku");
            cities.Add("Mumbai");

            cities.AddRange(new List<string> { "Chicago", "Moscow", "Ankara", "Istanbul" });
            Console.WriteLine(cities.BinarySearch("London"));

            Console.WriteLine(cities.Contains("Mumbai"));
            ////cities.Clear();


            cities.Insert(2, "Berlin");
            cities.Remove("Chicago");
            cities.RemoveAt(3);
            cities.Sort();
            foreach (var item in cities)
            {
                Console.WriteLine(item);
            }

            //SortedList

            SortedList sortedList = new SortedList();

            sortedList.Add("Hikmet", "+994551111111");
            sortedList.Add("Tofiq", "+994551111112");
            sortedList.Add("Nermin", "+994551111113");
            sortedList.Add("Abbas", "+994551111114");

            //sortedList.Clear();
            Console.WriteLine(sortedList.ContainsValue("+994551111111"));
            Console.WriteLine(sortedList.ContainsValue("+994551111115"));
            Console.WriteLine(sortedList.ContainsKey("Tofiq"));

            sortedList.RemoveAt(3);
            sortedList.Remove("Abbas");
            Console.WriteLine(sortedList.IndexOfKey("Abbas"));
            Console.WriteLine(sortedList.IndexOfValue("+994551111113"));


            foreach (var key in sortedList.Values)
            {
                Console.WriteLine(key);
            }

            //Dictionary

            Dictionary<string, int> students = new Dictionary<string, int>();
            students.Add("Abbas", 80);
            students.Add("Tofiq", 55);
            students.Add("Namiq", 24);
            students.Add("Abdulla", 49);

            ////students.Clear();
            students.TryAdd("Cavid", 100);
            students.TryAdd("Tofiq", 72);
            students.Remove("Cavid");
            Console.WriteLine(students.ContainsKey("Abbas"));
            Console.WriteLine(students.ContainsValue(45));

            Console.WriteLine(students.TryGetValue("Abdulla", out int value));
            students.ToString();
            foreach (var key in students.Keys)
            {
                Console.WriteLine(key);
            }

            //Stack
            Stack numbers = new Stack();
            numbers.Push(13);
            numbers.Push(4);
            numbers.Push(70);
            numbers.Push(52);

            //numbers.Clear();

            Console.WriteLine(numbers.Peek());
            numbers.Pop();
            Console.WriteLine(numbers.Count);
            Console.WriteLine(numbers.Contains(5));
            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }

            //Queue

            Queue digits = new Queue();
            digits.Enqueue(0);
            digits.Enqueue(1);
            digits.Enqueue(3);
            digits.Enqueue(2);
            digits.Dequeue();
            Console.WriteLine(digits.Peek());

            Console.WriteLine(digits.Contains(0));
            //digits.Clear();
            Array[] array = new Array[digits.Count];
            
            foreach (var item in digits)
            {
                Console.WriteLine(item);
            }
        }
    }
}
