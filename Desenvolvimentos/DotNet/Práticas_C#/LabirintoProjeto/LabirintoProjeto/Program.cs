using System;
using System.Xml;


string[,] labirinto = new string[4, 5]
{
    {"1","0","0","0","1" },
    {"0","0","1","0","1" },
    {"1","1","1","0","F" },
    {"1","1","1","1","1" }
};

string player = "X";
int posLinha = 1;
int posColuna = 0;
labirinto[1, 0] = player;
bool fimDeJogo = false;

while (!fimDeJogo)
{
    Console.Clear();
    Console.WriteLine("Bem-vindo ao meu jogo de labirinto!");
    Console.WriteLine();
    for (int linha = 0; linha < 4; linha++)
    {
        for (int coluna = 0; coluna < 5; coluna++)
        {
            
            Console.Write(labirinto[linha, coluna] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
    Console.WriteLine("Escolha uma opção de caminho: \r\n\r\n(C) - Para cima\r\n(E) - Para esquerda\r\n(D) - Para direita\r\n(B) - Para baixo");
    string option = Console.ReadLine().ToUpper();

    if (option == "C")
    {
        if (labirinto[posLinha - 1, posColuna] != "1")
        {
             labirinto[posLinha, posColuna] = "0";
             posLinha--;
        }
    }
    else if (option == "E")
    {
        if (labirinto[posLinha, posColuna - 1] != "1")
        {
            labirinto[posLinha, posColuna] = "0";
            posColuna--;
        }
    }
    else if (option == "D")
    {
        if (labirinto[posLinha, posColuna + 1] != "1")
        {
            labirinto[posLinha, posColuna] = "0";
            posColuna++;
        }
    }
    else if (option == "B")
    {
        if (labirinto[posLinha + 1, posColuna] != "1")
        {
            labirinto[posLinha, posColuna] = "0";
            posLinha++;
        }
    }
    labirinto[posLinha, posColuna] = player;

    if (labirinto[2, 4] == player)
    {
        fimDeJogo = true;
    }
}
    Console.Clear();
    Console.WriteLine("Parabéns! Você conseguiu achar o final do labirinto.");
    Console.WriteLine("Tecle ENTER para encerrar.");
    Console.ReadKey();