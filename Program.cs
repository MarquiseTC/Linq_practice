using System;
using System.Linq;
using System.Collections.Generic;


// Find the words in the collection that start with the letter 'L'
List<string> fruits = new List<string>() {"Lemon", "Apple", "Orange", "Lime", "Watermelon", "Loganberry"};

IEnumerable<string> LFruits = fruits.Where(fruit => fruit.StartsWith("L"));
foreach (string fruit in LFruits){
    Console.WriteLine($"{fruit}");
}
                            
// Which of the following numbers are multiples of 4 or 6
List<int> numbers = new List<int>()
{
    15, 8, 21, 24, 32, 13, 30, 12, 7, 54, 48, 4, 49, 96
};
// || is the or operator couldn't remember that. 
IEnumerable<int> fourSixMultiples = numbers.Where(number => number % 4 == 0 || number % 6 == 0 );
foreach (int number in fourSixMultiples){
    Console.WriteLine($"{number}");
}

// Order these student names alphabetically, in descending order (Z to A)
List<string> names = new List<string>()
{
    "Heather", "James", "Xavier", "Michelle", "Brian", "Nina",
    "Kathleen", "Sophia", "Amir", "Douglas", "Zarley", "Beatrice",
    "Theodora", "William", "Svetlana", "Charisse", "Yolanda",
    "Gregorio", "Jean-Paul", "Evangelina", "Viktor", "Jacqueline",
    "Francisco", "Tre"
};

List<string> descend = names.OrderByDescending(name => name).ToList();
foreach ( string name in descend){
    Console.WriteLine($"{name}");
}

// Build a collection of these numbers sorted in ascending order
List<int> numbs = new List<int>()
{
    15, 8, 21, 24, 32, 13, 30, 12, 7, 54, 48, 4, 49, 96
};

List<int> ascend = numbs.OrderBy(numb => numb).ToList();
foreach ( int numb in ascend){
    Console.WriteLine($"{numb}");
}

// Output how many numbers are in this list
List<int> numers = new List<int>()
{
    15, 8, 21, 24, 32, 13, 30, 12, 7, 54, 48, 4, 49, 96
};
// .Count is counting number of elements in List
Console.WriteLine(numers.Count());

// How much money have we made?
List<double> purchases = new List<double>()
{
    2340.29, 745.31, 21.76, 34.03, 4786.45, 879.45, 9442.85, 2454.63, 45.65
};
double total = purchases.Sum();
Console.WriteLine(Math.Round(total)); 
// Rounding here to get an even number

// What is our most expensive product?
List<double> prices = new List<double>()
{
    879.45, 9442.85, 2454.63, 45.65, 2340.29, 34.03, 4786.45, 745.31, 21.76
};
 double largest = prices.Max();
 Console.WriteLine("Our most expensive item is" + largest);