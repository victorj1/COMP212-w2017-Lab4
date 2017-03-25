using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Victor_Jdanovitch_Lab04_Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            var students = new[]
{
                new Student(" 1", " J Hardy"),
                new Student(" 2", " B Bowen"),
                new Student(" 3", " C Watson"),
                new Student(" 4", " A Swan"),
                new Student(" 5", " G Greg")
            };

            var studentList = new LinkedList<Student>();
            //Add Students to Student LinkedList
            studentList = AddLinkedListItem(students, studentList);
            PrintLinkedList(studentList);
            Console.WriteLine();

            //Search Student by Id in Student LinkedList
            SearchLinkedListItem(studentList, students);
            Console.WriteLine();

            //Remove a Student from Student LinkedList
            studentList = RemoveLinkedListItem(studentList, students);
            Console.WriteLine();
            PrintLinkedList(studentList);

            //Remove all Students from Student LinkedList
            studentList = RemoveAllLinkedListItems(studentList);
            Console.WriteLine();
            PrintLinkedList(studentList);
        }

        private static LinkedList<Student> AddLinkedListItem(Student[] students, LinkedList<Student> list)
        {
            foreach (var item in students)
            {
                list.AddLast(item);
            }
            return list;
        }

        private static void PrintLinkedList(LinkedList<Student> studentList)
        {
            Console.WriteLine("\n Print Student List: ");
            foreach (var item in studentList)
            {
                Console.WriteLine(item.ToString());
            }
        }

        private static LinkedList<Student> RemoveLinkedListItem(LinkedList<Student> studentList, Student[] students)
        {
            Console.WriteLine("\n Removed Third Student from the list");
            studentList.Remove(students[7]);
            return studentList;
        }

        private static LinkedList<Student> RemoveAllLinkedListItems(LinkedList<Student> studentList)
        {
            Console.WriteLine("\n Removed all Students from the list \n");
            studentList.Clear();
            return studentList;
        }

        private static void SearchLinkedListItem(LinkedList<Student> studentList, Student[] students)
        {
            Console.WriteLine("\n Contains: Student with Id = 1: {0}",
                studentList.Contains(students[1]));

        }
    }

}
