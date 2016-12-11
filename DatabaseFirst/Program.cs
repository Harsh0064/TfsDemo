using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            using(var ctx=new SchoolContext())
            {
                var standard = ctx.Standards;
                //var standardList = from student in ctx.Students where student.StudentID == 10 select student;
                var standardList = ctx.Students.Where(x => x.StudentID == 10);
                foreach (var item in standard)
                {
                    if (item.Students != null)
                    {
                        foreach (var studItem in item.Students)
                        {
                            Console.WriteLine(studItem.StudentName);
                        }
                    }

                }
            }
        }
    }
}
