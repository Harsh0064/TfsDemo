using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameWorkApp
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var ctx = new SchoolContext())
            {
                //Student stud = new Student() { StudentName = "New Student" };

                //ctx.Students.Add(stud);
                //ctx.SaveChanges();
                //var student = ctx.Students;
                //var studentFirst = ctx.Students.First();
                //ctx.Students.Remove(studentFirst);
                //ctx.SaveChanges();
                //foreach (var stud in student)
                //{
                //    Console.WriteLine(stud.StudentName);
                //}
                Standard stan = new Standard() {StandardName="abc",StandardId=12 };
                ctx.Standards.Add(stan);
                ctx.Students.Add(new Student() { StudentName = "khan", Standard = stan });
                ctx.SaveChanges();

                var standard = ctx.Standards;
                foreach(var item in standard)
                {
                    if (item.Students != null)
                    {
                        foreach (var studItem in item.Students)
                        {
                            Console.WriteLine(studItem.StudentName);
                        }
                    }
                    
                }
                Console.WriteLine("");
            }
        }
    }
}
