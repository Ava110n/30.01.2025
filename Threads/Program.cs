int n = 2, m = 2;
int[,] A = create(n, m);
int[,] B = create(n, m);

show(A);
show(B);

int[,] C = multiply(A, B);
show(C);


/*for (int i = 0; i < 5; i++)
{
    Thread t = new Thread(() => print(2,3));
    t.Start();
}
Console.WriteLine(x);*/

int[,] multiply(int[,] A, int[,] B)
{
    int[,] C = new int[A.GetLength(0), B.GetLength(1)];
    for(int i = 0;i < A.GetLength(0); i++)
        for(int j = 0;j < B.GetLength(1); j++)
            for(int k = 0;k < A.GetLength(1); k++)
                C[i,j] += A[i,k] * B[k,j];
    return C;
}

void show(int[,] matrix)
{
    for (int i = 0;i < matrix.GetLength(0); i++) { 
        for (int j = 0;j < matrix.GetLength(1);j++)
            Console.Write(matrix[i,j]+" ");
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] create(int n, int m)
{
    Random random = new Random();
    int[,] matrix = new int[n, m];
    for(int i = 0;i < n;i++)
        for(int j = 0;j < m;j++)
            matrix[i,j] = random.Next(1, 10);
    return matrix;
}

