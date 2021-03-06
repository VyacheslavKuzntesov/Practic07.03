using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using x = A;

namespace Practic07._03
{

    //namespace A
    //{
    //    class Incr
    //    {
    //        private int _count;
    //        public Incr(int count)
    //        {
    //            _count = count;
    //        }
    //        public int MultyIncr()
    //        {
    //            for (int i = 0; i < 5; i++)
    //                _count++;
    //            return _count;
    //        }
    //    }
    //}
    //namespace B
    //{
    //    class Incr
    //    {
    //        private int _var;
    //        public Incr(int var)
    //        {
    //            _var = var;
    //        }
    //        public int AnotherMultyIncr()
    //        {
    //            for (int i = 0; i < 5; i++)
    //                _var += 10;
    //            return _var;
    //        }
    //    }



    //}



    class Example
    {
        //int _num;
        //public int Num
        //{
        //    get { return _num; }
        //    set { _num = value; }
        //}


        //string _firstName;

        //public string FirstName
        //{
        //    get { return _firstName != null ? _firstName : "Не задано"; }
        //    set { _firstName = value.ToUpper(); }
        //}

        //string _lastName;

        //public string LastName
        //{
        //    get { return _lastName != null ? _lastName : "Не задано"; }
        //    set { _lastName = value.ToUpper(); }
        //}

        //int _age;

        //public int Age
        //{
        //    get { return _age; }
        //    set { _age = (value > 100 || value < 1) ? 0 : value; }
        //}

        //int _wage;

        //public int Wage
        //{
        //    get { return _wage; }
        //    set { _wage = value<0?0:value; }
        //}

        //public string Print()
        //{
        //    return $"Имя: {FirstName}\n" +
        //        $"Фамилия: {LastName}\n" +
        //        $"Возраст: {Age}\n" +
        //        $"Зарплата: {Wage}\n";
        //}



    }

    class Student
    {
        public string FirstName { get; set; } = "Александр";
        public string LastName { get; set; } = "Дронов";
        public DateTime DataBirth { get; set; }
        public string Group { get; set; }

        public string Print()
        {
            return $"Имя: {FirstName} Фамилия: {LastName} " + $"Дата рождения: {DataBirth.ToLongDateString()} Номер группы: {Group}";
        }
    }

    class City
    {
        public string NameCity { get; set; } = "Нет данных";
        public string NameCountry { get; set; } = "Нет данных";
        public int CountPeople { get; set; } = 0;
        public int CodePhone { get; set; } = 0;
        public string[] NameDistr { get; set; } = new string[1] { "Нет данных" };

        public void Print()
        {
            Write($"{NameCountry}, {NameCity}, " +
                $"{CountPeople}, " +
                $"{CodePhone},");
            foreach (var city in NameDistr)
            {
                Write(city+", ");
            }
            WriteLine();
        }
    }
   


internal class Program
    {
        //private static int Sum(params int[] arr)
        //{
        //    int res = 0;
        //    foreach (int i in arr)
        //    {
        //        res += i;
        //    }
        //    return res;
        //}


static void Main(string[] args)
        {
            //Console.WriteLine(Sum(1, 2, 3, 4));

            //MyClass.Method1();
            //MyClass.Method2();

            //Example example = new Example();
            //Console.WriteLine("Введите число: ");
            //example.Num = (int.Parse(Console.ReadLine()));
            //Console.WriteLine("Вы ввели: ");
            //Console.WriteLine(example.Num);


            //Example example = new Example
            //{
            //    FirstName = "Александр",
            //    LastName = "Дронов",
            //    Age = 92,
            //    Wage = 5000
            //};

            //Example example1 = new Example();
            //example1.FirstName = "Андрей";
            //example1.Age = 500;
            //example1.Wage = -10;

            //Console.WriteLine(example.Print());
            //Console.WriteLine(example1.Print());


            //Student student = new Student();
            //Student student2 = new Student 
            //{ 
            //    FirstName = "John",
            //    LastName = "Doe",
            //    DataBirth = new DateTime(1990,12,11),
            //    Group = "25TR45" 
            //};

            //Console.WriteLine(student.Print());
            //Console.WriteLine(student2.Print());


            //Console.WriteLine("Экземпляр класса Student не создан");
            //Student student1 = null;
            //DateTime? date = student1?.DataBirth;
            //Console.WriteLine($"Дата рождения: {date}");

            //Console.WriteLine("Group не указана");

            //Student student2 = new Student();
            //string groupName = student2?.Group;
            //Console.WriteLine($"Название группы: {groupName}");

            //Student[] students = {student1,student2};
            //Student student = students?[0] ?? new Student();
            //Console.WriteLine(student.Print());


            //B.Incr incr = new B.Incr(10);
            //Console.WriteLine(incr.AnotherMultyIncr());

            //A.Incr incr2 = new A.Incr(5);
            //Console.WriteLine(incr2.MultyIncr());

            //x::ClassA a = new x::ClassA();
            //a.Print();

            //x::ClassB b = new x::ClassB();
            //b.Print();

            //x::ClassC c = new x::ClassC();
            //c.Print();

            //City city = new City 
            //{ 
            //    NameCity = "Moscow",
            //    NameCountry = "Russia",
            //    CountPeople = 100000000,
            //    CodePhone = 495,
            //    NameDistr = new string[] {"Бутова","Сколково","ВДНХ"}
            //};
            //city.Print();

            //City city2 = new City();
            //city2.NameCity = "Arkhangelsk";
            //city2.CodePhone = 8182;
            //city2.CountPeople = 50000;

            //city2.Print();


        }
    }
}
