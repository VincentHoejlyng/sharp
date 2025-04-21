using System;
Console.WriteLine ("Hvad hedder du?");
string variableTest = Console.ReadLine();
Console.WriteLine ("Hvor gammel er du?");

int myInt = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Du hedder" + variableTest + "og er" + myInt + "år gammel");

Console.WriteLine("Indtast et tal som repræsenterer X");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Indtast et tal som repræsenterer Y");
int y = Convert.ToInt32(Console.ReadLine());

if (x > y)
{
    Console.WriteLine("X er større end Y");
}
else {
    Console.WriteLine("Y er større end X");
}

string[] cars = {"Volvo", "BMW", "Ford", "Mazda"};
Array.Sort(cars);
foreach (string i in cars)
{
  Console.WriteLine(i);
}