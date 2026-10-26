/*
* Name: Grayson Wininger
* Course: CSCI 1250, Section 001
* Assignment: Lab 06, Three Short Problems
* Date: October 21, 2026
* Description: A menu that keeps running until the user quits, offering three
* independent exercises or all three at once. Each exercise
* practices decisions and one of the four loops.
*/

//to create random numbers 
Random rng = new Random(4000);

//sets choice to 0
int choice = 0;
//dowhile: The menu has to be shown once before the user can choose to quit
do
{
    choice = 0;
    //displays menu
    Console.WriteLine("\n=== CSCI 1250 Lab 06 ===" + "\n1. The Grade Checker" + "\n2. The Dice Table" + "\n3. The Score Report" + "\n4. All three" + "\n5. Quit"); 
    //while: it will execute zero times if the first input is valid, or repeatedly until the input is valid
    while(choice < 1 || choice > 5)
    {
        //reprompts user because of invalid input
         Console.Write("Choose 1 through 5: ");
        choice = Convert.ToInt32(Console.ReadLine());

        if (choice < 1 || choice > 5)
    {
        Console.WriteLine("Choose a number from 1 to 5.");
    }
    }
    


if (choice == 1 || choice == 4)
{
//Exercise 1
//displays exercise 1 message
Console.WriteLine("\n=== Exercise 1: The Grade Checker ===");
//declares and sets score to initial number
int score = -1;
//declares the varialbe named grade
char grade;
//while: A valid first score requires no retry, but invalid scores require repeated prompting
while(score < 0 || score > 100)
    {
        //prompts for score
        Console.Write("Score: ");
        score = Convert.ToInt32(Console.ReadLine());
        //repeats prompt if given invalid number
        if(score < 0 || score > 100)
        {
            Console.WriteLine("A score must be between 0 and 100.");
        }
    }
        //determines grade based on user input
        if(score >= 90)
        {
            grade = 'A';
        }

        else if(score >= 80)
        {
            grade = 'B';
        }

        else if(score >= 70)
        {
            grade = 'C';
        }

        else if(score >= 60)
        {
            grade = 'D';
        }
        else
        {
            grade = 'F';
        }
        //displays grade
        Console.WriteLine(score + " earns a " + grade + ".");
    
}
if (choice == 2 || choice == 4)
{
//Exercise 2
//displays exercise 2 message
Console.WriteLine("\n=== Exercise 2: The Dice Table ===");
//declares variables rolls and wins and sets them to a default, also declares the variable wins
int rolls = 0;
int wins = 0;
char answer;
//do while: At least one roll must occur before asking whether the user wants to roll again
do
    {
        int die1 = rng.Next(1, 7);
        int die2 = rng.Next(1, 7);
        rolls++;
        int total = die1 + die2;

        Console.Write("Roll " + rolls + ": " + die1 + " and " + die2 + ", total " + total + ".");

        if(die1 == 1 && die2 == 1)
        {
            Console.WriteLine(" Snake eyes.");
        }

        else if(die1 == die2)
        {
            Console.WriteLine(" Doubles!");
        }

        else if(total == 7 || total == 11)
        {
            wins++;
            Console.WriteLine(" A winner.");
        }
        else
        {
        Console.WriteLine();
        }
        Console.Write("Roll again? (y/n): ");
        answer = Convert.ToChar(Console.ReadLine());
    } while(answer == 'y');
    Console.WriteLine("You rolled " + rolls + " times and won " + wins + ".");
}
if (choice == 3 || choice == 4)
{
//Exercise 3
//displays exercise 3 message
Console.WriteLine("\n=== Exercise 3: The Score Report ===");
//declares needed variables and the array
int total = 0;
int highest = 0;
int passing = 0;
int[] scores = new int[5];

//for: The array index is required to store each entry and number into the prompt
for (int i = 0; i < scores.Length; i++)
    {
        //prompts user for scores
        Console.Write("Score " + (i + 1) + ": ");
scores[i] = Convert.ToInt32(Console.ReadLine());
    }

//foreach: Every score has to be used, but the array position isn't needed
    foreach(int score in scores)
{
    //calculates total
    total += score;
    //determines highest score
    if (score > highest)
    {
        highest = score;
    }
    //determines if a score is passing and counts how many are passing
    if (score >= 60)
    {
        passing++;
    }
}
//displays scores entered, total, average, highest, and amount of passing 
double average = Convert.ToDouble(total) / scores.Length;
Console.WriteLine("\nScores entered: " + scores.Length);
Console.WriteLine("Total: " + total);
Console.WriteLine("Average: " + average.ToString("F1"));
Console.WriteLine("Highest: " + highest);
Console.WriteLine("Passing: " + passing + " of " + scores.Length);
}
} while(choice != 5);
//displays goodbye if user input is 5
Console.WriteLine("Goodbye.");