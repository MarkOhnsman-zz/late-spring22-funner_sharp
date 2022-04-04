using funner_sharp.models;

// SECTION Variables
// Explicit vs Implicit
// var x = 7; // Implicit Typing
// var myName = "Mark"; // Implicit Typing
// int x = 7; // Explicit Typing
// string y = "Hello"; // Explicit Typing


// SECTION Strings
//#region
// String vs Char
// string x = "Hello"; // string ""
// char y = 'R'; // char ''
// // Concat and Interpolation

// // string word = x + " " + y; // concat

// string word = $@"
//              ,\
//              \\\,_
//               \` ,\
//          __,.-'' =__)
//        .''        )
//     ,_/   ,    \/\_
//     \_|    )_-\ \_-`
//        `-----` `--`
// {x} {y}abbit

// "; // $ creates ability to interpolate; @ allows for linebreaks

// Console.WriteLine(word.ToUpper());
//#endregion

// SECTION Numbers
// int x = 8; // whole numbers
// float z = 3.44f; // smallest decimal type
// double y = 3.4;// standard decimal type
// decimal a = 4.23m;// largest decimal type
// Math: +, +=, -, *, 

// Boolean / Conditionals
// bool x = true;
// equality: ==, >=, <=, != 
// NO MORE TRUTH-Y FALSE-Y
// int x = 10;
// if (x > 10)
// {

// }
// else if (x == 10)
// {

// }
// else
// {

// }


// Fun with the console: 
// WriteLine vs Write


Console.ForegroundColor = ConsoleColor.Green;
Console.BackgroundColor = ConsoleColor.Black;
Console.Clear();// clears the console
Console.WriteLine("Hello There"); // ends with line break
// Console.Write("My ");
// Console.Write("Name ");
// Console.Write("Is ");
// Console.Write("Computer ");
// string greeting = "Do you Want to Play A Game? (y/n)";
// for (int i = 0; i < greeting.Length; i++)
// {
//   Console.Write(greeting[i]);
//   Thread.Sleep(50);
// }
// // string answer = Console.ReadLine().Trim().ToLower();
// char answer = Console.ReadKey().KeyChar;

// if (answer == 'y')
// {
//   System.Console.WriteLine("\nhere we go!");

// }

// Arrays (and how crappy they are)
// string[] jCats = new string[7];
// jCats[0] = "Dudley";
// jCats[1] = "Ironman";
// jCats[0] = null;

// List<string> jCats = new List<string>() { "Dudley" };
// jCats.Add("Gopher");
// jCats.AddRange(new string[2] { "Ironman", "Falcon" });
// jCats.FindAll(c => c.Contains('a'));


// string[] hCats = new string[2] { "moo", "jax" };
// List<string> hCats2 = hCats.ToList();

// for (int i = 0; i < hCats2.Count; i++)
// {
//   string name = hCats2[i];
//   Console.WriteLine(name);
// }


// Objects
// DO NOT USE OBJECT LITERALS (POCO's)
// var me = new // BAD!!!
// {
//   name: "Mark";
// };

Cat dudley = new Cat("Dudley", 1, "Orange");
// dudley.Name = "DUdley";
dudley.ChangeName("dudley");
dudley.Color = null;
// dudley.Name = "hehhehehehe";
System.Console.WriteLine(dudley.Name);

Dictionary<string, Cat> jCats = new Dictionary<string, Cat>(){
  {"ironman", new Cat("Ironman", 1, "Mix")},
  {"falcon", new Cat("Falcon", 2, "Black")},
  {"frankie", new Cat("Frankie", 3, "Black")},
  {"moo", new Cat("Moo", 8, "Black and White")}
};
jCats.Add("dudley", dudley);
jCats["moo"].Adoptable = false;
bool running = true;
while (running)
{
  if (jCats.Values.ToList().FindAll(c => c.Adoptable).Count == 0)
  {
    System.Console.WriteLine("all cats adopted.... Jeremy can sleep now");
    Thread.Sleep(1000);
    running = false;
    break;
  }
  // on load 
  // print the names and age of all adoptable cats
  Console.Clear();
  foreach (var item in jCats)
  {
    Cat cat = item.Value;
    if (cat.Adoptable)
    {
      Console.WriteLine($"Name: {cat.Name} | Age: {cat.Age}");
    }

  }

  // get user input of name of cat to adopt
  Console.Write("\n\nPlease enter the name of the cat to adopt: ");
  string input = Console.ReadLine().ToLower();

  // flip the bool adoptable of that cat
  if (jCats.ContainsKey(input) && jCats[input].Adoptable)
  {
    jCats[input].Adoptable = false;
    System.Console.WriteLine(@"
 _____      _               _   _ 
|  ___|    (_)             | | | |
| |__ _ __  _  ___  _   _  | | | |
|  __| '_ \| |/ _ \| | | | | | | |
| |__| | | | | (_) | |_| | |_| |_|
\____/_| |_| |\___/ \__, | (_) (_)
          _/ |       __/ |        
         |__/       |___/");
  }
  else
  {
    System.Console.WriteLine("No such cat");
  }
  Thread.Sleep(1500);
  // repeat


}



