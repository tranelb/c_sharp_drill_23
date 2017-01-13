using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public enum Temperature
{
    Freeze,
    Low,
    Warm,
    Boil
}

struct Customers
{
    private string name;
    private double balance;
    private int id;

    public void createCust(string n, double b, int i)
    {
        name = n;
        balance = b;
        id = i;
    }

    public void showCust()
    {
        Console.WriteLine("Name : " + name);
        Console.WriteLine("Balance : " + balance);
        Console.WriteLine("ID : " + id);
    }
}


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
            Console.WriteLine("test_test_test");
            test testVarStr = new test();
            Console.WriteLine(testVarStr.getStuff("seven"));
            OverRideClass try1 = new OverRideClass();
            Console.WriteLine(try1.OverRideMethod("dassdafsdf"));
            OverRider try2 = new OverRider();
            Console.WriteLine(try2.OverRideMethod("tasefffdgsdf"));


            Temperature micTemp = Temperature.Low;

            Customers bob = new Customers();

            bob.createCust("Bob", 15.50, 12345);

            bob.showCust();

            int[] randArray = new int[5];

            //nullable type?
            int nullVar = randArray[4];
        }

            abstract class Shape
            {
                public abstract double area();

                // An abstract class can contain complete or default code for methods
                public void sayHi()
                {
                    Console.WriteLine("Hello");
                }
            }

            // A class can have many interfaces
            // An interface can't have concrete code
            public interface ShapeItem
            {
                double area();
            }

            class Rectangle : Shape
            {
                private double length;
                private double width;

                public Rectangle(double num1, double num2)
                {
                    length = num1;
                    width = num2;
                }

                public override double area()
                {
                    return length * width;
                }

                // You can redefine many built in operators so that you can define what happens when you 
                // add to Rectangles
                public static Rectangle operator +(Rectangle rect1, Rectangle rect2)
                {
                    double rectLength = rect1.length + rect2.length;
                    double rectWidth = rect1.width + rect2.width;

                    return new Rectangle(rectLength, rectWidth);

                }

            }

    }

}


