using System;

namespace student;

class Program
{
    static void Main(string[] args)
    {
        Student s = new Student();
        Student s2 = new Student();
        Student s3 = new Student();
        Group g = new Group();

        g.AddStudent(s);
        g.AddStudent(s2);
        g.AddStudent(s3);

        s.AddExam(12);
        s2.AddExam(6);
        s3.AddExam(7);

        g.ExpelBadStudent();
        g.ShowGroup();
        Group copy = new Group();
        
        g.ShowGroup();
        g.TransferStudent(s, copy);
        g.ShowGroup();
        copy.ShowGroup();
    }
}

