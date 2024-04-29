int convidados;
decimal KgCarne = 35m;
decimal valorCerveja = 2.49m;
decimal consumoCarne = 0.500m;
decimal consumoCerveja = 6;
decimal qtdeTotalCarne;
decimal qtdeTotalCerveja;
decimal totalCarne;
decimal totalCerveja;
decimal valorTotal;
decimal desconto = 0;

Console.Write("Informe o número de convidados: ");
convidados = Convert.ToInt32(Console.ReadLine());

qtdeTotalCarne = convidados * consumoCarne;
totalCarne = qtdeTotalCarne * KgCarne;
qtdeTotalCerveja = convidados * consumoCerveja;
totalCerveja = qtdeTotalCerveja * valorCerveja;
valorTotal = totalCarne + totalCerveja;

if (valorTotal > 100 && valorTotal <= 300)
{
    desconto = valorTotal * 0.05m;
}
else if (valorTotal > 300)
{
    desconto = valorTotal * 0.10m;
}
Console.Clear();
Console.WriteLine("Número de Convidados: " + convidados);
Console.WriteLine("Qtde de Carne: " + qtdeTotalCarne);
Console.WriteLine("Valor de Carne: " + totalCarne);
Console.WriteLine("Qtde de Cerveja: " + qtdeTotalCerveja);
Console.WriteLine("Valor de Cerveja: " + totalCerveja);
Console.WriteLine("Desconto: " + desconto.ToString("F2"));
Console.WriteLine("Valor Total: " + (valorTotal - desconto));