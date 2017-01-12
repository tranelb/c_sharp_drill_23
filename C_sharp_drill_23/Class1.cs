using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp_drill_23
{
    class Class1
    {

        //Overloading is when you have multiple methods in the same scope, with the same name but different signatures.
        public class test
        {
            public int getStuff(int id)
            {
                return id;
            }
            public string getStuff(string name)
            {
                return name;
            }
        }


        public class OverRideClass
        {
            public virtual string OverRideMethod(string var)
            {
                return "Default text from virtual void";
            }

        }

        public class OverRider: OverRideClass
        {
            public override string OverRideMethod(string var)
            {
                return "Override text from override void";
            }

        }

        static void Main()
        {
            test testVar = new test();
            Console.WriteLine(testVar.getStuff(7));
            test testVarStr = new test();
            Console.WriteLine(testVarStr.getStuff("seven"));
            OverRideClass try1 = new OverRideClass();
            Console.WriteLine(try1.OverRideMethod("dassdafsdf"));
            OverRider try2 = new OverRider();
            Console.WriteLine(try2.OverRideMethod("tasefffdgsdf"));

        }

    }
}

