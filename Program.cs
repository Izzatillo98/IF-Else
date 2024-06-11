using System;

string gameInput = Console.ReadLine();
Console.Write("Your age :");
int age = Convert.ToInt32(gameInput);
bool isCanPlay = age > 12 && age <40;

if(isCanPlay == true)
{
    Console.WriteLine("You have to try play this game");
}
