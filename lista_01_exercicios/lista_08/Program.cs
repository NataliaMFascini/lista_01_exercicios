/*
8) Verificação de votos
 
- Objetivo: Entenda a lógica das permissões baseadas em condições. 
- Descrição: 
    > Crie um programa que solicite a idade de uma pessoa e determine se ela pode votar (idade >= 16).
    > Use uma condição if para exibir a mensagem correspondente. 
- Exemplo de saída: "Você pode votar." ou "Você não pode votar."
   */

Console.WriteLine("Digite sua idade: ");
int idade = int.Parse(Console.ReadLine()); 

if(idade >= 16)
{
    Console.WriteLine("Você pode votar.");
}
else
{
    Console.WriteLine("Você não pode votar.");
}