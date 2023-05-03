string[] color = new string[10] { "Preto", "Marrom", "Vermelho", "Laranja", "Amarelo", "Verde", "Azul", "Violeta", "Cinza", "Branco" };

//for(int i = 0; i < color.Length; i++)
//{
//    Console.WriteLine(color[i]);
//}
Console.WriteLine("Escolha um número de 0 a 9 para descobrir a cor da banda");
int option  = Convert.ToInt32(Console.ReadLine());

switch (option)
{
    case 0:
        Console.WriteLine(color[option]);
        break;
    case 1:
        Console.WriteLine(color[option]);
        break;
    case 2:
        Console.WriteLine(color[option]);
        break;
    case 3:
        Console.WriteLine(color[option]);
        break;
    case 4:
        Console.WriteLine(color[option]);
        break;
    case 5:
        Console.WriteLine(color[option]);
        break;
    case 6:
        Console.WriteLine(color[option]);
        break;
    case 7:
        Console.WriteLine(color[option]);
        break;
    case 8:
        Console.WriteLine(color[option]);
        break;
    case 9:
        Console.WriteLine(color[option]);
        break;
    default: 
        Console.WriteLine("Cor não encontrada");
        break;
}
