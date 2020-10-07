# Lesson 01 - CSharp

CSharp is a programming language from Microsoft. used in .NET framework. 

* strongly typed. (not always)
* OOP - object oriented programming language. 

## Used for:
* backend side. 
* applications (desktop, mobile)
* command line programs. 
* games

### value types:
value typed variables are stored in the program memory directly. 

* byte - 1 byte in memory. 0 to 255. only for positive numbers
```cs
byte b = 1;
```
* sbyte - 1 byte in memory. -127 to 128. 
```cs
sbyte b = 1;
```
* int (integer) - 4 byte in memory. 
```cs
int x = 1;
```
* uint (integer) - 4 byte in memory. only for positive numbers
```cs
uint x = 1;
```
* long - 8 byte in memory. 
```cs
long l = 1;
```
* ulong - 8 byte in memory. only for positive numbers
```cs
ulong l = 1;
```
* float - 4 byte in memory. 
```cs
float f = 1.576f;
```
* double - 8 byte in memory. 
```cs
double d = 1.5476;
```
* decimal - 16 byte in memory. in use for money calculations. 
```cs
decimal d = 1.587597m;
```

* char - 2 byte in memory
```cs
char ch = 'g';
```
* boolean - true / false. 
```cs
bool b = true;
```

### reference types: 
are stored in the `heap`, and the address of the first element is stored in the program memory (stack). 

* string 
```cs
string str = "hello";
```
* array
* class 

## String interpolation:
reads the value inside variables, in a string
```cs
string user = "Tom";
string str = $"hello {user}";
```

## Console.ReadLine()
reads a line to a variable from the console. 
> note: always comes as a string. 
```cs
string name = Console.ReadLine();
```

## varName.GetType()
return the type of the variable. 
```cs
int x = 4;
x.GetType(); // int32
```

## Convert()
Convert() - will convert types.
* in this example: ask the user for input, and convert to int32 in the same line: 
> note: in case of converting real string to number - no error will be displayed. only in run time the program will stop. 
```cs
int n2 = Convert.ToInt32(Console.ReadLine());
```
