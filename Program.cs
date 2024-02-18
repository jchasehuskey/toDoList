
// using System.Xml.XPath;


using Microsoft.VisualBasic;


var todos = new List<string>();

Console.WriteLine("Hello");

bool shallExit = false;
while (!shallExit)
{
    Console.WriteLine("What do you want to do? ");
    Console.WriteLine("[S]ee all TODOs");
    Console.WriteLine("[A]dd a TODO");
    Console.WriteLine("[R]emove a TODO!");
    Console.WriteLine("[E]xit");
    var userChoice = Console.ReadLine()?.ToLower();

    switch (userChoice)
    {
        case "e":
            shallExit = true;
            break;
        case "s":
            System.Console.WriteLine("See all TODOs");
            break;
        case "a":
            AddTodo();
            break;
        case "r":
            System.Console.WriteLine("Remove a TODO");
            break;
        default:
            System.Console.WriteLine("Invalid Choice");
            break;
    }
}

Console.ReadKey();

void AddTodo()
{

    bool isValidDescription = false;
    while (!isValidDescription)
    {
        System.Console.WriteLine("enter todo description");
        var description = Console.ReadLine();

        if (description == "" || description == " ")
        {
            System.Console.WriteLine("description cannot be empty");
        }
        else if (todos.Contains(description))
        {
            System.Console.WriteLine("The description must be different than a current ToDo");
        }
        else
        {
            isValidDescription = true;
            todos.Add(description);
        }
    }

}

// var userChoice = Console.ReadLine()?.ToLower();
// var listOfToDos = new List<string>();

// switch (userChoice)
// {
//     case "s":
//         PrintSelectedOption("See all TODOs");
//         PrintListofToDos(listOfToDos);
//         break;
//     case "a":
//         PrintSelectedOption("Add a TODO");
//         AddToList(addedTodo);
//         break;
//     case "r":
//         PrintSelectedOption("Remove a TODOs");
//         break;
//     case "e":
//         PrintSelectedOption("Exit");
//         break;
//     default:
//         System.Console.WriteLine("Invalid choice");
//         break;
// }

// void PrintSelectedOption(string selectedOption)
// {
//     System.Console.WriteLine($"Selected option: {selectedOption}");
// }

// void PrintListofToDos(List<string> listOfToDos)
// {

//     if (listOfToDos.Count == 0)
//     {
//         System.Console.WriteLine("no ToDos found");
//     }
//     else
//     System.Console.WriteLine($"here is your list of ToDos");
// }

// var AddToList(string todo)
// {
//     var listItem = Console.ReadLine();
//     foreach (var list in listOfToDos){

//         if (!list == addedTodo)
//         {

//         }
//     }
// }

//WHILE LOOP -------------------------------------------------------------------------------------------------------
// var number = 0;
// while (number < 10)
// {
//     // number = ++number;
//     // number += 2;
//     ++number;
//     System.Console.WriteLine($"Number is: {number}");
// }
// System.Console.WriteLine("The loop is finished");

// System.Console.WriteLine("enter a word");
// var userInput = Console.ReadLine();

// while (userInput.Length < 15)
// {
//     userInput += 'a';
//     //userInput = userInput + 'a';
//     System.Console.WriteLine(userInput);
// }

// System.Console.WriteLine("the loop is finished");



//DO WHILE LOOP -------------------------------------------------------------------------------------------------------

// string word;
// do
// {
//     System.Console.WriteLine("write a word that is longer than 10 letters");
//     word = Console.ReadLine();
// }
// while (word.Length <= 10);



//ForLOOP -------------------------------------------------------------------------------------------------------

// for (int i = 10; i > 5; i--)
// {
//     System.Console.WriteLine($"Loop run {i}");
// }

// System.Console.WriteLine("The loop is finished");

//BREAK
// for (var i = 0; i < 100; i++)
// {
//     System.Console.WriteLine($"i is {i}");
//     if (i > 25)
//     {
//         break;
//     }
// }


// int userNumber;
// do
// {
//     System.Console.WriteLine("enter number larger than 10 ");
//     var userInput = Console.ReadLine();
//     if (userInput == "stop")
//     {
//         break;
//     }

//     bool isParasableToInt = userInput.All(char.IsDigit);

//     if (!isParasableToInt)
//     {
//         userNumber = 0;
//         continue;
//     }
//     userNumber = int.Parse(userInput);
// }
// while (userNumber <= 10);


// System.Console.WriteLine("The loop is finished");

// for (int i = 0; i < 20; i++)
// {
//     if (i % 3 == 0)
//     {
//         continue;
//     }
//     System.Console.WriteLine($"{i}");

// }

// System.Console.WriteLine("The loop is finished");]

//nested LOOP -------------------------------------------------------------------------------------------------------
// for (int i = 0; i < 4; i++)
// {
//     for (int j = 0; j < 3; j++)
//     {
//         for (int k = 0; k < 5; k++)
//         {
//             System.Console.WriteLine($"i is {i}, j is {j}, k is {k}");
//         }

//     }
// }


// System.Console.WriteLine("The loop is finished");







//Array-------------------------------------------------------------------------------------------------------

// int[] numbers = new int[5];
// int[] testArray = {1,2,3};
// var numbers = new[] { 2, 3, 1, 6, 19 };
// System.Console.WriteLine($"Element at index 0 is {numbers[0]}");
// System.Console.WriteLine($"Element at index 0 is {numbers[1]}");
// System.Console.WriteLine($"Element at index 0 is {numbers[2]}");

// numbers[0] = 5;
// numbers[1] = 6;
// numbers[2] = 7;
// numbers[3] = 17;
// numbers[4] = 22;

// //INDEX FRO END OPERATOR
// // var firstFromEnd = numbers[numbers.Length - 1];
// var firstFromEnd = numbers[^1];
// // var secondFromEnd = numbers[numbers.Length - 2];
// var secondFromEnd = numbers[^2];
// System.Console.WriteLine($"firstfromend: {firstFromEnd}, second from end: {secondFromEnd}");


// System.Console.WriteLine();
// System.Console.WriteLine($"Element at index 0 is {numbers[0]}");
// System.Console.WriteLine($"Element at index 0 is {numbers[1]}");
// System.Console.WriteLine($"Element at index 0 is {numbers[2]}");

// var last = numbers[2];
// System.Console.WriteLine(last);

// int[] numbers = { 2, 6, 1, 6, 19 };

// var sum = 0;
// for (var i = 0; i < numbers.Length; i++)
// {
//     sum += numbers[i];
// }

// System.Console.WriteLine(sum);


//Multidimensional Array-------------------------------------------------------------------------------------------------------


// char[,] letters = new char[2, 3];

// letters[0, 0] = 'A';
// letters[0, 1] = 'B';
// letters[0, 2] = 'C';
// letters[1, 0] = 'D';
// letters[1, 1] = 'E';
// letters[1, 2] = 'F';

// var height = letters.GetLength(0);
// var width = letters.GetLength(1);
// System.Console.WriteLine($"height is {height}");
// System.Console.WriteLine($"width is {width}");

// for (var i = 0; i < height; i++)
// {
//     System.Console.WriteLine($"i is {i}");
//     for (var j = 0; j < width; j++)
//     {
//         System.Console.WriteLine($"j is {j}");
//         System.Console.WriteLine($"element is {letters[i, j]}");
//     }
// }


// var letters2 = new char[,]
// {
//     {'A', 'B', 'C'},
//     {'D', 'E', 'F'}
// };


//forEach Loop-------------------------------------------------------------------------------------------------------

// var words = new[] { "one", "two", "three", "four" };

// for (var i = 0; i < words.Length; i++)
// {
//     System.Console.WriteLine(words[i]);
// }


// foreach (var word in words)
// {
//     System.Console.WriteLine(word);
// }








//LISTS-------------------------------------------------------------------------------------------------------


// List<string> words = new List<string>();
// var words = new List<string>
// {
//     "one",
//     "two"
// };

// var moreWords = new[] { "three", "four", "five" };
// words.AddRange(moreWords);


// words.AddRange(new[] { "three", "four", "five" });

// System.Console.WriteLine(words.IndexOf("one"));

// //bool
// System.Console.WriteLine(words.Contains("four"));

// //clear removes all elements in a list

// words[0] = "unosdos";
// words[1] = "tresQuatros";
// words.Add("treslegues");

// words.RemoveAt(1);

// System.Console.WriteLine($"count of elements is {words.Count}");



// words.Add("hello");
// System.Console.WriteLine($"count of elements is {words.Count}");

// foreach (var word in words)
// {
//     System.Console.WriteLine(word);
// }


// words.Remove("tresQuatros");

// foreach (var word in words)
// {
//     System.Console.WriteLine(word);
// }

// for (var i = 0; i < words.Count; i++)
// {
//     System.Console.WriteLine(words[i]);
// }



//OUT KEYWORD-------------------------------------------------------------------------------------------------------

// var numbers = new[] { 10, -8, 2, 12, -17 };
// int nonPositiveCount;
// var onlyPositive = GetOnlyPositive(numbers, out nonPositiveCount);
// foreach (var positiveNumber in onlyPositive)
// {
//     System.Console.WriteLine(positiveNumber);
// }

// System.Console.WriteLine($"non positive number is: {nonPositiveCount}");

// List<int> GetOnlyPositive(int[] numbers, out int countOfNonPositive)
// {
//     countOfNonPositive = 0;
//     var result = new List<int>();
//     foreach (int number in numbers)
//     {
//         if (number > 0)
//         {
//             result.Add(number);
//         }
//         else
//         {
//             countOfNonPositive++;
//         }
//     }
//     return result;
// }



// TRY PARSE METHOD ///////////////////////////////////////////////////////////

// var userNumber = int.Parse(userInput);

// bool isParsingSucces;

// do
// {
//     System.Console.WriteLine("enter a number");
//     var userInput = Console.ReadLine();
//     isParsingSucces = int.TryParse(userInput, out int number);

//     if (isParsingSucces)
//     {
//         System.Console.WriteLine($"parsing worked, number is:{number} ");
//     }
//     else
//     {
//         System.Console.WriteLine($"parsing was not succesful, you typed {userInput}");
//     }
// } while (!isParsingSucces);




Console.ReadKey();



















// System.Console.WriteLine("start your engines and sleect a number");
// var points = Console.ReadLine();


// char ConvertPointsToGrade(int points)
// {
//     switch (points)
//     {
//         case 10:
//         case 9:
//             return 'A';
//         case 8:
//         case 7:
//         case 6:
//             return 'B';
//         case 5:
//         case 4:
//         case 3:
//             return 'C';
//         case 2:
//         case 1:
//             return 'D';
//         case 0:
//             return 'F';
//         default:
//             return '!';
//     }
// }

















// if (userChoice == "S")
// {
//     PrintSelectedOption("See all TODOs");
// }

// else if (userChoice == "A")
// {
//     PrintSelectedOption("Add a TODO");
// }
// else if (userChoice == "R")
// {
//     PrintSelectedOption("Remove TODO");
// }
// else if (userChoice == "E")
// {
//     PrintSelectedOption("Exit");
// }
// else
// {
//     System.Console.WriteLine("Invalid choice");
// }






// bool isLong = IsLong(userChoice);

// if (userChoice != null)
// {
//     string result = isItTrueOrFalse(userChoice, isLong);
//     System.Console.WriteLine(result);
// }
// else
// {
//     System.Console.WriteLine("no input detected");
// }










// bool IsLong(string input)
// {
//     return input?.Length > 10;
// }



// System.Console.WriteLine(isLong);


// string isItTrueOrFalse(string userChoice, bool isLong)
// {
//     if (isLong)
//     {
//         return $"this is true because the word is {userChoice}";
//     }
//     else
//     {
//         return $"this is wrong because the word is {userChoice}";
//     }
// }


// string isItTrueOrFalse (string userChoice)
// {
// if(isLong == true)
// {
//     return System.Console.WriteLine($"this is true because the word was {userChoice}");
// }
// else {
//         return System.Console.WriteLine($"this is false because the word was {userChoice}");
//     }

// }




// bool IsLong(string input)
// {
//     if (input.Length > 10)
//     {
//         return true;
//     }
//     return false;
// }





































// notes




// if (userChoice?.Length == 0)
// {
//     System.Console.WriteLine("Empty choice");
//     int number = 5;
// }
// else
// {
//     int number = 10;
//     System.Console.WriteLine("Non-emty choice {0}: ", userChoice);
// }
// System.Console.WriteLine("your choice is: " + userChoice);
// // System.Console.WriteLine(number);



// // string? userChoice = Console.ReadLine();

// // if (userChoice.Length <= 3)
// // {
// //     System.Console.WriteLine("Short answer");
// // }
// // else if (userChoice.Length < 10)
// // {
// //     System.Console.WriteLine("medium answer");
// // }
// // else
// // {
// //     System.Console.WriteLine("Long answer");
// // }









// if (userChoice == "ABC")
// {
//     System.Console.WriteLine("User typed {0}", userChoice);
// }
// else
// {
//     System.Console.WriteLine("user did not type ABC, user typed: {0}", userChoice);
// }

// bool isUserInputAbc = userChoice?.Equals("ABC", StringComparison.OrdinalIgnoreCase) ?? false;
// // var someOtherBoolean = false;
// System.Console.WriteLine(isUserInputAbc);

// // var is10Modulo3EqualTo1 = 10 % 3 == 1;
// // var isEven = 10 % 2 == 0;

// var newNumber = 10;
// var isLargerThan4AndSmallerThan9 = newNumber > 4 && newNumber < 9;

// System.Console.WriteLine("islargerThan4smallerthan9 {0}", isLargerThan4AndSmallerThan9);


// var isEqualTo2orLargerThan6 = newNumber == 2 || newNumber > 6;
// Console.WriteLine("is it equal to 20 or larger than 6? Number: {0} , boolean: {1}", newNumber,
// isEqualTo2orLargerThan6);

// var Crazyisit = newNumber == 12 || (newNumber % 2 == 0 && newNumber < 20);

// //short-circuiting (put more lightweight operatoins on left hand side to conduct first. Sometimes, the ones on the right might not even be evaluated)
// var isLargerThan5OrSmallerThan = newNumber > 5 || newNumber < 0;
// var isSmallerThan0AndEven = newNumber < 0 && newNumber % 2 == 0;


// // userChoice = "ABC";

// if (userChoice != null)
// {
//     System.Console.WriteLine("You entered: " + userChoice);
// }
// else
// {
//     System.Console.WriteLine("You entered a null value");
// }

// Console.ReadKey();
// // if (Environment.UserInteractive)
// // {
// //     Console.ReadKey(); 
// // }


