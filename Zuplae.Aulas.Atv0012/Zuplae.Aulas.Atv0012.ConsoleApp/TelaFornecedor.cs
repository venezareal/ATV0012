using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zuplae.Aulas.Atv0012.Models;

namespace Zuplae.Aulas.Atv0012.ConsoleApp
{
    public class TelaFornecedor
    {
        private FornecedorService service = new FornecedorService();
        public void ExecutarMenu()
        {
            Console.Clear();
            Console.WriteLine("===================== -MÓDULO DE FORNECEDOR- =====================");
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
        private void Cadastrar()
        {
            Console.WriteLine("-Cadastrar novo Fornecedor");
            Console.WriteLine("Digite a Razão Social: ");
            string razaoSocial = Console.ReadLine();
            Console.WriteLine("Digite o CNPJ: ");
            string cnpj = Console.ReadLine();
            TelaEndereco.Cadastrar();
            service.Cadastrar(razaoSocial, cnpj);
        }
    }
}

