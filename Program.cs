// See https://aka.ms/new-console-template for more information
using System.Collections.ObjectModel;
using System.Globalization;
using System.Security.Authentication.ExtendedProtection;
using Arrays;


// Assignment 1: Read Only collections
List<string> colours = new List<string>{"red","green","blue"};
ReadOnlyCollection<string> readOnlyColours = new ReadOnlyCollection<string>(colours);
 
 //readOnlyColours.Add(): There is no add method on readOnlyColours attempting to add throws an error.
Console.WriteLine("Assisgnment 1");
foreach (string item in readOnlyColours)
{
    Console.WriteLine("Colours present:" + item);   
}

//Assignment 2:Resizing a List collection
List<int> randNumbers = new List<int>(capacity:100)
{
   1, 2, 3, 4, 5, 6, 7, 8, 9, 10 
};
var count = randNumbers.Count;
var randCapacity = randNumbers.Capacity;

Console.WriteLine("Assignment 2");
// foreach (int num in randNumbers)
// {
    //Console.WriteLine("Available Numbers:" + num);
    Console.WriteLine("List Count: " + count); 
    Console.WriteLine("List Capacity: " +randCapacity);
//}

//Assignment 3:Finding the maximum value in a list
// List<int> maxNumbers = new List<int>(capacity:10);
// for (int i = 0; i < 10; i++)
// {
//    maxNumbers.Add(i);
// }
// Console.WriteLine("The maximum number present is:" + maxNumbers.Max());
List<int> redoNumbers = new List<int>();
Random random = new Random();
for (int i = 0; i < 10; i++)
{
   redoNumbers.Add(random.Next(1,100)); 
}

int redoMax = redoNumbers.Max();
Console.WriteLine("Assignment 3");
Console.WriteLine("Random Number");
Console.WriteLine("Maximum value in the list: " + redoMax);


//Assignment 4: Merging Two Arrays
int[] number1 = [1,2,3];
int[] number2 = [3,4,5];

int[] merging = number1.Concat(number2).ToArray();

Console.WriteLine("Assignment 4");
foreach (int number in merging)
{
    Console.WriteLine(number);
}

//Assignment 5: List of Custom objects
var books = new List<Books>()
{
  new Books {Title = "Things Fall Apart", Author = "Chinua Achebe"},
  new Books {Title = "Animal Farm", Author = "George Orwell"},
  new Books {Title = "The lord of the Rings", Author = "J.R.R Tolkien"},
};
Console.WriteLine("Assignment 5");
foreach (var book in books)
{
    Console.WriteLine($"Title:{book.Title}, Author:{book.Author}");
}

//Assignment 6: Sorting and Reversing an Array
Console.WriteLine("Assignment 6");
int[] revNumbers = [3,1,4,1,5,9,2,6,5,3,5];
foreach (var item in revNumbers)
{
    Console.WriteLine("All numbers: " + item);
}

Array.Sort(revNumbers);
Console.WriteLine();
foreach (var item in revNumbers)
{
    Console.WriteLine("Sort Numbers: " + item);
}

Array.Reverse(revNumbers);
foreach (var item in revNumbers)
{
    Console.WriteLine("Reverse Numbers: " + item);
}

//Assignment 7: Create and Manipulate an Array
Console.WriteLine("Assignment 7");
 int[] maniArray = [10,20,30,40,50];
 Console.WriteLine("Lenght of ManiArray:" + maniArray.Length);

 Console.WriteLine("All arrays"); 
 for (int i = 0; i < maniArray.Length; i++)
 {
    Console.WriteLine(maniArray[i]);
 }


 maniArray[2] = 35;
 Console.WriteLine("Change the number");
 foreach (var item in maniArray)
 {
    Console.WriteLine(item);
 };
 //Assignment 8: Using the List methods
Console.WriteLine("Assignment 8");
 List<string> fruits = new List<string>{"apple","banana","cherry"};
 fruits.Add("date");
 fruits.Remove("banana");

 foreach (var item in fruits)
 {
    Console.WriteLine(item);
    
 }

 bool data = fruits.Any(x =>x.Contains("cherry"));
 Console.WriteLine(data);