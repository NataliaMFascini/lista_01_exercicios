/*
3) Aprovação do aluno

- Objetivo: Compreender a aplicação das condições para a tomada de decisão. 
- Descrição: 
	> Escreva um programa que solicite a nota de um aluno. 
	> Se a nota for maior ou igual a 6, o aluno é considerado "Aprovado". 
	> Caso contrário, ele está "falhando". 
	> Exiba a situação do aluno na tela. 
- Exemplo de saída: "Aluno aprovado." ou "Aluno reprovado".
*/

Console.WriteLine("Digite a nota: ");
double nota = double.Parse(Console.ReadLine());

if (nota >= 6)
{
    Console.WriteLine("Aluno aprovado.");
}
else
{
    Console.WriteLine("Aluno reprovado.");
}
