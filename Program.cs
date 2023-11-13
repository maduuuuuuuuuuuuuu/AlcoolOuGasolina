
Console.Write("Digite o preço do etanol (R$).....: ");
decimal etanol = Convert.ToDecimal(Console.ReadLine());

Console.Write("Digite o preço da gasolina (R$)...: ");
decimal gasolina = Convert.ToDecimal(Console.ReadLine());

string recomendacao;

if (AbastecerComGasolina(etanol, gasolina))
{
    recomendacao = "Gasolina";
}
else
{
    recomendacao = "Etanol";
}

double razao = RazaoEtanolGasolina(etanol, gasolina) * 100;

Console.WriteLine($"O preço do etanol corresponde a {razao:F2}% do preço da gasolina.");
Console.WriteLine($"Recomendação: Abasteça com {recomendacao.ToUpper()}.");

double RazaoEtanolGasolina(decimal RSEtanol, decimal RSGasolina)
{
    return Convert.ToDouble(RSEtanol / RSGasolina);
}

bool AbastecerComGasolina(decimal RSEtanol, decimal RSGasolina)
{
    const double MinRazaoUsoGasolina = 0.73;
    return RazaoEtanolGasolina(RSEtanol, RSGasolina) >= MinRazaoUsoGasolina;
}
