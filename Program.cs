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
Random numbers = new Random();
int leftHandOperand = numbers.Next(1, 101);
int rightHandOperand = numbers.Next(1,101);
int answer;
int newUserAnswer;
int userScore = 0;
int maxRounds = 5;
string? userAnswer;
string result;
bool gameRunning = true;
List<object[]> gameHistory = new List<object[]>();

  


while (gameRunning)
{
Menu();
}

//--Methods--

void Menu()
{ 
  Console.WriteLine("Choose an option:\n1) Addition Math Questions\n2) Subtraction Math Questions\n3) Multiplication Math Questions\n4) Division Math Questions\n5) Random Operator Math Questions\n6) Game History\n7) Exit");
  
  string? menuSelection = Console.ReadLine();
  
  if (menuSelection != null)
    {
      int.TryParse(menuSelection, out int choice);

    switch (choice)
  {
    case 1:
        Console.WriteLine("Addition Math Game:");
        for(int i = 0; i < maxRounds; i++){

          leftHandOperand = numbers.Next(1, 101);
          rightHandOperand = numbers.Next(1,101);

          answer = leftHandOperand + rightHandOperand;

          Console.WriteLine( $"{leftHandOperand} + {rightHandOperand} = ??" );

          userAnswer = Console.ReadLine();
          int.TryParse(userAnswer, out newUserAnswer);
          if (newUserAnswer == answer)
          {
            userScore += 1;
            Console.WriteLine($"Correct {leftHandOperand} + {rightHandOperand} = {answer}");
            result = "Win";
          }

          else 
          {Console.WriteLine($"Wrong. The Answer is {answer}");
            result = "Lose";
          }
          

          gameHistory.Add(new object[] { 
            $"{leftHandOperand} + {rightHandOperand}", 
            answer, 
            result });
        }

        Console.WriteLine($"Game Over\nYour Final score is: {userScore}/5");
         ReturnToMenu();
        userScore = 0;
        break;

    case 2:
        Console.WriteLine("Subtraction Math Game:");
        for(int i = 0; i < maxRounds; i++){

          leftHandOperand = numbers.Next(1, 101);
          rightHandOperand = numbers.Next(1,101);

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
            result = "Win";
          }

          else 
          {
            Console.WriteLine($"Wrong. The Answer is {answer}");
            result = "Lose";
          }

         
          gameHistory.Add(new object[] { 
            $"{leftHandOperand} - {rightHandOperand}", 
            answer, 
            result });
          }
            Console.WriteLine($"Game Over\nYour Final score is: {userScore}/5");
            userScore = 0;
            ReturnToMenu();
       
        break;

    case 3:
       
        for(int i = 0; i < maxRounds; i++)
        {
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
            result = "Win";
          }

          else {
            Console.WriteLine($"Wrong. The Answer is {answer}");
            result = "Lose";
          }
          gameHistory.Add(new object[] { 
            $"{multiplyLeftHandOperands} * {multiplyRightHandOperands}", 
            answer, 
            result });
          
         
        }
        
    
        Console.WriteLine($"Game Over\nYour Final score is: {userScore}/5");
        userScore = 0;
        break;

    case 4:
      
        for(int i = 0; i < maxRounds; i++)
      {
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
          result = "Win";
        }

        else {
          Console.WriteLine($"Wrong. The Answer is {answer}");
          result = "Lose";
        }
          
        gameHistory.Add(new object[] { 
            $"{dividend} / {divisor}", 
            answer, 
            result });
        
        }
          

        Console.WriteLine($"Game Over\nYour Final score is: {userScore}/5");
        userScore = 0;
        break;

    case 5:
      Console.Clear();
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
        GameRecords();
        ReturnToMenu();
        break;

    case 7:
        gameRunning = false;
        Console.WriteLine("Goodbye :)");
        
        break;

    default:
        Console.WriteLine("Enter a number option");
        ReturnToMenu();
        break;
    
    
  }
    }
}
void ReturnToMenu()
{ 
  Console.WriteLine("Press Enter to return to the Main Menu.");
  Console.ReadLine();
  Console.Clear();
  Console.Write("\x1b[3J");
  Console.Clear();
  Menu();
}





void PlayRound(string GameOption)
{


  switch(GameOption){

    case "addition" :
      

    break;

    case "subtraction" :
    


    break;

    case "multiplication" :
      

    break;

    case "division" :
    


    break;
  }
}

void GameRecords()
{ 
  Console.WriteLine("\n\tHistory Table:\n");
  Console.WriteLine("Problem\t\tAnswer\t\tResult");
  foreach (object[] game in gameHistory)
{
    Console.WriteLine($"{game[0]}\t\t{game[1]}\t\t{game[2]}");
}
Console.WriteLine();

}



