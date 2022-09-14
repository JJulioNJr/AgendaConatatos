using System;
using System.Collections.Generic;
using System.ComponentModel.Design;

namespace ProjAgendaCelular {
    internal class Program {

        static int Menu(int op) {
            Console.WriteLine("\n");
            Console.WriteLine("1 - Adicionar Contato");
            Console.WriteLine("2 - Remover Contato");
            Console.WriteLine("3 - Buscar Contato");
            Console.WriteLine("4 - Editar Contato");
            Console.WriteLine("5 - Imprimir Contatos");
            Console.WriteLine("6 - Imprimir Contato Unico");
            Console.Write("\nDigite: ");
            Console.WriteLine("\n");
            return op = int.Parse(Console.ReadLine());
        }

        static Pessoa AdicionarContato() {

            Pessoa pessoa = new();
            Console.Write("\nNome: ");
            string nome = Console.ReadLine();
            Console.Write("Telefone: ");
            string telefone = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Aniversario: ");
            DateTime aniversario = DateTime.Parse(Console.ReadLine());

            pessoa.CadastrarPessoa(nome, telefone, email, aniversario);
            //list.Add(pessoa);
            //Console.WriteLine(pessoa.ToString());
   
            return pessoa;
        }
       
        static void RemoverContato(List<Pessoa>agendaContatos) {
           
            Console.WriteLine("Informe o Nome: ");
            string nome = Console.ReadLine();
            Pessoa p = BuscarContato(agendaContatos,nome);
            agendaContatos.Remove(p);
        
        }
        static Pessoa BuscarContato(List<Pessoa>agendaContato,string nome ) {
            //Console.Write("Informe o Nome para Buscar: ");
           // string nome=Console.ReadLine();
            bool achei =false;
            Pessoa p = new();
            foreach (Pessoa item in agendaContato) {
                if (item.Nome == nome) {
                    achei = true;
                    //  Console.WriteLine(item.ToString());
                    // break; // Mesmo Nome
                       p = item;
                    return p;
                }
            }
            if (achei) {
                //Console.WriteLine(nome + "Não Encontrado");
                Console.WriteLine("Pessoa não Encontrada!");
                
            }
            return null;

        }
        static void EditarContato(List<Pessoa> agendaContato) {

            Console.Write("Informe o Nome para Buscar: ");
            string nome = Console.ReadLine();
            Pessoa p = BuscarContato(agendaContato, nome);
            Console.WriteLine("\n");
            Console.WriteLine("1 - Editar Nome");
            Console.WriteLine("2 - Editar Email");
            Console.WriteLine("3 - Editar Telefone");
            Console.WriteLine("4 - Editar Aniversario");
            Console.WriteLine("\n");
            int op = int.Parse(Console.ReadLine());

            switch (op) {

                case 1:
                    Console.WriteLine("Informe o Novo Nome: ");
                    nome = Console.ReadLine();
                    p.Nome = nome;
                    Console.ReadKey();
                    break;

                case 2:
                    Console.WriteLine("Informe o Novo Email: ");
                    string email = Console.ReadLine();
                    p.Email = email;
                    Console.ReadKey();
                    break;
                case 3:
                    Console.WriteLine("Informe o Novo Telefone: ");
                    string Tel = Console.ReadLine();
                    p.Telefone = Tel;
                    Console.ReadKey();
                    break;
                case 4:
                    Console.WriteLine("Informe a Data Aniversario: ");
                    DateTime aniver = DateTime.Parse(Console.ReadLine());
                    p.Aniversario = aniver;
                    Console.ReadKey();
                    break;
                default:
                    break;
            }
        }

        static void ImprimirContato(Pessoa ps) {
            
            Console.WriteLine("\n");
            Console.WriteLine(ps.ToString());
            Console.WriteLine("\n");

        }
        static void ImprimirContatos(List<Pessoa>agendaContatos) {

            foreach (Pessoa item in agendaContatos) {
                Console.WriteLine("\n");
                Console.WriteLine(item.ToString());
                Console.WriteLine("\n");
                //ImprimirContato(item);
            }
          //  Console.WriteLine(pessoa.ToString());
        }

        static void Main(string[] args) {
           //lista Generica
            List<Pessoa> agendaContatos = new ();
            Pessoa pessoa = new();
            int op = 0;
            Console.WriteLine("\nAgenda de Contatos\n");
            do {
                op = Menu(op);
               
                switch (op) {
                    case 1:
                        //pessoa = AdicionarContato(agendaContatos);
                        pessoa = AdicionarContato();
                        agendaContatos.Add(pessoa);
                        break;
                    case 2:
                        RemoverContato(agendaContatos);
                        break;
                    case 3:
                        Console.WriteLine("Informe o Nome: ");
                        string nome = Console.ReadLine();
                        BuscarContato(agendaContatos,nome);
                        break;
                    case 4:
                        EditarContato(agendaContatos);
                        break;
                    case 5:
                        ImprimirContatos(agendaContatos);
                       
                        break;
                    case 6:
                        Console.WriteLine("Informe o Nome: ");
                        nome = Console.ReadLine();
                        Pessoa b= BuscarContato(agendaContatos,nome);
                        //ImprimirContato(BuscarContato(agendaContatos, nome));
                        ImprimirContato(b);
                      
                        break;
                    case 0:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Opção Inválida!");
                        break;
                }
            
            } while (op!=0);
        }
    }
}
