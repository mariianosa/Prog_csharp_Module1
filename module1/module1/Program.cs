using System;
// Створіть клас Matrix, який представляє цілочисельну матрицю. В цьому класі створіть:
// Зубчастий двовимірний масив цілих чисел.
// Індексатор для доступу до елементів матриці за допомогою індексів row та column.

// Напишіть метод FillMatrixRandom(int rows, int columns, int min, int max), який заповнює матрицю випадковими числами в діапазоні від min до max.
// Створіть об'єкт класу Matrix, заповніть його випадковими значеннями та виведіть матрицю на консоль. 
// Потім, за допомогою індексатора, знайдіть та виведіть значення певного елемента матриці.
namespace program1{
class Matrix
{
    public int[][] matrix;

    public Matrix(int rows, int columns)
    {
        matrix = new int[rows][];
        for (int i = 0; i < rows; i++){
            matrix[i] = new int[columns];
        }
    }
   public int this[int row, int column]
    {
        get { return matrix[row][column]; }
        set { matrix[row][column] = value; }
    }
    
     public void FillRandom(int rows, int columns, int min, int max)
    {
        Random rand = new Random();
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                matrix[i][j] = rand.Next(min, max);
            }
        }
    }
    public void PrintMatrix(){
        foreach(int[] row in matrix){
            foreach(int num in row){
                Console.Write(num+"\t");
            }
            Console.WriteLine();
        }
    }

}

class Program{
    static void Main(string[]args){
        Matrix myMatrix = new Matrix(3,3);
        myMatrix.PrintMatrix();
        myMatrix.FillRandom(3,3,1,100);
        myMatrix.PrintMatrix();
        int row = 1;
        int column = 1;
        int element = myMatrix[row,column];
        Console.WriteLine($"The element in {row} row and {column} column is {element}");
    }
}

}
