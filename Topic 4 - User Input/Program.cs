// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
//string userName;

//Console.WriteLine("Enter username: ");
//userName = Console.ReadLine();

//Console.WriteLine("Your username is: " + userName);
//Console.ReadLine();

//int age;
//Console.WriteLine("Enter your age: ");
//age = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine(Int32.TryParse(Console.ReadLine(), out age));
//Console.WriteLine("Your age is: " + age);
//Console.ReadLine();

double price;
Console.WriteLine("What is the price?");
Double.TryParse(Console.ReadLine(), out price);
Console.WriteLine("The price is " + price.ToString("C"));