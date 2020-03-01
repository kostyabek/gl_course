using System;
using System.IO;
using System.Linq;
using System.Threading;
using Microsoft.VisualBasic;
using System.Diagnostics;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace C.Sharp.Course
{
    class Shape
    {
        private double _width;
        private double _height;

        public double Width
        {
            get { return _width; }
            set { _width = value; }
        }
        public double Height
        {
            get { return _height; }
            set { _height = value; }
        }
        public Shape() 
        {
            _height = 0;
            _width = 0;
        }
        public double Area()
        {
            return _width*_height;
        }
    }

    class Shape1 : Shape 
    { 
    
    }
    class Shape2 : Shape
    {

    }
    class Shape3 : Shape
    {

    }
    class Shape4 : Shape
    {

    }
    enum Positions
    { 
        None,
        HR,
        PM,
        SE,
        LG,
        QA
    }
    class Employee 
    {
        private string _name;
        private string _surname;
        private string _company;
        private float _salary;
        private Positions _position;

        public Employee() 
        {
            _name = "N/A";
            _surname = "N/A";
            _company = "Yotsuba";
            _salary = 0;
            _position = Positions.None;
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public string Surname
        {
            get { return _surname; }
            set { _surname = value; }
        }
        public string Company
        {
            get { return _company; }
            set { _company = value; }
        }
        public float Salary
        {
            get { return _salary; }
            set { _salary = value; }
        }
        public Positions Position
        {
            get { return _position; }
            set { _position = value; }
        }
    }

    class HR : Employee 
    {
         
    }
    class PM : Employee
    {

    }
    class SE : Employee
    {

    }
    class LG : Employee
    {

    }
    class QA : Employee
    {

    }
    class Program
    {
        static void Main(string[] args)
        {
            //TASK 1
            //Shape1 sh1 = new Shape1();
            //sh1.Width = 5.14;
            //sh1.Height = 22.1;
            //Console.WriteLine("Shape1 area = {0}", sh1.Area());
            //Shape2 sh2 = new Shape2();
            //sh2.Width = 4.14;
            //sh2.Height = 21.1;
            //Console.WriteLine("Shape1 area = {0}", sh2.Area());
            //Shape3 sh3 = new Shape3();
            //sh3.Width = 3.14;
            //sh3.Height = 20.1;
            //Console.WriteLine("Shape1 area = {0}", sh3.Area());
            //Shape4 sh4 = new Shape4();
            //sh4.Width = 2.14;
            //sh4.Height = 19.1;
            //Console.WriteLine("Shape1 area = {0}", sh4.Area());

            //TASK 2
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("====================Welcome to 'EMA'! (Employee Managing Application)====================");
            string reader;
            int intParser;
            float floatParser;
            bool flag = false;
            int switcher;
            List<Employee> empls = new List<Employee>();
            Positions posSwitcher;
            string path = @"D:\EMA_DB.txt";
            if (File.Exists(path))
            {
                string[] dataLines = File.ReadAllLines(path);
                if (dataLines.Length >= 4)
                {
                    for (int i = 0; i < dataLines.Length; i += 4)
                    {
                        reader = dataLines[i + 3];
                        intParser = int.Parse(reader);
                        posSwitcher = (Positions)intParser;
                        switch (posSwitcher)
                        {
                            case Positions.HR:
                                HR hr = new HR();
                                empls.Add(hr);
                                break;
                            case Positions.LG:
                                LG lg = new LG();
                                empls.Add(lg);
                                break;
                            case Positions.PM:
                                PM pm = new PM();
                                empls.Add(pm);
                                break;
                            case Positions.QA:
                                QA qa = new QA();
                                empls.Add(qa);
                                break;
                            case Positions.SE:
                                SE se = new SE();
                                empls.Add(se);
                                break;
                        }
                    }
                    int j = 0;
                    for (int i = 0; i < empls.Count; i++)
                    {
                        empls[i].Name = dataLines[j];
                        empls[i].Surname = dataLines[j + 1];
                        reader = dataLines[j + 2];
                        floatParser = float.Parse(reader);
                        empls[i].Salary = floatParser;
                        reader = dataLines[j + 3];
                        intParser = int.Parse(reader);
                        empls[i].Position = (Positions)intParser;
                        j += 4;
                    }
                }
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("Initialized from {0}", path);
                Console.ForegroundColor = ConsoleColor.White;
            }
            while (flag != true)
            {
                Console.WriteLine("What action do you want to execute?\n[1] - Add a new employee\n[2] - Delete an existing employee\n[3] - See average salary");
                reader = Console.ReadLine();
                switcher = int.Parse(reader);
                switch (switcher)
                {
                    case 1:
                        do
                        {
                            Console.Clear();
                            Console.WriteLine("Choose a position for the new employee:\n[1] - HR\n[2] - PM\n[3] - SoftwareEngineer\n[4] - LeadGeneration\n[5] - QA");
                            reader = Console.ReadLine();
                            intParser = int.Parse(reader);
                            posSwitcher = (Positions)intParser;
                            switch (posSwitcher)
                            {
                                case Positions.HR:
                                    HR hr = new HR();
                                    Console.Write("First name: ");
                                    hr.Name = Console.ReadLine();
                                    Console.Write("Last name: ");
                                    hr.Surname = Console.ReadLine();
                                    Console.Write("Salary($): ");
                                    reader = Console.ReadLine();
                                    floatParser = float.Parse(reader);
                                    hr.Salary = floatParser;
                                    hr.Position = Positions.HR;
                                    empls.Add(hr);
                                    break;
                                case Positions.LG:
                                    LG lg = new LG();
                                    Console.Write("First name: ");
                                    lg.Name = Console.ReadLine();
                                    Console.Write("Last name: ");
                                    lg.Surname = Console.ReadLine();
                                    Console.Write("Salary($): ");
                                    reader = Console.ReadLine();
                                    floatParser = float.Parse(reader);
                                    lg.Salary = floatParser;
                                    lg.Position = Positions.LG;
                                    empls.Add(lg);
                                    break;
                                case Positions.PM:
                                    PM pm = new PM();
                                    Console.Write("First name: ");
                                    pm.Name = Console.ReadLine();
                                    Console.Write("Last name: ");
                                    pm.Surname = Console.ReadLine();
                                    Console.Write("Salary($): ");
                                    reader = Console.ReadLine();
                                    floatParser = float.Parse(reader);
                                    pm.Salary = floatParser;
                                    pm.Position = Positions.PM;
                                    empls.Add(pm);
                                    break;
                                case Positions.QA:
                                    QA qa = new QA();
                                    Console.Write("First name: ");
                                    qa.Name = Console.ReadLine();
                                    Console.Write("Last name: ");
                                    qa.Surname = Console.ReadLine();
                                    Console.Write("Salary($): ");
                                    reader = Console.ReadLine();
                                    floatParser = float.Parse(reader);
                                    qa.Salary = floatParser;
                                    qa.Position = Positions.QA;
                                    empls.Add(qa);
                                    break;
                                case Positions.SE:
                                    SE se = new SE();
                                    Console.Write("First name: ");
                                    se.Name = Console.ReadLine();
                                    Console.Write("Last name: ");
                                    se.Surname = Console.ReadLine();
                                    Console.Write("Salary($): ");
                                    reader = Console.ReadLine();
                                    floatParser = float.Parse(reader);
                                    se.Salary = floatParser;
                                    se.Position = Positions.SE;
                                    empls.Add(se);
                                    break;
                            }
                        } while (intParser != 1 && intParser != 2 && intParser != 3 && intParser != 4 && intParser != 5);
                        break;
                    case 2:
                        Console.Clear();
                        string fName, lName;
                        int emplsNumberIni = empls.Count, emplsNumberFin = 0;
                        do
                        {
                            Console.WriteLine("Enter the full name of the employee: ");
                            Console.WriteLine("First name: ");
                            fName = Console.ReadLine();
                            Console.WriteLine("Last name: ");
                            lName = Console.ReadLine();
                            for (int i = 0; i < empls.Count; i++)
                            {
                                if (empls[i].Name.Equals(fName) && empls[i].Surname.Equals(lName))
                                {
                                    empls.Remove(empls[i]);
                                    Console.WriteLine("DELETED!");
                                }
                            }
                            emplsNumberFin = empls.Count;
                            if (emplsNumberIni == emplsNumberFin)
                            {
                                Console.WriteLine("ERROR! Employee not found...\nTry again?\n[1] - yes\n[any] - no");
                                reader = Console.ReadLine();
                            }
                        } while (reader == "1");
                        break;
                    case 3:
                        Console.Clear();
                        float avrgSalary = 0, sum = 0;
                        for (int i = 0; i < empls.Count; i++)
                        {
                            sum += empls[i].Salary;
                        }
                        avrgSalary = sum / empls.Count;
                        Console.WriteLine("Average Salary = {0}$", avrgSalary);
                        break;
                    default:
                        if (switcher != 1 && switcher != 2 && switcher != 3)
                        {
                            Console.WriteLine("ERROR! Re-enter your answer, please...");
                        }
                        break;
                }

                Console.WriteLine("Would you like to continue?");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("[1] - yes");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("[2] - no");
                do
                {
                    reader = Console.ReadLine();
                    switcher = int.Parse(reader);
                    switch (switcher)
                    {
                        case 1:
                            Console.Clear();
                            break;
                        case 2:
                            Console.Clear();
                            flag = true;
                            break;
                        default:
                            Console.Write("ERROR! Re-enter your answer, please: ");
                            break;
                    }
                } while (switcher != 1 && switcher != 2);
            }
            using (StreamWriter sw = new StreamWriter(path, false, System.Text.Encoding.Default))
            {
                for (int i = 0; i < empls.Count; i++)
                {
                    sw.WriteLine(empls[i].Name);
                    sw.WriteLine(empls[i].Surname);
                    sw.WriteLine(empls[i].Salary);
                    sw.WriteLine((int)empls[i].Position);
                }
            }
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Backed up to {0}", path);
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}