//As maçãs custam R$ 0,30 cada se forem compradas menos do que uma dúzia, e R$ 0,25 se forem compradas pelo menos doze. Escreva um programa que leia o número de maçãs compradas, calcule e escreva o valor total da compra.

int macas;

Console.WriteLine($"Informe a quantidade de maçãs desejadas");
macas = int.Parse (Console.ReadLine());

if (macas < 6)
{
    Console.WriteLine($"O total da sua compra será {macas * 0.3} reais");
}
else
{
    Console.WriteLine($"O total da sua compra será {macas * 0.25} reais");
}