using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace AppTest
{
    internal class Program
    {
        

        static void Main(string[] args)
        {
            using (UniversityContext context = new UniversityContext())
            {
                context.Database.EnsureCreated();
                Group gr = new Group();
                gr.Name = "M21-502";
                gr.Students = new List<Student>();
                gr.Students.Add(new Student()
                {
                    Name ="Andrey",
                    Group = gr,
                    Course =1
                });
                gr.Students.Add(new Student()
                {
                    Name = "Egor",
                    Group = gr,
                    Course = 1
                });
                gr.Students.Add(new Student()
                {
                    Name = "Maxim",
                    Group = gr,
                    Course = 1
                });
                gr.Students.Add(new Student()
                {
                    Name = "Артем",
                    Group = gr,
                    Course = 1
                });
                gr.Students.Add(new Student()
                {
                    Name = "Дана",
                    Group = gr,
                    Course = 1
                });
                context.Groups.Add(gr);
                context.SaveChanges();
            }
            

        }
    }
}
