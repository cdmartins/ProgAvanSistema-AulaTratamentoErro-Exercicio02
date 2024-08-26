/*Escreva um programa para preencher valores de um vetor de inteiros com 10 posições. O usuário irá informar os valores a serem
inseridos e suas respectivas posições no array. O programa deverá tratar as exceções ArrayIndexOutOfBoundsException quando for
informada uma posição inexistente do vetor e NumberFormatException quando o valor informado não for número.*/

int[] vetor_de_inteiros = new int[10];


for (int i = 0; i < vetor_de_inteiros.Length; i++)
{
    try
    {
        Console.Write("Entre com o número pra preencher o vetor: ");
        int vetor = int.Parse(Console.ReadLine()!);

        Console.Write("Posição a ser adicionada: ");
        int posicao = int.Parse(Console.ReadLine()!);
        vetor_de_inteiros[posicao] = vetor;
    }
    catch (FormatException ex)
    {
        Console.WriteLine($"Erro: {ex.Message}\nFormato inválido. Tente novamente.");
        i--;

    }
    catch (IndexOutOfRangeException ex)
    {
        Console.WriteLine($"Erro: {ex.Message}\nIndex fora do range. Tente novamente.");
        i--;
        continue;
    }

}
Console.WriteLine("\nVetor preenchido: ");
foreach (int vetor in vetor_de_inteiros)
{
    Console.Write($"[{vetor}]");
}