# JSON in C# for Beginners
Simple console application to create and manipulate JSON Objects in C#

Hello! 

This is a simple Console Application, to cover creation and manipulation of JavaScript Object Notation, and it's use in C#,
through a NuGet Package called:

```Newtonsoft.JSON```, recommended by the book ```"Exam Ref 70-483 - Programming in C#"``` 

### Installing
```PM> Install-Package Newtonsoft.Json```

If you are not used to installing NuGet Packages, [click here](https://docs.microsoft.com/en-us/nuget/quickstart/install-and-use-a-package-using-the-dotnet-cli) - Install and use NuGet Packages




The program consists in storing animal's information using a .NET Class and JSON syntax. 

## You will be asked to type in:
* How many animals you want to store as JSON
* What is the animal's name
* Where does this animal lives
* What does it like to eat

As many times as you chose in the first question.

## The main methods are:

```JsonConvert.SerializeObject()``` to transform an object or List<T> into a simple string.
and
```JsonConvert.DeserializeObject<List<T>>()``` to transform a JSON string back into a .NET object. 


Please feel free to comment.
