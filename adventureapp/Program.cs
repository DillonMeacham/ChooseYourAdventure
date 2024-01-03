﻿using System;

namespace ChooseYourOwnAdventure
{
  class Program
  {
      static void Main(string[] args)
    {
      /* THE MYSTERIOUS NOISES */

      // Start by asking for the user's name:
      Console.Write("What is your name?: ");
      string name = Console.ReadLine();
      Console.WriteLine($"Hello, {name}! Welcome to our story.");

      //start of story
      Console.Write("It begins on a cold rainy night. You're sitting in your room and hear a noise coming from down the hall. Do you go investigate?");

      Console.Write("Type YES or NO: ");
      string noiseChoice = Console.ReadLine().ToUpper();

      if (noiseChoice == "NO")
      {
        Console.WriteLine("Not much of an adventure if we don't leave our room!");

        Console.WriteLine("THE END.");
      }

      else if (noiseChoice == "YES")
      {
        Console.WriteLine("You walk into the hallway and see a light coming from under a door down the hall.");
      }

      Console.Write("Type OPEN or KNOCK: ");
      string doorChoice = Console.ReadLine().ToUpper();

      if (doorChoice == "KNOCK")
      {
       Console.WriteLine("A voice behind the door speaks. It says, \"Answer this riddle:\"");

       Console.WriteLine("\"Poor people have it. Rich people need it. If you eat it you die. What is it?\"");
      
      Console.WriteLine("Type your answer: ");
      string riddleAnswer = Console.ReadLine().ToUpper();

      if (riddleAnswer == "NOTHING")
      {
        Console.WriteLine("The door opens and NOTHING is there.You turn off the light and run back to your room and lock the door.THE END.");
      }

      else {
        Console.WriteLine("You answered incorrectly. The door doesn't open. THE END");
      }
      }

      else if (doorChoice == "OPEN")
      {
        Console.WriteLine("The door is locked! See if one of your three keys will open it.");

        Console.Write("Enter a number (1-3): ");
        string keyChoice = Console.ReadLine().ToUpper();

        switch (keyChoice)
        {
          case "1":
          Console.WriteLine("You choose the first key. Lucky choice! The door opens and NOTHING is there. Strange... THE END.");
          break;

          case "2":
          Console.WriteLine("You choos the second key. The door doesn't open. THE END.");
          break;
//test
          case "3":
          Console.WriteLine("You choose the third key. The door doesn't open. THE END.");
          break;
        }
      }

     
    }
  }
}



