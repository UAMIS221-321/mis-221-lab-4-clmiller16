//Start Main
int userChoice = GetUserChoice(); // priming read
while(userChoice !=3) // condition check
{
    RouteEm(userChoice);
    userChoice = GetUserChoice(); //update read
}







//End Main

//Start Methods

//Displays the menu and gets a user choice
static int GetUserChoice()
{
    DisplayMenu();
    string userChoice = Console.ReadLine();
    if(IsValidChoice(userChoice))
    {
        return int.Parse(userChoice);
    }
    else return 0;
}

//Displays the menu to the user
static void DisplayMenu()
{
    Console.Clear();
    System.Console.WriteLine("Welcome, we will generate a triangle of a random size");
    System.Console.WriteLine();
    System.Console.WriteLine("Enter 1 to display full triangle\nEnter 2 to display partial triangle\nEnter 3 to exit");

}
//Checks if a correct menu option was selected
static bool IsValidChoice(string userInput)
{
    if (userInput == "1" || userInput == "2" || userInput == "3")
    {
        return true;
    }
    return false;
}

//Display based on menu option selected
static void RouteEm(int menuChoice)
{
    if(menuChoice == 1)
    {
        GetFull();
    }
    else if(menuChoice == 2)
    {
        GetPartial();
    }
    else if(menuChoice != 3)
    {
        SayInvalid();
    }
}

//Pauses the action so that you have time to see the output display messege
static void PauseAction()
{
    System.Console.WriteLine("Press any key to continue");
    Console.ReadKey();
}

// Random number generators 
static int GenerateRandomNumForRows()
{
    Random rnd= new Random();
    int number = rnd.Next(3,10);
    return number;
}

static int GenerateRandomNumForStones()
{
    Random rnd= new Random();
    int number = rnd.Next(1,101);
    return number;
}


// Output Options
static void GetFull()
{
    PrintFullTriangle();
    PauseAction();
}
static void GetPartial()
{
    PrintPartialTriangle();
    PauseAction();
}
static void SayInvalid()
{
    System.Console.WriteLine("Your input is invalid. Intelligence isn't for everyone.");
    PauseAction();
}

// Printing Full Triangle
static void PrintFullTriangle()
{
    int count = 0;
    int rows = GenerateRandomNumForRows();
    System.Console.WriteLine();
    System.Console.WriteLine("Your triangle has " + rows + " rows.");
    int spaces = rows - 1;

    for (int j = 0; j <= rows; j++)
    {
      for (int l = 0; l < count; l++)
        {
            System.Console.Write("O");
        }
        for (int k = 0; k < spaces; k++)
        {
            System.Console.Write(" ");
        }
        spaces = spaces - 1;
        count = count + 1;
        System.Console.WriteLine("");
    }
}

// Printing partial triangle
static void PrintPartialTriangle()
{
    int count = 0;
    int rows = GenerateRandomNumForRows();
    int numForStone = GenerateRandomNumForStones();
    System.Console.WriteLine();
    System.Console.WriteLine("Your triangle has " + rows + " rows.");
    int spaces = rows - 1;

    for (int j = 0; j <= rows; j++)
    {
      for (int l = 0; l < count; l++)
        {
            if (numForStone <= 92)
            {
                System.Console.Write("O");
            }
            numForStone = GenerateRandomNumForStones();
        }
        for (int k = 0; k < spaces; k++)
        {
            System.Console.Write(" ");
        }
        spaces = spaces - 1;
        count = count + 1;
        System.Console.WriteLine("");
    }
}


// End Methods



