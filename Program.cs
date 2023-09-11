public class Program
{
    public static void Main(string[] args)
    {
        /* 1- Inversão de Array -> Escreva um programa que recebe um array de 10 números inteiros do usuário e os mostra na ordem
        inversa. */
        Console.WriteLine("1- Inversão de Array");

        int[] numeros = new int[10];

        Console.WriteLine("Informe 10 números inteiros:");

        for (int i = 0; i < numeros.Length; i++)
        {
            numeros[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("********************");

        for (int i = numeros.Length - 1; i >= 0; i--)
        {
            Console.WriteLine(numeros[i]);
        }

        /* 2- Menor e Maior Valor -> Escreva um programa que recebe um array de números inteiros do usuário e determina o menor e o
        maior número dentro desse array. Não utilize funções prontas para essa finalidade. */
        Console.WriteLine("\n2- Menor e Maior Valor");

        int[] arrNumeros = new int[4];
        int maior = int.MinValue, menor = int.MaxValue;

        Console.WriteLine("Informe 4 valores inteiros:");

        for (int i = 0; i < arrNumeros.Length; i++)
        {
            arrNumeros[i] = int.Parse(Console.ReadLine());
            if (arrNumeros[i] > maior) maior = arrNumeros[i];
            if (arrNumeros[i] < menor) menor = arrNumeros[i];
        }

        Console.WriteLine("********************");

        Console.WriteLine($"Maior: {maior}\nMenor: {menor}");

        /* 3- Nome em Posição -> Crie um programa onde o usuário informa 5 nomes. Após inserir todos os nomes, o programa deve pedir
        ao usuário um índice (entre 0 e 4). O programa deve então mostrar o nome que está na posição correspondente a esse índice. */
        Console.WriteLine("\n3- Nome em Posição");

        string[] nomes = new string[5];

        Console.WriteLine("Informe 5 nomes:");

        for (int i = 0; i < nomes.Length; i++)
        {
            nomes[i] = Console.ReadLine();
        }

        Console.WriteLine("********************");

        Console.WriteLine("Informe um valor (índice) entre 0 e 4:");
        int indice = int.Parse(Console.ReadLine());

        Console.WriteLine("********************");

        Console.WriteLine(indice >= 0 && indice <= 4 ? $"{nomes[indice]}" : "Valor inválido!");

        /* 4- Cópia Invertida -> Escreva um programa que receba um array de 5 strings do usuário. Em seguida, copie esse array para
        outro, mas de forma invertida (o último elemento se torna o primeiro, o penúltimo se torna o segundo, e assim por diante).
        Mostra o array invertido na tela. */
        Console.WriteLine("\n4- Cópia Invertida");

        string[] arrStrings = new string[5];
        string[] arrStringsInvertido = new string[5];

        Console.WriteLine("Escreva 5 strings:");

        for (int i = 0; i < arrStrings.Length; i++)
        {
            arrStrings[i] = Console.ReadLine();

            arrStringsInvertido[(arrStringsInvertido.Length - 1) - i] = arrStrings[i];
        }

        Console.WriteLine("********************");

        foreach (String invertido in arrStringsInvertido)
        {
            Console.WriteLine(invertido);
        }

        /* 5- Contagem de Caracteres -> Peça ao usuário para inserir uma série de palavras (strings). Armazene essas palavras em um
        array e, em seguida, calcule e mostre quantos caracteres no total foram inseridos, somando todos os caracteres de todas
        as palavras. */
        Console.WriteLine("\n5- Contagem de Caracteres");

        string[] palavras = new string[6];
        int totalCaracteres = 0;

        Console.WriteLine("Escreva 6 palavras:");

        for (int i = 0; i < palavras.Length; i++)
        {
            palavras[i] = Console.ReadLine();
            totalCaracteres += palavras[i].Length;
        }

        Console.WriteLine("********************");

        Console.WriteLine($"Foram digitados um total de {totalCaracteres} caracteres");

        /* 6- Identificando números duplicados -> Escreva um programa que receba 10 números inteiros do usuário e indique se há
        números duplicados entre eles. */
        Console.WriteLine("\n6- Identificando números duplicados");

        Console.ReadKey();
    }
}
