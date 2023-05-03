double[] notas = new double[3];

for(int i = 0; i < notas.Length; i++)
{
    Console.WriteLine($"Informe sua {i + 1}º nota: ");
    notas[i] = Convert.ToDouble(Console.ReadLine());
}
double med = (notas[0] + notas[1] + notas[2]) / 3;
Console.WriteLine("Média final = " + med);


