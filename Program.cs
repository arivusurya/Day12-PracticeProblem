using System;
using System.Collections.Generic;
using System.Linq;

namespace Lambda_Practice {
    public class Program{
        public static void Main(string[] args)
        {
            List<Student> listofstudent = new List<Student>(); 
            AddRecord(listofstudent);
            // DisplayStudent(listofstudent);
            // StudentListBetween18_12(listofstudent);
            // SortByTotalMarks(listofstudent);
            // Addressrecord(listofstudent,"salem");
            // FirstThreeRecord(listofstudent);
            SearchByName("Ares",listofstudent);
        }

        public static void AddRecord(List<Student> listofstudent){
            listofstudent.Add(new Student(1, "John", "11111111111","delhi",15,455));
            listofstudent.Add(new Student(2, "Ares", "2222222222","olympus",22,233));
            listofstudent.Add(new Student(3, "Surya", "33333333333","salem",22,444));
            listofstudent.Add(new Student(4, "Prem", "444444444444","pondy",23,555));
            listofstudent.Add(new Student(5, "Jaga","55555555555", "attur",25,666));
            listofstudent.Add(new Student(6, "Praveen", "66666666666","hosur",22,777));
            listofstudent.Add(new Student(7, "Huxley", "77777777777","bangalore",21,888));
            listofstudent.Add(new Student(8, "Deeps","88888888888", "salem",20,999));
        }

        public static void DisplayStudent(List<Student> listofstudent){
            foreach(Student student in listofstudent){
                Console.WriteLine("Student_id: {0} ", student.Id);
                Console.WriteLine("Name: {0} ", student.Name);
                Console.WriteLine("Phone: {0}", student.Phone_Number);
                Console.WriteLine("Address: {0}", student.Address);
                Console.WriteLine("Age: {0}", student.Age);
                Console.WriteLine("----------------------------------------------------------------");


            }
        }
        public static void StudentListBetween18_12(List<Student> students){
            var records = students.Where(x=> x.Age > 12 && x.Age<18);
            foreach(var record in records){
                Console.WriteLine("Student Id " + record.Id);
                Console.WriteLine("Student Name " + record.Name);
                Console.WriteLine("Student Phone " + record.Id);
                Console.WriteLine("Student Address " + record.Id);
                Console.WriteLine("Student Age " + record.Id);

            }
        }
        public static void SortByTotalMarks(List<Student> listofStudent){
            var sortedlists = listofStudent.OrderByDescending(x => x.TotalMark);
            foreach(var sortedlist in sortedlists){
                Console.WriteLine("Id : " + sortedlist.Id);
                Console.WriteLine("Name : " + sortedlist.Name);
                Console.WriteLine("Phone : " + sortedlist.Phone_Number);
                Console.WriteLine("Address : " + sortedlist.Address);
                Console.WriteLine("Age : " + sortedlist.Age);
                Console.WriteLine("Total Marks : " + sortedlist.TotalMark);
                Console.WriteLine("----------------------------------------------------------------");
            }
        }

        public static void Addressrecord(List<Student> listofStudent , string address){
            var studentlist = listofStudent.Where(x => x.Address == address);
            foreach(var student in studentlist){
                Console.WriteLine("Name: " + student.Name);
                Console.WriteLine("Phone: " + student.Phone_Number);
                Console.WriteLine("Address: " + student.Address);
                Console.WriteLine("Age: " + student.Age);
                Console.WriteLine("Total : " + student.TotalMark);
                Console.WriteLine("----------------------------------------------------------------");
            }
        }

        public static void FirstThreeRecord(List<Student> listofStudent){
            var listofstudents = listofStudent.Where(x => x.Id <=3 );
            foreach(var student in listofstudents){
                Console.WriteLine("Name " + student.Name );
                Console.WriteLine("Phone " + student.Phone_Number );
                Console.WriteLine("Address " + student.Address );
                Console.WriteLine("Age " + student.Age );
                Console.WriteLine("Total " + student.TotalMark );
                Console.WriteLine(" ----------------------------------------------------------------");

            }
        }
        public static void SearchByName(string name,List<Student> listOfstudents){
            Student student = listOfstudents.FirstOrDefault(s => s.Name == name);
            if(student == null)
            {
                Console.WriteLine("No student found on name: " + name);
            }else{
            Console.WriteLine("Student  Name : " + student.Name);
            Console.WriteLine("Student  Phone : " + student.Phone_Number);
            Console.WriteLine("Student Address : " + student.Address);
            Console.WriteLine("Student Age : " + student.Age);
            Console.WriteLine("Student TotalMark : " + student.TotalMark);
            }
        }

    }
}