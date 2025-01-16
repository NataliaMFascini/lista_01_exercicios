/*
7) Comparação de números
 
- Objetivo: Pratique a comparação de variáveis. 
- Descrição:
    > Escreva um programa que solicite ao usuário dois números e determine qual é o maior.
    > Use if, else if e else para exibir a mensagem apropriada. 
- Exemplo de saída: "O primeiro número é maior.", "O segundo número é maior." ou "Os números são iguais."
*/

Console.WriteLine("Digite o primeiro número: ");
int n1 = int.Parse(Console.ReadLine());
Console.WriteLine("Digite o segundo número: ");
int n2 = int.Parse(Console.ReadLine());

if(n1 == n2)
{
    Console.WriteLine("Os números são iguais.");
}
else if(n1 > n2){
    Console.WriteLine("O primeiro número é maior.");
}
else
{
    Console.WriteLine("O segundo número é maior.");
}
