// Faça um programa que o usuário informe o salário recebido e o total gasto. Deverá ser exibido na tela “Gastos dentro do orçamento” caso o valor gasto não ultrapasse o valor do salário e “Orçamento estourado” se o valor gasto ultrapassar o valor do salário.

float salario;
float gastos;

Console.WriteLine($"Informe o seu salário ");
salario = float.Parse (Console.ReadLine());

Console.WriteLine($"Informe os seus gastos ");
gastos = float.Parse (Console.ReadLine());

if (salario >= gastos)
{
    Console.WriteLine($"Gastos dentro do orçamento");
}
else
{
    Console.WriteLine($"Orçamento estourado");   
}