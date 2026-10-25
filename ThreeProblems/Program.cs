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
Random rng = new Random();

int choice = 0;
//Displays Menu
Console.WriteLine("=== CSCI 1250 Lab 06 ===" + "\n1. The Grade Checker" + "\n2. The Dice Table" + "\n3. The Score Report" + "\n4. All three" + "\n5. Quit" + "\nChoose 1 through 5: 7" + "\nChoose a number from 1 to 5." + "\nChoose 1 through 5: 3");
choice = 0;
Convert.ToInt32(Console.ReadLine());

if (choice == 1 || choice == 4)
{
// Exercise 1

//declares and sets score to initial number
int score = -1;
//declares the varialbe named grade
char grade;
//while: A valid first score requires no retry, but invalid scores require repeated prompting
while(score < 0 || score > 100)
    {
        //prompts for score
        Console.WriteLine("Enter a score between 0 and 100");
        Convert.ToInt32(Console.ReadLine());
        //repeats prompt if given invalid number
        if(score < 0 || score > 100)
        {
            Console.WriteLine("A score must be between 0 and 100");
        }
        Console.WriteLine("Socre: " + score);
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
        Console.WriteLine(score + " earns a " + grade);
    }
}
if (choice == 2 || choice == 4)
{
// Exercise 2

}
if (choice == 3 || choice == 4)
{
// Exercise 3
}