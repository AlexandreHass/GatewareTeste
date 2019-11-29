using System;

namespace GatewareTeste
{
    //1 - Em C#, encontre o maior numero inteiro em um array.
    public class Exercicio1
    {

        int[] array = { 3, -9, 0, 2, 75, 29, 69 };

        public void MaiorDoArray()
        {
            Array.Sort(array);
            Console.WriteLine($"\nResultado: { array[array.Length - 1] }");
        }
        // PS: Eu poderia ter feito a estrutura clássica em C para percorrer o vetor e ir armazenando o maior,
        // porém, como se trata de C# decidi utilizar os recursos que ele proporciona.
    }
}
