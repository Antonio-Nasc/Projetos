string[,] tabuleiro = new string[8, 8]
{
    {"-", "-", "-", "-", "-", "-", "-", "-"},
    {"-", "-", "-", "-", "-", "-", "-", "-"},
    {"-", "-", "-", "-", "-", "-", "-", "-"},
    {"-", "-", "-", "-", "-", "-", "-", "-"},
    {"-", "-", "-", "-", "-", "-", "-", "-"},
    {"-", "-", "-", "-", "-", "-", "-", "-"},
    {"-", "-", "-", "-", "-", "-", "-", "-"},
    {"-", "-", "-", "-", "-", "-", "-", "-"}
};
Console.WriteLine("Informe a linha que a rainha1 está?");
int posLinha = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Informe a coluna que a rainha1 está?");
int posColuna = Convert.ToInt32(Console.ReadLine());
string rainha1 = "X";
tabuleiro[posLinha, posColuna] = rainha1;

Console.WriteLine("Informe a linha que a rainha2 está?");
int posLinha2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Informe a coluna que a rainha2 está?");
int posColuna2 = Convert.ToInt32(Console.ReadLine());
string rainha2 = "Y";
tabuleiro[posLinha2, posColuna2] = rainha2;

for (int linha = 0; linha < 8; linha++)
{
    for (int coluna = 0; coluna < 8; coluna++)
    {
        Console.Write(tabuleiro[linha, coluna] + " ");
    }
    Console.WriteLine();
}

if(posColuna == posColuna2 || posLinha == posLinha2)
{
    Console.WriteLine("Uma rainha pode atacar a outra");
}
else
{
    Console.WriteLine("As rainhas não podem se atacar");
}
