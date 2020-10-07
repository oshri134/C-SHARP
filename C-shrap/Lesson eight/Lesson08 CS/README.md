# Lesson 08

## readonly

readonly - is a keyword, cannot be assigned to.

- in regular variable: can be assigned to only in constructor, or initialization line.
- in static variable: can be assigned to only in static constructor, or initialization line.

```cs
public readonly int NumOfRooms = 4;
public static readonly string Country = "Israel";
```

## Override - דריסה

```cs
class A{}
class B:A{}
```

- instance of `A a1 = new A()` - gets only the data of A class.
- instance of `B b1 = new B()` - gets all the data of A + B class.

> if attribute has the same name in the child class -

    * A a1 = new B() - get only the data from A class
    * B b1 = new B() - get only the data from B class

## Sealed method - מתודה חתומה

- sealed is a keyword in CS.
- Sealed method can be used to block override of subclasses.

```cs
public sealed override void x()
{
    Console.WriteLine("Try B");
}
```

## Overloading - העמסה

Overloading allows us to create more than 1 function with the same name, in the same class.

- the access - each function will have diffrent parameters.
  - diffrent number of parameters
  - type of parameters

> note: we already saw it in constructors - we can create as many as we want, as long the paramters type and amount is diffrent.

```cs
class A
{
    public int X;
    public int y;

    public A(){} // empty ctor.


    public A(int x)
    {
        X = x;
    }

    public A(int x, string y)
    {
        X = x;
        Y = y;
    }
}
```

## new

**new** keyword does not change anything, but removes the green flag. (it is warning from the system, to make sure the programmer knows what he is doing)

- new - used with inheritance.

## generic - כללי

Generic allows us to avoid code repetition.

- Generic allows a function to get any type of parameters.
- T and S are default parameters(can be anything).
- **where** - where keyword gives the parameters shrinked options:

```cs
class A{}
class B:A{}

// T - must be object of class A or subclasses of A (here: B)
static void func<T>(T x) where T : A
{
    Console.WriteLine($"x = {x}");
}
```
