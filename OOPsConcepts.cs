// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Text;
// using System.Threading.Tasks;

// namespace CSharpLearningCode
// {
    // class OOPsConcepts
    // {
    // }


    //                                  Inheritance in C# 
    //                                =======================


    // In C#, it is possible to inherit fields and methods from one class to another.
    // We group the "inheritance concept" into two categories:

    //    Derived Class(child) -    the class that inherits from another class
    //    Base Class(parent) -    the class being inherited from

    // To inherit from a class, use the : symbol.


    //class Vehicle  // base class (parent) 
    //{
    //    public string brand = "Ford";  // Vehicle field
    //    public void honk()             // Vehicle method 
    //    {
    //        Console.WriteLine("Tuut, tuut!");
    //    }
    //}

    //class Car : Vehicle  // derived class (child)
    //{
    //    public string modelName = "Mustang";  // Car field
    //}

    // Sealed Keyword :-
    //                If you try to access a sealed class, C# will generate an error.

    //sealed class Vehicle
    //{
    //   public string brand = "Ford";  // Vehicle field
    //    public void honk()             // Vehicle method 
    //    {
    //        Console.WriteLine("Tuut, tuut!");
    //    }
    //}

    //class Car : Vehicle                              // not allowed to inherit sealed class
    //{
    // public string modelName = "Mustang";  // Car field
    //}


    //                                   Polymophism in C#
    //                                 =====================


    // Polymorphism means "many forms", and it occurs when we have many classes that are related to each other
    // by inheritance.

    // Polymorphism uses those methods to perform different tasks.This allows us to perform a single action in
    // different ways.

    // The base class method overrides the derived class method, when they share the same name.


    //class Animal  // Base class (parent) 
    //{
    //    public void animalSound()
    //    {
    //        Console.WriteLine("The animal makes a sound");
    //    }
    //}

    //class Snake : Animal  // Derived class (child) 
    //{
    //    public void animalSound()
    //    {
    //        Console.WriteLine("The Snake says: fhisss fhisss...");
    //    }
    //}

    //class Tiger : Animal  // Derived class (child) 
    //{
    //    public void animalSound()
    //    {
    //        Console.WriteLine("The Tiger says: khhhhaaaao khhhhhaaaaao...");
    //    }
    //}

    //C# provides an option to override the base class method,
    //by adding the virtual keyword to the method inside the base class,
    //and by using the override keyword for each derived class methods.

    //class Animal
    //{
    //    public virtual void animalSound()
    //    {
    //        Console.WriteLine("Animals make a Sound");
    //    } 
    //}
    //class Tiger : Animal
    //{
    //    public override void animalSound()
    //    {
    //        Console.WriteLine("The Tiger says : khhhhaaaao  khhhhhaaaaao...");
    //    }
    //}
    //class Snake : Animal
    //{
    //    public override void animalSound()
    //    {
    //        Console.WriteLine("The Snake says : fhissss fhissss...");
    //    }
    //}


    //                             Abstraction in C#
    //                           =====================


    // Data abstraction is the process of hiding certain details and showing only essential information
    // to the user.
    // Abstraction can be achieved with either abstract classes or interfaces

    // The abstract keyword is used for classes and methods:

    // Abstract class: is a restricted class that cannot be used to create objects(to access it,
    // it must be inherited from another class).

    // Abstract method: can only be used in an abstract class, and it does not have a body.
    // The body is provided by the derived class (inherited from).


    // Abstract class

    //abstract class Animal
    //{
    //    // Abstract method (does not have a body)
    //    public abstract void animalSound();

    //    // Regular method
    //    public void sleep()
    //    {
    //        Console.WriteLine("Tiger is Sleeping : voice like - Zzz...");
    //    }
    //}
    //// Derived class (inherit from Animal)
    //class Tiger : Animal
    //{
    //    public override void animalSound()
    //    {
    //        Console.WriteLine("The Tiger says : khhhhaaaao  khhhhhaaaaao...");
    //    }
    //}


    //                                   Interface in C#
    //                                 ===================


    // Another way to achieve abstraction in C#, is with interfaces.

    // An interface is a completely "abstract class", which can only contain abstract methods
    // and properties(with empty bodies).

    // It is considered good practice to start with the letter "I" at the beginning of an interface,
    // as it makes it easier for yourself and others to remember that it is an interface and not a class.

    // By default, members of an interface are abstract and public.

    // To access the interface methods, the interface must be "implemented" (kinda like inherited) by
    // another class. To implement an interface, use the : symbol(just like with inheritance). The body of
    // the interface method is provided by the "implement" class. Note that you do not have to use the
    // override keyword when implementing an interface.

    // Note:- Interfaces can contain properties and methods, but not fields/variables.

    // Like abstract classes, interfaces cannot be used to create objects(in the example above,
    // it is not possible to create an "IAnimal" object in the Program class).

    // Interface methods do not have a body - the body is provided by the "implement" class.

    // On implementation of an interface, you must override all of its methods.

    // An interface cannot contain a constructor (as it cannot be used to create objects).

    //interface IAnimal
    //{
    //    void animalSound(); // interface method (does not have a body)
    //}

    //// Snake "implements" the IAnimal interface
    //class Snake : IAnimal
    //{
    //    public void animalSound()
    //    {
    //        // The body of animalSound() is provided here
    //        Console.WriteLine("The Snake says: fhisss fhisss....");
    //    }
    //}


    //                                     Multiple Interfaces 
    //                                  =========================


    // C# does not support "multiple inheritance" (a class can only inherit from one base class).
    // However, it can be achieved with interfaces, because the class can implement multiple interfaces.
    // Note: To implement multiple interfaces, separate them with a comma.

    //interface IFirstInterface
    //{
    //    void myFIMethod(); // interface method
    //}

    //interface ISecondInterface
    //{
    //    void mySIMethod(); // interface method
    //}

    //// Implement multiple interfaces
    //class DemoClass : IFirstInterface, ISecondInterface
    //{
    //    public void myFIMethod()
    //    {
    //        Console.WriteLine("I am First Interface Methods...");
    //    }
    //    public void mySIMethod()
    //    {
    //        Console.WriteLine("I am Second Interface Methods...");
    //    }
    //}
// }
