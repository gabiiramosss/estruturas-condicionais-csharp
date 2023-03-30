//Escreva um programa que leia as medidas dos lados de um triângulo e escreva se ele é equilátero, isósceles ou escaleno sendo que:    
//Triângulo Equilátero: 3 lados iguais
//Triângulo Isóscele: possui 2 lados iguais
//Triângulo Escaleno: possui 3 lados diferentes

float medida1;
float medida2;
float medida3;

Console.WriteLine($"Informe a primeira medida da aresta do triângulo ");
medida1 = float.Parse (Console.ReadLine());

Console.WriteLine($"Informe a segunda medida da aresta do triângulo ");
medida2 = float.Parse (Console.ReadLine());

Console.WriteLine($"Informe a terceira medida da aresta do triângulo ");
medida3 = float.Parse (Console.ReadLine());

if (medida1 == medida2 && medida2 == medida3)
{
    Console.WriteLine($"O triângulo é equilátero");    
}
else if (medida1 == medida2 || medida1 == medida3 || medida2 == medida3)
{
    Console.WriteLine($"O triângulo é isósceles");
}
else
{
    Console.WriteLine($"O triângulo é escaleno");  
}