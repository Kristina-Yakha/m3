using System;

class Car

   {
    //string color = "red"; //class members
    /*static public */ string color = "yellow"; //if the variable is static then the value is shared among all the objects of this class - if it is changes for one, it is changed for all.

    int yearOfMaking;//declaration: without assigned value
    
    Car(string color)
    {
        this.color = color; // constructor (global, class-level) variable = parameter, does not work when global scope variable is static
    }

    Car(int yearOfMaking) //constructor, used for initialization, can have or have no parameters
        //if no constructor is declared, it will still use the default constructor to initialize instance variables(objects)
    {
        //yearOfMaking = 1998; //variable is defined - declaring on the outside and defining on the inside of a constructor
        Console.WriteLine(yearOfMaking);
     }

    //void: return type of the method -> no/ void return type
    public void printColor() //class member
    {
        Console.WriteLine(color);
    }

    public static void Main(string[] args)
    {
        Car BMW = new Car(1997); //Creating an object results in automatically running the constructor, also calling the methods
        //Console.WriteLine(BMW.color);
        BMW.color = "yellow"; //if variable is not defined: no error, but variable is not printed with printColor
        //BMW.printColor("iX");
        //You can create as many objects as you like
        Car audi = new Car("red");
        audi.printColor();
    }
}
