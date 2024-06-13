//string userInput = Console.ReadLine();
//int age = Convert.ToInt32(userInput);
//bool isArmyAge = age is > 17 and < 27;
//string message = isArmyAge
    //? "You should go to army!"
   // : "You cannot go to army!";
// Console.WriteLine(message);

//string username = Console.ReadLine();
//switch(username)
//{
  //  case "Elbek":
    //    Console.WriteLine("Teacher is here");
      //  break;
    //case "Izzatillo":
      //  Console.WriteLine("I am here");
        //break;
    //default:    
     //   Console.WriteLine("Noone is here");
       // break;     
//}

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

using System;
// if -> tenary operator
// switch -> pattern matching
string username = Console.ReadLine();
string message = username switch
{
    "Elbek" => "Teacher is here",
    "Izzatillo" => "I am here",
    _ => "Noone is here"
};
Console.WriteLine(message);