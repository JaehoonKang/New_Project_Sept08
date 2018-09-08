# New_Project_Sept08
# C# Learning & Mini Project 09072018 

## C# Basic Concept

- Importance of C#: IoT, Web, Game, App, Cloud, Network

<br>

### *Definition*: A strong, multi-paradigm Programming Language developed by MS within its .NET initiative & a general-purpose, object-oriented programming language.

ex) `Window Form`, `ASP.NET`, `ADO.NET`

<br>

### C# vs .NET

#### C#: a Programming language 
<br>
#### .NET: a Framework for building applications on Windows  

<br>
<br>

### Background

* Namespace: a collection of classes 


* Assembly: a container of related Namespaces 


<br>
<br>

#### 1. *Class Library*   2. *CLR (Common Language Runtime)*

<br>

##### Class: a container of `Data (Attribute)` and  `Methods (Function)`

<br>
### 1. Class Library

<br>

#### BCL (Basic Class Library): Basic Class

#### Window Form: Class Library for Window Application

#### ASP.NET: Web Class Library

<br>

### 2. CLR (Common Language Runtime)

- Role:  `to run a compiled C# code`

- IL(Intermediate Language)

<br>

### Summary

- Based in `C++` + `Java` => strongly `C`

- *No* usage of `Pointer`

- *No* need to delete a object -> `new` keyword, `Garbage Collector` (Managing useless memory)

- **Flow**: 1. `C# source file` -> 2. `C# Compiler` [Visual Studio] -> 3. `IL (Intermediate Language)` [.exe or .dll], CLR  -> 4. Machine Code (Native Code) / `.NET Framework` -> 5. OS

<br>

- Recap: I become a `.NET programmer!` I should understand `the process from Compiling to Running a program` 

- C# -> OS related Language.  


<br>

### C# Fundamentals

- **Variable**: a name given to a storage location in the memory 
- **Constant**: an immutable value

<br>

## *Primitive Types*


### Integer Numbers

### Real Numbers: float / double / decimal 

### Character

### Boolean 

<br>

## *Non Primitive Types*

- String / Array / Enum / Class

```c#
using System;

namespace FirstDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            byte number = 2;
            int count = 10;
            float totalPrice = 20.95f;
            char character = 'A';
            string firstName = "Mosh";
            bool isWorking = true;

            Console.WriteLine(number);
            Console.WriteLine(count);
            Console.WriteLine(totalPrice);
            Console.WriteLine(character);
            Console.WriteLine(firstName);
            Console.WriteLine(isWorking);
        }
    }
}
```

<br>

### **Overflowing**

```c#
byte number = 255;

number  = number + 1 ; //0, overflowed

vs

checked
    {
        byte number = 255;

        number = number + 1;
    }
```

##### Demo1
```c#
            try
            {
                var number = "1234";
                byte b = Convert.ToByte(number);
                Console.WriteLine(b);
            }
            catch (Exception)
            {
                Console.WriteLine("There is an error");
            }
```

<br>

### Class

- `public class` keyword

- Code example

```c#
using System;

namespace FirstDemo
{
    public class Person
    {
        public string FirstName;
        public string LastName;

        public void  Introduce()
        {
            Console.WriteLine("My Name is " + FirstName + " " + LastName);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var john = new Person();
            john.FirstName = "John";
            john.LastName = "Smith";
            john.Introduce();

        }
    }
}
```
#### Structs

#### Arrays

`int[] numbers = new int [3];`
`var numbers = new int [4];`
`var names = new string[3] {"Jack", "John", "Mary"};`

#### String

`var myFullName = string.Format("My Name is {0} {1}", firstName, lastName);`

<br>

```c#
var names = new string[3] { "John", "Mary", "Jack" };
            var formattedNames = string.Join(",", names);
            Console.WriteLine(formattedNames);
```

<br>

#### Enum: A set of name/value pairs (constants)

- Instead of saving or creating each constant, with `Enum`, we can easily create a collection of constants and use it

```c#
public enum ShippingMethod
{
    RegularAirMail = 1,
    RegisterAirMail= 2,
    Express = 3;
}

var method = ShippingMethod.Express;
```

#### Reference Types and Value Types

- Types: 1. Structures[Value types] (Primitive) 2. Classes[Reference types] (Arrays, String)

##### Value types

- Allocated on stack
- Memory Allocation done automatically 
- Immediately removed out of scope

#### Reference types

- I need to allocate memory myself
- Memory allocated on heap


##### Value type example

```c#
    var a = 10;
    var b = a;
    b++; //still value of a is not changed, a=10, a is an integer[value type]
    Console.WriteLine(string.Format("a: {0}, b: {1}", a,b)); //a =10, b =11
```

##### Reference type example

- stack and heap affects the value I want to change


```c#
    var array1 = new int[3] {1,2,3};
    var array2 = array1;
    array2[0] = 0; //array2[0] is changed!! 

    Console.WriteLine(string.Format("array1[0]:{0}, array2[0]:{1}", array1[0], array2[0]));
```
- Below, array1 and array2 points to the same value inside `heap`


