/*
9) Dia da semana (usando if-else)

- Objetivo: Pratique o uso de várias condições com if, else if e else. 
- Descrição:
    > Desenvolva um programa que solicite um número de 1 a 7 e exiba o dia da semana correspondente (1 para "domingo", 2 para "segunda-feira", etc.).
    > Se o número estiver fora desse intervalo, exiba uma mensagem de erro. 
- Exemplo de saída: "Domingo", "Segunda-feira", etc., ou "Número inválido. Digite um número de 1 a 7."
*/

Console.WriteLine("Digite um número entre 1 e 7: ");
int dia = int.Parse(Console.ReadLine());

if(dia == 1)
{
    Console.WriteLine("Domingo.");
}
else if (dia == 2)
{
    Console.WriteLine("Segunda-feira."); 
}
else if( dia == 3)
{
    Console.WriteLine("Terça-feira.");
}
else if (dia == 4)
{
    Console.WriteLine("Quarta-feira.");
}
else if(dia == 5)
{
    Console.WriteLine("Quinta-feira.");
}
else if (dia == 6)
{
    Console.WriteLine("Sexta-feira.");
}
else if (dia == 7)
{
    Console.WriteLine("Sábado");
}
else
{
    Console.WriteLine("Número inválido. Digite um número de 1 a 7.");
}