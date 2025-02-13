﻿using System;
namespace student
{
	class Group
	{
		List<Student> students;
		string groupName;
		string groupSpecialization;
		int coursNumber;

		public Group()
		{
			students = new List<Student>();
			SetGroupName("P26");
			SetGroupSpecialization("pr");
			SetCoursNumber(1);
		}

		public Group(Group group)
		{
			students = new List<Student>(group.students);

			groupName = group.groupName;
			groupSpecialization = group.groupSpecialization;
			coursNumber = group.coursNumber;
		}

		public void SetGroupName(string groupName)
		{
			this.groupName = groupName;
		}

		public void SetGroupSpecialization(string groupSpecialization)
		{
			this.groupSpecialization = groupSpecialization;
		}

		public void SetCoursNumber(int coursNumber)
		{
			this.coursNumber = coursNumber;
		}

		public string GetGroupName()
		{
			return groupName;
		}

		public string GetGroupSpecialization()
		{
			return groupSpecialization;
		}

		public int GetCoursNumber()
		{
			return coursNumber;
		}

		public void ShowGroup()
		{
			Console.WriteLine(GetGroupName());
			Console.WriteLine(GetGroupSpecialization());
			foreach(var student in students)
			{
				Console.WriteLine(student.GetSurname() + " " + student.GetName());
			}
		}

		public void AddStudent(Student student)
		{
			students.Add(student);
		}

        public void EditGroup(string newName, string newSpecialization, int newCoursNumber)
		{
			SetGroupName(newName);
			SetGroupSpecialization(newSpecialization);
			SetCoursNumber(newCoursNumber);
		}

		public void TransferStudent(Student student, Group group)
		{
			group.AddStudent(student);
			ExpelStudent(student);
		}

		public void ExpelStudent(Student student)
		{
			students.Remove(student);
		}

		public void ExpelFailedStudents()
		{
            students.RemoveAll(NotPassedSession);
        }

        private bool NotPassedSession(Student student)
        {
            return !student.PassSession();
        }

		public void ExpelBadStudent()
		{
			Student expel = null;
			double minAvg = 12;
			foreach(var student in students)
			{
				if(student.CalculateAvg() < minAvg)
				{
					minAvg = student.CalculateAvg();
					expel = student;
				}
			}
			ExpelStudent(expel);
		}
    }
}

