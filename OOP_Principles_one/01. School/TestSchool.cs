﻿//We are given a school. In the school there are classes of students. Each class has a set of teachers. 
//Each teacher teaches a set of disciplines. Students have name and unique class number. 
//Classes have unique text identifier. Teachers have name. Disciplines have name, number of lectures 
//and number of exercises. Both teachers and students are people. Students, classes, teachers and disciplines
//could have optional comments (free text block). Your task is to identify the classes (in terms of  OOP) 
//and their attributes and operations, encapsulate their fields, define the class hierarchy 
//and create a class diagram with Visual Studio.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


class SchoolTest
{
    static void Main()
    {
        Student marko = new Student("Marko Ivanov", "015");
        Student petkan = new Student("Petkan Ivanov", "91");
        Student dragan = new Student("Dragan Ivanov", "015");
        List<Student> students = new List<Student>(){marko, petkan, dragan};

        Discipline biology = new Discipline("Biology", 12, 12);
        Discipline chemistry = new Discipline("Chemistry", 15, 12);
        Discipline math = new Discipline("Math", 150, 100);
        List<Discipline> disciplines=new List<Discipline>(){biology, chemistry,math};

        Teacher petkov = new Teacher("Georgi Dimitrov", disciplines);
        List<Teacher> teachers = new List<Teacher>() { petkov };

        ClassOfStudents classA = new ClassOfStudents("11A", teachers, students);

        Console.WriteLine("The teacher of {0} of {1} is {2}", disciplines[0].Name, 
            classA.ClassIdentifier,teachers[0].Name);
    }
}

