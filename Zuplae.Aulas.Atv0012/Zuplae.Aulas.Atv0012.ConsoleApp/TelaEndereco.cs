using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zuplae.Aulas.Atv0012.Services;

namespace Zuplae.Aulas.Atv0012.ConsoleApp
{
    public class TelaEndereco
    {
        private EnderecoService service = new EnderecoService();
        public void ExecutarMenu()
        {
            Console.Clear();
            Console.WriteLine("===================== -MÓDULO DE ENDEREÇO- =====================");
            Console.WriteLine("\n\t1 - Cadastrar");
            Console.WriteLine("\t2 - Editar");
            Console.WriteLine("\t3 - Listar");
            Console.WriteLine("\t4 - Deletar");
            Console.WriteLine("\t5 - Voltar Ao Menu Principal");

            int opcao = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Opção escolhida: {opcao}");

            switch (opcao)
            {
                case 1:
                    this.Cadastrar();
                    break;
                case 2:
                    Console.WriteLine("-Editar Endereço");
                    break;
                case 3:
                    Console.WriteLine("-Listar Endereço");
                    break;
                case 4:
                    Console.WriteLine("-Deletar Endereço");
                    break;
                case 5:
                    Console.WriteLine("-Voltar Ao Menu Principal");
                    break;
                default:
                    Console.WriteLine("-Opção Inválida!");
                    break;
            }
        }
        public void Cadastrar()
        {
            Console.WriteLine("-Cadastrar novo Endereço");
            Console.WriteLine("Logradouro: ");
            string logradouro = Console.ReadLine();
            Console.WriteLine("Número: ");
            string numero = Console.ReadLine();
            Console.WriteLine("Complemento: ");
            string complemento = Console.ReadLine();
            Console.WriteLine("Bairro: ");
            string bairro = Console.ReadLine();
            Console.WriteLine("Cidade: ");
            string cidade = Console.ReadLine();
            Console.WriteLine("Estado: ");
            string estado = Console.ReadLine();
            Console.WriteLine("CEP: ");
            string cep = Console.ReadLine();
            service.Cadastrar(logradouro, numero, complemento, bairro, cidade, estado, cep);
        }
    }
}
