char[] nucleotídeos = new char[6];


Console.WriteLine("Informe 6 caracteres para contagem de nucleotídeo. OBS: Só pode escolher 'A', 'C', 'G' ou 'T'");
for(int i = 0; i < nucleotídeos.Length; i++)
{
    nucleotídeos[i] = Convert.ToChar (Console.ReadLine());
}
Console.Clear();
foreach(char itens in nucleotídeos)
{
    if(itens == 'A' || itens == 'C' || itens == 'G' || itens == 'T')
    {
        Console.WriteLine("Os nucleotídeos escolhidos foram: ");
        Console.WriteLine($"{itens}");
    }
    else
    {
        Console.WriteLine($"{itens} -> erro");
    }
}

