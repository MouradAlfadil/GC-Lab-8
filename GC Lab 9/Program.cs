using GC_Lab_9;

bool isrunning = true;
List<Circle> circles = new List<Circle>();
double choice = 0;

while (isrunning)
{
    //greet
    Console.WriteLine("Hello, please enter a radius");
    //collect response
    while (true)
    {


        try
        {
            choice = double.Parse(Console.ReadLine());
            if (choice < 0)
            {
                Console.WriteLine("Number cannot be negative, please try again");
                continue;
            }
            break;

        }
        catch (FormatException e)
        {
            Console.WriteLine("Incorrect input, please try again");
            continue;
        }
    }

    //construct new circle
    Circle circ = new Circle(choice);
    circles.Add(circ);
    //post results
    Console.WriteLine($"Circumference: {circ.CalculateFormattedCircumference()}");
    Console.WriteLine($"Area: {circ.CalculateFormattedArea()}");

    //ask if they want to continue
    Console.WriteLine("Would you like to continue? (Enter y to continue, any other key to exit)");
    if (Console.ReadLine().ToLower().Trim() == "y")
    {
        continue;
    }
    else
    {
        isrunning = false;
        continue;
    }


}

//cw goodbye and the total number of circles they made
Console.WriteLine($"Goodbye. You have created {circles.Count} circles.");
Console.Read();











