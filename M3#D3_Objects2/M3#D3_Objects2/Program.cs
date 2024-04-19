using System;

namespace C__Fundamentals.Day_3
{
    class Inheritance
    {
        class vehicle 
        {
            string brand = "Ford";
            public virtual void abc() //not what i want to run, but gives structure
            {
                Console.WriteLine("base class");
            }
        }

        abstract class Animal// objects cannot be created, the class must be inherited
        {
            public abstract void abc(); //autocompletes with semicolon, because it is marked as an abstract. Only given as a name to indicate, that in
            //inherited classes, a class with that name should exist -> gives structure, can only be in abstract classes

            public void xyz () //normal methods can be created as well :-) 
            {
                Console.WriteLine("not abstract");
            }


            //Fields cannot be abstract (variables)


            
        }

        class Car : vehicle // car inherites from vehicle
        {
             public string color = "red";

            //without the override, it is possible that the base class is run instead 
             public override void abc() //Polymorphism: Same method name than parent class but with different content, similar to overloading
            {
                Console.WriteLine("Derived Class");
            }

            // Animal a = new Animal(); not possible to create the object of an abstract class

        }

        class Ford : Car // muultilevel inheritance: vehicle -> car -> Ford
        {

        }

        class Scooter: vehicle //hierarchical inheritance: more classes inherit from one parent class
        {

        }

        class Bmw :  Car //hybrid inheritance: hybrid of multilevel and hierarchical inheritance
        {

        }

        class Dog : Animal //has to implement the abstract members of the abstract parent class
        {
            public override void abc()
            {
                Console.WriteLine("inherited grom abstract class animal");
            }
        }

        interface Animal1 //completely abstract class, only create abstract methods
        {
            void abc();
            void xyz();
        }

        class Pig: Animal1
        {
           public void abc()
            {
                Console.WriteLine("abc");
            }
           public void xyz()
            {
                Console.WriteLine("xyz");
            }
        }

        



        public static void Main(string[] args)
        {
            Car obj1 = new Car();
            obj1.abc(); // car obj inherites the method abc() from the parent class vehicle
            Console.WriteLine(obj1.color);

            Dog d1 = new Dog();
            d1.abc(); //the abstract method from the abstract is implemented in the child class
            d1.xyz(); //inherited from the parent class
        }
    }



}
