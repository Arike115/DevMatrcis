// See https://aka.ms/new-console-template for more information
//operators
//logical // &&,||,!
//relational // ==,!=,>,<,>=,=<
//Statement
//conditational statement
//if else
//switch case
//loopings
//foreach
//for
//do while
//while


int v = 7;
int i = 5;
int x = 5;
int age = 18;

//if else
if (v > i)
{
    Console.WriteLine("welcome to you are in!");
}
else if (x == i)
{
    Console.WriteLine("not partially in let try again");
}
else
{
    Console.WriteLine("you are out!");
}


if (v < age || age == v || v > age)
{
    Console.WriteLine("welcome to you are in!");
}
else
{
    Console.WriteLine("you are out!");
}


//switch

int day = 3;
switch (day)
{
    case 1:
        Console.WriteLine("Monday");
        break;
    case 2:
        Console.WriteLine("Tuesday");
        break;
    case 3:
        Console.WriteLine("wednesday");
        break;
    case 4:
        Console.WriteLine("Thursday");
        break;
    case 5:
        Console.WriteLine("Friday");
        break;
    case 6:
        Console.WriteLine("Saturday Note: we don work on weekends");
        break;
    case 7:
        Console.WriteLine("Sunday");
        break;
    default: 
        Console.WriteLine("sorry invalid days");
        break;
}



