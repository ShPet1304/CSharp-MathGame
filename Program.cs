/* --Math Game Requirements--
1) You need to create a game that consists of asking the player what's the result of a math question
 (i.e. 9 x 9 = ?), collecting the input and adding a point in case of a correct answer. - Done

2) A game needs to have at least 5 questions. - Done

3) The divisions should result on INTEGERS ONLY and dividends should go from 0 to 100. Example: Your app shouldn't present the division 7/2 to the user, 
 since it doesn't result in an integer. - Done

4) Users should be presented with a menu to choose an operation. - Done

5) You should record previous games in a List and there should be an option in the 
  menu for the user to visualize a history of previous games.

6) You don't need to record results on a database. 
  Once the program is closed the results will be deleted.*/


/*  -- Extra Credit Challenges --
1) Try to implement levels of difficulty.
2) Add a timer to track how long the user takes to finish the game.
3) Create a Random Game option where the players will be presented with questions from random operations. - Done
*/

// **Global Variables**
int userScore = 0;
int maxRounds = 5;


Console.WriteLine("Choose an option:\n1) Addition Math Questions\n2) Subtraction Math Questions\n3) Multiplication Math Questions\n4) Division Math Questions\n5) Random Operator Math Questions\n6) Game History\n7) Exit");
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
        Console.WriteLine("Addition Math Game:");
        for(int i = 0; i < maxRounds; i++){
          PlayRound("addition");
        }
        Console.WriteLine($"Game Over\nYour Final score is: {userScore}/5");
        userScore = 0;
        break;

    case 2:
        Console.WriteLine("Subtraction Math Game:");
        for(int i = 0; i < maxRounds; i++){
          PlayRound("subtraction");
        }
        Console.WriteLine($"Game Over\nYour Final score is: {userScore}/5");
        userScore = 0;
        break;

    case 3:
        for(int i = 0; i < maxRounds; i++){
          PlayRound("multiplication");
        }
        Console.WriteLine($"Game Over\nYour Final score is: {userScore}/5");
        userScore = 0;
        break;

    case 4:
        for(int i = 0; i < maxRounds; i++){
          PlayRound("division");
        }
        Console.WriteLine($"Game Over\nYour Final score is: {userScore}/5");
        userScore = 0;
        break;

    case 5:
        Random option = new Random();
       Console.WriteLine("Random Operator Math Game:");
        for(int i = 0; i < maxRounds; i++){
          int randomOperation = option.Next(1,5);
          switch (randomOperation)
          {
            case 1:
                PlayRound("addition");
                break;
            case 2:
                PlayRound("subtraction");
                break;
            case 3:
                PlayRound("multiplication");
                break;
            case 4:
                PlayRound("division");
                break;

          }         
        }
        Console.WriteLine($"Game Over\nYour Final score is: {userScore}/5");
        userScore = 0;
        break;

    case 6:
        Console.WriteLine("Option 6 will be here - Game History");
        break;

    case 7:
        Console.WriteLine("Goodbye :)");
        break;

    default:
        Console.WriteLine("Enter a number option");
        Menu();
        break;
    
    
  }
    }
}
void PlayRound(string GameOption)
{
  Random numbers = new Random();
  int leftHandOperand = numbers.Next(1, 101);
  int rightHandOperand = numbers.Next(1,101);
  int answer;
  string? userAnswer;
  int newUserAnswer;

  switch(GameOption){

    case "addition" :
      answer = leftHandOperand + rightHandOperand;
      Console.WriteLine( $"{leftHandOperand} + {rightHandOperand} = ??" );
      userAnswer = Console.ReadLine();
      int.TryParse(userAnswer, out newUserAnswer);
      if (newUserAnswer == answer)
      {
        userScore += 1;
        Console.WriteLine($"Correct {leftHandOperand} + {rightHandOperand} = {answer}");
      }

      else Console.WriteLine($"Wrong. The Answer is {answer}");

    break;

    case "subtraction" :
    if (rightHandOperand > leftHandOperand)
    {
      (leftHandOperand, rightHandOperand) = (rightHandOperand, leftHandOperand);
    }
      answer = leftHandOperand - rightHandOperand;
      Console.WriteLine( $"{leftHandOperand} - {rightHandOperand} = ??" );
      userAnswer = Console.ReadLine();
      int.TryParse(userAnswer, out newUserAnswer);
      if (newUserAnswer == answer)
      {
        userScore += 1;
        Console.WriteLine($"Correct {leftHandOperand} - {rightHandOperand} = {answer}");
      }

      else Console.WriteLine($"Wrong. The Answer is {answer}");


    break;

    case "multiplication" :
      int multiplyLeftHandOperands = numbers.Next(1, 101);
      int multiplyRightHandOperands = numbers.Next(1, 101);
      answer = multiplyLeftHandOperands * multiplyRightHandOperands;
      Console.WriteLine( $"{multiplyLeftHandOperands} * {multiplyRightHandOperands} = ??" );
      userAnswer = Console.ReadLine();
      int.TryParse(userAnswer, out newUserAnswer);
      if (newUserAnswer == answer)
      {
        userScore += 1;
        Console.WriteLine($"Correct {multiplyLeftHandOperands} * {multiplyRightHandOperands} = {answer}");
      }

      else Console.WriteLine($"Wrong. The Answer is {answer}");

    break;

    case "division" :
    int dividend;
    int divisor; 
    
    
    do{
    dividend = numbers.Next(1, 101);
    divisor = numbers.Next(1, 101);
    
    } while(dividend % divisor != 0 || dividend < divisor);
    
     answer = dividend / divisor;
    
      Console.WriteLine( $"{dividend} / {divisor} = ??" );
      userAnswer = Console.ReadLine();
      int.TryParse(userAnswer, out newUserAnswer);
      if (newUserAnswer == answer)
      {
        userScore += 1;
        Console.WriteLine($"Correct {dividend} / {divisor} = {answer}");
      }

      else Console.WriteLine($"Wrong. The Answer is {answer}");


    break;
  }
}

//void GameRecord(){}

// void PlayGame(){}


