int qtd_linhas = 3, qtd_colunas = 4;
int[,] matriz = new int[qtd_linhas,qtd_colunas], matriz2 = new int[qtd_linhas, qtd_colunas], matriz_resultante = new int[qtd_linhas, qtd_colunas];
// ou int [][] matriz = new int [linhas][colunas]

// matriz 1
for (int linha = 0; linha < qtd_linhas ; linha++)
{
    for (int coluna = 0;coluna < qtd_colunas ; coluna++ )
    {
        matriz[linha,coluna] = new Random().Next(0,10);
    }
}

Console.WriteLine("Matriz 1:");
for (int linha = 0; linha < qtd_linhas; linha++)
{
    Console.WriteLine();
    for (int coluna = 0; coluna < qtd_colunas; coluna++)
    {
        Console.Write(matriz[linha, coluna] + " ");
    }
}

//matriz2
for (int linha = 0; linha < qtd_linhas; linha++)
{
    for (int coluna = 0;coluna < qtd_colunas ; coluna++)
    {
        matriz2[linha, coluna] = new Random().Next(0, 10);
    }
}

Console.WriteLine("\nMatriz 2:");
for (int linha = 0; linha < qtd_linhas; linha++)
{
    Console.WriteLine();
    for (int coluna = 0; coluna < qtd_colunas; coluna++)
    {
        Console.Write(matriz2[linha, coluna] + " ");
    }
}

// matriz resultante
for (int linha = 0; linha < qtd_linhas; linha++)
{
    for (int coluna = 0; coluna < qtd_colunas; coluna++)
    {
        matriz_resultante[linha, coluna] = matriz[linha, coluna] + matriz2[linha,coluna];   
    }
}

Console.WriteLine("\nMatriz resultante:");
for (int linha = 0; linha < qtd_linhas; linha++)
{
    Console.WriteLine();
    for (int coluna = 0; coluna < qtd_colunas; coluna++)
    {
        Console.Write(matriz_resultante[linha, coluna] + " ");
    }
}