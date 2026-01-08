/* Math Game Requirements
- You need to create a game that consists of asking the player what's the result of a math question
 (i.e. 9 x 9 = ?), collecting the input and adding a point in case of a correct answer.

- A game needs to have at least 5 questions.

-The divisions should result on INTEGERS ONLY and dividends should go from 0 to 100. Example: Your app shouldn't present the division 7/2 to the user, 
 since it doesn't result in an integer.

- Users should be presented with a menu to choose an operation.

- You should record previous games in a List and there should be an option in the 
  menu for the user to visualize a history of previous games.

- You don't need to record results on a database. 
  Once the program is closed the results will be deleted.*/

Console.WriteLine("Choose an option:\n1) Addition Math Questions\n2) Subtraction Math Questions\n3) Multiplication Math Questions\n4) Division Math Questions\n5) Game History\n6) Exit\n");
Menu();

//--Methods--

void Menu()
{ string? menuSelection = Console.ReadLine();
  
  if (menuSelection != null)
    {
      int.TryParse(menuSelection, out int choice);

    switch (choice)
  {
    case 1:
        Console.WriteLine("Option 1 will be here - for addition");
        break;

    case 2:
        Console.WriteLine("Option 2 will be here - for subtraction");
        break;

    case 3:
        Console.WriteLine("Option 3 will be here - for multiplication");
        break;

    case 4:
        Console.WriteLine("Option 4 will be here - for Division");
        break;

    case 5:
        Console.WriteLine("Option 5 will be here - Game History");
        break;

    case 6:
        Console.WriteLine("Goodbye :)");
        break;

    default:
        Console.WriteLine("Enter a number option");
        Menu();
        break;
    
    
  }
    }
}

//void GameRecord(){}

// void PlayGame(){}

// void PlayRound(){}
