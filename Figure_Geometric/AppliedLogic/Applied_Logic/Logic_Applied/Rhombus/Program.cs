using Shared;

var answer = "s";
var options = new List<string> { "s", "n" };

while (answer == "s")
{

    object ConsoleExtension = null;
    int n = ConsoleExtension.GetInt("Enter another rhombus: ");


    for (int i = 1; i <= n; i += 2)
    {
        int spaces = (n - i) / 2;

        for (int j = 0; j < spaces; j++)
            Console.Write(" ");

        for (int j = 0; j < i; j++)
        {
            if (j == 0 || j == i - 1)
                Console.Write("#");
            else
                Console.Write(" ");
        }

        Console.WriteLine();
    }


    for (int i = n - 2; i >= 1; i -= 2)
    {
        int spaces = (n - i) / 2;

        for (int j = 0; j < spaces; j++)
            Console.Write(" ");

        for (int j = 0; j < i; j++)
        {
            if (j == 0 || j == i - 1)
                Console.Write("#");
            else
                Console.Write(" ");
        }
        Console.WriteLine();
    }

    answer = ConsoleExtension.GetValidOptions("¿You wish to enter another rhombus? (s/n): ",
        options
        ) ?? "n";
}