using Shared;

Console.Write("Ingrese el valor de m: ");
int m = int.Parse(Console.ReadLine());

Console.Write("Ingrese el valor de n: ");
int n = int.Parse(Console.ReadLine());

Console.Write("Ingrese el valor de p: ");
int p = int.Parse(Console.ReadLine());

int[,] A = new int[m, n];
int[,] B = new int[n, p];
int[,] C = new int[m, p];

for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        A[i, j] = (i + 1) * j;
    }
}

for (int i = 0; i < n; i++)
{
    for (int j = 0; j < p; j++)
    {
        B[i, j] = (j + 1) * i;
    }
}

Console.WriteLine("*** A ***");

for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        Console.Write(A[i, j] + " ");
    }
    Console.WriteLine();
}

Console.WriteLine("*** B ***");

for (int i = 0; i < n; i++)
{
    for (int j = 0; j < p; j++)
    {
        Console.Write(B[i, j] + " ");
    }
    Console.WriteLine();
}

for (int i = 0; i < m; i++)
{
    for (int j = 0; j < p; j++)
    {
        for (int k = 0; k < n; k++)
        {
            C[i, j] += A[i, k] * B[k, j];
        }
    }
}

Console.WriteLine("*** C ***");

for (int i = 0; i < m; i++)
{
    for (int j = 0; j < p; j++)
    {
        Console.Write(C[i, j] + " ");
    }
    Console.WriteLine();
}
