using PhoneNumbers;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace GatewareTeste
{
    class Exercicio2
    {
        private static DirectoryInfo diretorio = new DirectoryInfo(@"D:\Temp\Arquivos");
        public void BuscaArquivos()
        {
            try
            {
                List<string> listaArquivos = new List<string>();
                // lista arquivos do diretorio corrente
                foreach (FileInfo file in diretorio.GetFiles())
                {
                    using (StreamReader fs = file.OpenText())
                    {
                        string linha = string.Empty;
                        while ((linha = fs.ReadLine()) != null)
                        {
                            string telefone = string.Empty;
                            if (ValidarTelefone(linha))
                                listaArquivos.Add(file.Name);
                        }
                    }
                }
                listaArquivos.ForEach(i => Console.WriteLine("{0}", i));
            }
            catch
            {
                throw new InvalidOperationException("Falha ao ler arquivos.");
            }
        }

        private bool ValidarTelefone(string telNo)
        {
            // Valida telefones no padrão brasileiro
            PhoneNumber number;
            try
            {
                number = PhoneNumberUtil.GetInstance().Parse(telNo, "BR");
            }
            catch (NumberParseException e)
            {
                return false;
            }

            return true;
        }
    }
}
