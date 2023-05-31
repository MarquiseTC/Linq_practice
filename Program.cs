// Find the words in the collection that start with the letter 'L'
List<string> fruits = new List<string>() {"Lemon", "Apple", "Orange", "Lime", "Watermelon", "Loganberry"};

IEnumerable<string> LFruits = fruits.Where(fruit => fruit.StartsWith("L"));
foreach (string fruit in LFruits){
    Console.WriteLine($"{fruit}");
}
                            

