using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppTest
{

    public interface IGrowable
    {
        void Grow();
    }

    public struct PersonStruct
    {
        public string name;
    }

    public abstract class Person
    {
        public string name;
        protected int a;
        protected int age;
        private double c;
        internal float f;

        public virtual void Walk()
        {
            a++;
        }

        public abstract void WalkAbs();

        public virtual string Description { get; set; }

        public int Age
        {
            get
            {
                return age;
            }

            set
            {
                if (value < 0)
                    throw new ArgumentException("Incorrect Value");
                age = value;
            }
        }

        public string GetHello()
        {
            return "Hello";
        }

        public void Swap(ref int a,ref int b)
        {
            //a = a + b;
            //b = a - b;
            //a = a - b;
            int temp = a;
            a = b;
            b = temp;
        }
    }


    public class Person2 : Person, IGrowable
    {
        public void Grow()
        {
            
        }

        public override void WalkAbs()
        {
            
        }
    }
}
