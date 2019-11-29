using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace GatewareTeste
{
    class Exercicio3
    {
        private static DirectoryInfo diretorio = new DirectoryInfo(@"D:\Temp\Arquivos");

        public void ManipularArquivos()
        {
            string novaPasta = CriarPasta();
            if (!string.IsNullOrEmpty(novaPasta))
            {
                MoverArquivos(novaPasta);
            }
        }

        private string CriarPasta()
        {
            Console.WriteLine("Criando pasta...");
            string novaPasta = $@"{diretorio.ToString()}\PastaNova";
            Directory.CreateDirectory(novaPasta);

            if (Directory.Exists(novaPasta))
            {
                Console.WriteLine($"Pasta criada com sucesso: '{ novaPasta }'!");
                return novaPasta;
            }

            return string.Empty;
        }

        private static void MoverArquivos(string pasta)
        {
            string pastaAntiga = $@"{diretorio.ToString()}\PastaAntiga";
            Console.WriteLine($"Movendo arquivos de '{ pastaAntiga }' para '{ pasta }'...");
            if (!Directory.Exists(pasta))
            {
                Directory.CreateDirectory(pasta);
            }
            foreach (var srcPath in Directory.GetFiles(pastaAntiga))
            {
                File.Copy(srcPath, srcPath.Replace(pastaAntiga, pasta), true);
                File.Delete(srcPath);
            }
            Console.WriteLine("Arquivos movidos com sucesso!");
        }
    }
}
