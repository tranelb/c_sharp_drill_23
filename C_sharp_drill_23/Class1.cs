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
            public void getStuff(int id)
            {
                return id;
            }
            public void getStuff(string name)
            {
                return name;
            }
        }


        public class OverRideClass
        {
            public virtual void OverRideMethod(string var)
            {
                return "Default text from virtual void";
            }

        }

        public class OverRider: OverRideClass
        {
            public override void OverRideMethod(string var)
            {
                return var + "Override text from override void";
            }

        }

        static void Main()
        {
            test testVar = new test(7);
            Console.WriteLine(testVar);
            test testVarStr = new test("seven");
            Console.WriteLine(testVarStr);
            OverRideClass try1 = new OverRideClass();
            Console.WriteLine(try1.OverRideMethod("dassdafsdf"));
            OverRider try2 = new OverRider();
            Console.WriteLine(try2.OverRideMethod("tasefffdgsdf"));

        }

    }
}

