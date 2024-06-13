//string userInput = Console.ReadLine();
//int age = Convert.ToInt32(userInput);
//bool isArmyAge = age is > 17 and < 27;
//string message = isArmyAge
    //? "You should go to army!"
   // : "You cannot go to army!";
// Console.WriteLine(message);

string username = Console.ReadLine();
switch(username)
{
    case "Kopaytiramiz":
        int firstNumber = 15;
        int secondNumber = 25;

        int Kopaytiramiz = firstNumber * secondNumber;
        Console.WriteLine("Natija = " + Kopaytiramiz);
        break;

    case "Bolish":
        decimal first = 30;
        decimal second = 20;

        decimal javob = first / second;
        Console.WriteLine("yechim = " + javob);
       
        break;

    default:    
        Console.WriteLine("Natija = 0");
        break;     
}

//string usersname = Console.ReadLine();
//if (usersname == "Elbek")
//{
  //  Console.WriteLine("Teacher is here");
//}
//else if (usersname == "Izzatillo")
//{
 //   Console.WriteLine("I am here");
//}
//else
//{
 //   Console.WriteLine("None is here");
//}

//using System;
// if -> tenary operator
// switch -> pattern matching
//string username = Console.ReadLine();
//string message = username switch
//{
    //"Elbek" => "Teacher is here",
    //"Izzatillo" => "I am here",
  //  _ => "Noone is here"
//};
//Console.WriteLine(message);