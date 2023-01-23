// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// string friend = "Po";
// Console.WriteLine(friend);
// Console.WriteLine("Hello " + friend);
// Console.WriteLine($"Hello {friend}");

// friend = "Jo";
// Console.WriteLine("Hey there " + friend);

// string firstFriend = "Po";
// string secondFriend = "Joe";
// Console.WriteLine($"My friends are {firstFriend} and {secondFriend}");

// Console.WriteLine($"The name {firstFriend} has {firstFriend.Length} letters");
// Console.WriteLine($"The name {secondFriend} has {secondFriend.Length} letters");

// string greeting = "        Howdy!       ";
// Console.WriteLine($"[{greeting}]");

// string trimGreeting = greeting.TrimStart();
// Console.WriteLine($"[{trimGreeting}]");

// trimGreeting = greeting.TrimEnd();
// Console.WriteLine($"[{trimGreeting}]");

// trimGreeting = greeting.Trim();
// Console.WriteLine($"[{trimGreeting}]");

// string sayHello = "Hello World";
// Console.WriteLine(sayHello );
// sayHello = sayHello.Replace("Hello", "Greetings");
// Console.WriteLine(sayHello);
// Console.WriteLine(sayHello.ToUpper());
// Console.WriteLine(sayHello.ToLower());

// string phrase = "What the dog do";
// Console.WriteLine(phrase.Contains("dog"));
// Console.WriteLine(phrase.Contains("cat"));

// phrase = "What time is it?";
// Console.WriteLine(phrase.StartsWith("What"));
// Console.WriteLine(phrase.StartsWith("When"));

// Console.WriteLine(phrase.EndsWith("ur nan"));
// Console.WriteLine(phrase.EndsWith("it"));

//NUMBERS!!!

// int a = 21;
// int b = 282;
// int c = 32;
// int c = b - a;
// int d = (a + b) * c;
// int d = (a + b) - 6 * c + (12 * 4) / 3 + 12;
// int d = (a + b) / c;
// int d = (a + b) / c;
// int e = (a + b) % c;
// Console.WriteLine(c);
// Console.WriteLine($"quotient: {d}");
// Console.WriteLine($"remainder: {e}");
// Console.WriteLine(d);

// int max = int.MaxValue;
// int min = int.MinValue;
// Console.WriteLine($"The range of integers is {min} to {max}");

// int what = max + 100;
// Console.WriteLine($"An example of overflow: {what}");

// double a = 19;
// double b = 23;
// double c = 8;
// double d = (a + b) / c;
// Console.WriteLine(d);


// double max = double.MaxValue;
// double min = double.MinValue;
// Console.WriteLine($"The range of double is {min} to {max}");

// double third = 1.0 / 3.0;
// Console.WriteLine(third);

// decimal min = decimal.MinValue;
// decimal max = decimal.MaxValue;
// Console.WriteLine($"The range of the decimal type is {min} to {max}");

//LOOPS!!!

// int a = 15;
// int b = 26;
// if (a + b < 50)
//     Console.WriteLine("The answer is greater than 10.");

// int a = 5;
// int b = 3;
// if (a + b > 10)
// {
//     Console.WriteLine("The answer is greater than 10");
// }
// else
// {
//     Console.WriteLine("The answer is not greater than 10");
// }

// int a = 5;
// int b = 5;
// int c = 4;
// if ((a + b + c > 10) && (a == b))
// {
//     Console.WriteLine("The answer is greater than 10");
//     Console.WriteLine("And the first number is equal to the second");
// }
// else
// {
//     Console.WriteLine("The answer is not greater than 10");
//     Console.WriteLine("Or the first number is not equal to the second");
// }


// int counter = 0;
// while (counter < 11)
// {
//   Console.WriteLine($"Hello World! The counter is {counter}");
//   counter++;
// }

// int counter = 0;
// do
// {
//   Console.WriteLine($"Hello World! The counter is {counter}");s
//   counter++;
// } while (counter < 10);

// for(int counter = 0; counter < 10; counter++)
// {
//   Console.WriteLine($"Hello World! The counter is {counter}");
// }

// for (int row = 1; row < 11; row++)
// {
//   Console.WriteLine($"The row is {row}");
// }

// for (char column = 'a'; column < 'z'; column++)
// {
//   Console.WriteLine($"The column is {column}");
// }

// for (int row = 1; row < 11; row++)
// {
//   for (char column = 'a'; column < 'k'; column++)
//   {
//     Console.WriteLine($"The cell is ({row}, {column})");
//   }
// }

// int sum = 0;
// for (int number = 1; number < 21; number++)
// {
//     if (number % 3==0)
//     {
//         sum = sum + number;
//     }
// }
// Console.WriteLine($"The sum is {sum}");


//LISTS!!!!

var names = new List<string> { "Rahul", "Ana", "Felipe" };
foreach (var name in names)
{
  Console.WriteLine($"Hello {name.ToLower()}!");
}

Console.WriteLine();
names.Add("Maria");
names.Add("Bill");
names.Remove("Ana");
foreach (var name in names)
{
  Console.WriteLine($"Hello {name.ToUpper()}!");
}

//RB End Program Convention
Console.WriteLine("===Program Finished.Press any key to exit====");
Console.ReadKey();