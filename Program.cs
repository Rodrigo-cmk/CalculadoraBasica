using System;

namespace Projeto1_Semestre
{
    class Program
    {
        static void Main(string[] args)
        {
            string opcao1, continuacao;

            BoasVindas();

            do
            {
                menu();
                opcao1 = opcao(Console.ReadLine());

                switch (opcao1)
                {
                    case "1":
                        adicao();
                        break;

                    case "2":
                        subtracao();
                        break;

                    case "3":
                        divisao();
                        break;

                    case "4":
                        mult();
                        break;

                    case "5":
                        exponenciacao();
                        break;

                    case "6":
                        radiciacao();
                        break;

                    case "7":
                        creditos();
                        break;

                    case "8":
                        sair();
                        break;

                    default:
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine("Atenção!! Digite uma opção válida.");
                        Console.ResetColor();
                        Console.WriteLine();
                        break;
                }

                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("Enter para continuar...");
                Console.ResetColor();

                continuacao = Console.ReadLine();
            } while (continuacao == "");

            if (continuacao != "")
            {
                Main(args);
            }
        }

        static void BoasVindas()
        {
            Console.Clear();
            DateTime agora = DateTime.Now;


            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("Olá!!");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write(" ----------_-_-----------");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($" {agora}");
            Console.ResetColor();
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("      ||");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write(" Calculadora Básica ");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("|| ");
            Console.ResetColor();
        }

        static void menu()
        {
            Console.WriteLine();
            Console.WriteLine(" ________________________________");
            Console.Write("|");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("--> ");
            Console.ResetColor();
            Console.WriteLine("Selecione a opção desejada: ");
            Console.WriteLine("|");

            Console.Write("|>");
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.Write("1-");
            Console.ResetColor();
            Console.WriteLine(" Adição.");

            Console.Write("|>");
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.Write("2-");
            Console.ResetColor();
            Console.WriteLine(" Subtração.");

            Console.Write("|>");
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.Write("3-");
            Console.ResetColor();
            Console.WriteLine(" Divisão.");

            Console.Write("|>");
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.Write("4-");
            Console.ResetColor();
            Console.WriteLine(" Multiplicação.");

            Console.Write("|>");
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.Write("5-");
            Console.ResetColor();
            Console.WriteLine(" Exponenciação.");

            Console.Write("|>");
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.Write("6-");
            Console.ResetColor();
            Console.WriteLine(" Radiciação (Raíz Quadrada).");

            Console.WriteLine("|");

            Console.Write("|>");
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.Write("7-");
            Console.ResetColor();
            Console.WriteLine(" Créditos.");

            Console.Write("|>");
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.Write("8-");
            Console.ResetColor();
            Console.WriteLine(" Sair.");

            Console.WriteLine();

            Console.Write("Opção (Por Número): ");
        }

        static string opcao(string opcaoEscolhida)
        {
            return opcaoEscolhida;
        }

        static void adicao()
        {
            try
            {
                double valor1;
                double valor2;
                double resul;
                string opcao2;

                Console.Clear();
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine(" _____________________________");
                Console.WriteLine("|-- Bem vindo a Adição --");
                Console.ResetColor();
                Console.WriteLine("|");


                do
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.Write("|-");
                    Console.ResetColor();
                    Console.Write(" Digite a Parcela 1: ");
                    valor1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("|");

                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.Write("|-");
                    Console.ResetColor();
                    Console.Write(" Digite a Parcela 2: ");
                    valor2 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("|");

                    resul = valor1 + valor2;
                    Console.WriteLine("|");

                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.Write("|--> ");
                    Console.ResetColor();
                    Console.Beep();
                    Console.WriteLine($"{valor1} + {valor2} = {resul}.");
                    Console.Beep();
                    Console.WriteLine();

                    Console.Write("Continuar? (");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("'Sim' ");
                    Console.ResetColor();
                    Console.Write("para continuar / ");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("'Qualquer tecla' ");
                    Console.ResetColor();
                    Console.Write("para sair): ");

                    opcao2 = Console.ReadLine().ToUpper();
                    Console.WriteLine();
                } while (opcao2 == "SIM");
            }

            catch (OverflowException ex)
            {
                Console.WriteLine();
                Console.Write("Mensagem: ");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("O valor de entrada ultrapassou o valor de números suportado.");
                Console.ResetColor();

                Console.Write("Tipo: ");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write($"{ex.GetType()}");
                Console.ResetColor();
                Console.WriteLine();
                Console.WriteLine();
            }

            catch (FormatException ex)
            {
                Console.WriteLine();
                Console.Write("Mensagem: ");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("O valor de entrada não estava no formato correto.");
                Console.ResetColor();

                Console.Write("Tipo: ");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write($"{ex.GetType()}");
                Console.ResetColor();
                Console.WriteLine();
                Console.WriteLine();
            }
        }

        static void subtracao()
        {
            try
            {
                double valor1;
                double valor2;
                double resul;
                string opcao2;

                Console.Clear();
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.WriteLine(" _____________________________");
                Console.WriteLine("|-- Bem vindo a Subtração --");
                Console.ResetColor();
                Console.WriteLine("|");

                do
                {
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    Console.Write("|-");
                    Console.ResetColor();
                    Console.Write(" Digite o Minuendo (Primeiro Valor): ");
                    valor1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("|");

                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    Console.Write("|-");
                    Console.ResetColor();
                    Console.Write(" Digite o Subtraendo (Segundo Valor): ");
                    valor2 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("|");

                    resul = valor1 - valor2;
                    Console.WriteLine("|");

                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    Console.Write("|--> ");
                    Console.ResetColor();
                    Console.Beep();
                    Console.WriteLine($"{valor1} - {valor2} = {resul}.");
                    Console.Beep();
                    Console.WriteLine();

                    Console.Write("Continuar? (");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("'Sim' ");
                    Console.ResetColor();
                    Console.Write("para continuar / ");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("'Qualquer tecla' ");
                    Console.ResetColor();
                    Console.Write("para sair): ");

                    opcao2 = Console.ReadLine().ToUpper();
                    Console.WriteLine();
                } while (opcao2 == "SIM");
            }

            catch (OverflowException ex)
            {
                Console.WriteLine();
                Console.Write("Mensagem: ");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("O valor de entrada ultrapassou o valor de números suportado.");
                Console.ResetColor();

                Console.Write("Tipo: ");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write($"{ex.GetType()}");
                Console.ResetColor();
                Console.WriteLine();
                Console.WriteLine();
            }

            catch (FormatException ex)
            {
                Console.WriteLine();
                Console.Write("Mensagem: ");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("O valor de entrada não estava no formato correto.");
                Console.ResetColor();

                Console.Write("Tipo: ");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write($"{ex.GetType()}");
                Console.ResetColor();
                Console.WriteLine();
                Console.WriteLine();
            }
        }

        static void divisao()
        {
            try
            {
                double valor1;
                double valor2;
                double resul;
                string opcao2;

                Console.Clear();
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine(" _____________________________");
                Console.Write("|");
                Console.ResetColor();
                Console.WriteLine("-- Bem vindo a Divisão --");
                Console.WriteLine("|");

                do
                {
                    do
                    {
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.Write("|-");
                        Console.ResetColor();
                        Console.Write(" Digite o Dividendo (Primeiro Valor): ");
                        valor1 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("|");

                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.Write("|-");
                        Console.ResetColor();
                        Console.Write(" Digite o Divisor (Segundo Valor): ");
                        valor2 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("|");

                        if (valor2 == 0)
                        {
                            Console.WriteLine();
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("Atenção!! Não é possível dividir por zero.");
                            Console.ResetColor();
                            Console.WriteLine();
                        }
                    } while (valor2 == 0);

                    resul = valor1 / valor2;
                    Console.WriteLine("|");

                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.Write("|--> ");
                    Console.ResetColor();
                    Console.Beep();
                    Console.WriteLine($"{valor1} / {valor2} = {resul}.");
                    Console.Beep();
                    Console.WriteLine();

                    Console.Write("Continuar? (");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("'Sim' ");
                    Console.ResetColor();
                    Console.Write("para continuar / ");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("'Qualquer tecla' ");
                    Console.ResetColor();
                    Console.Write("para sair): ");

                    opcao2 = Console.ReadLine().ToUpper();
                    Console.WriteLine();
                } while (opcao2 == "SIM");
            }

            catch (OverflowException ex)
            {
                Console.WriteLine();
                Console.Write("Mensagem: ");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("O valor de entrada ultrapassou o valor de números suportado.");
                Console.ResetColor();

                Console.Write("Tipo: ");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write($"{ex.GetType()}");
                Console.ResetColor();
                Console.WriteLine();
                Console.WriteLine();
            }

            catch (FormatException ex)
            {
                Console.WriteLine();
                Console.Write("Mensagem: ");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("O valor de entrada não estava no formato correto.");
                Console.ResetColor();

                Console.Write("Tipo: ");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write($"{ex.GetType()}");
                Console.ResetColor();
                Console.WriteLine();
                Console.WriteLine();
            }
        }

        static void mult()
        {
            try
            {
                double valor1;
                double valor2;
                double resul;
                string opcao2;

                Console.Clear();
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(" _____________________________");
                Console.WriteLine("|-- Bem vindo a Multiplicação --");
                Console.ResetColor();
                Console.WriteLine("|");

                do
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("|-");
                    Console.ResetColor();
                    Console.Write(" Digite o Multiplicador (Primeiro Valor): ");
                    valor1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("|");

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("|-");
                    Console.ResetColor();
                    Console.Write(" Digite o multiplicando (Segundo Valor): ");
                    valor2 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("|");

                    resul = valor1 * valor2;
                    Console.WriteLine("|");

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("|--> ");
                    Console.ResetColor();
                    Console.Beep();
                    Console.WriteLine($"{valor1} x {valor2} = {resul}.");
                    Console.Beep();
                    Console.WriteLine();

                    Console.Write("Continuar? (");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("'Sim' ");
                    Console.ResetColor();
                    Console.Write("para continuar / ");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("'Qualquer tecla' ");
                    Console.ResetColor();
                    Console.Write("para sair): ");

                    opcao2 = Console.ReadLine().ToUpper();
                    Console.WriteLine();
                } while (opcao2 == "SIM");
            }

            catch (OverflowException ex)
            {
                Console.WriteLine();
                Console.Write("Mensagem: ");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("O valor de entrada ultrapassou o valor de números suportado.");
                Console.ResetColor();

                Console.Write("Tipo: ");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write($"{ex.GetType()}");
                Console.ResetColor();
                Console.WriteLine();
                Console.WriteLine();
            }

            catch (FormatException ex)
            {
                Console.WriteLine();
                Console.Write("Mensagem: ");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("O valor de entrada não estava no formato correto.");
                Console.ResetColor();

                Console.Write("Tipo: ");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write($"{ex.GetType()}");
                Console.ResetColor();
                Console.WriteLine();
                Console.WriteLine();
            }
        }

        static void exponenciacao()
        {
            try
            {
                double valor1;
                double valor2;
                double resul;
                string opcao2;

                Console.Clear();
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine(" _____________________________");
                Console.Write("|");
                Console.ResetColor();
                Console.WriteLine("-- Bem vindo a Exponenciação --");
                Console.WriteLine("|");

                do
                {
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.Write("|-");
                    Console.ResetColor();
                    Console.Write(" Digite a Base: ");
                    valor1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("|");

                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.Write("|-");
                    Console.ResetColor();
                    Console.Write(" Digite o Expoente: ");
                    valor2 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("|");

                    resul = Math.Pow(valor1, valor2);
                    Console.WriteLine("|");

                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.Write("|--> ");
                    Console.ResetColor();
                    Console.Beep();
                    Console.WriteLine($"Base: {valor1}, Expoente: {valor2} = {resul}.");
                    Console.Beep();
                    Console.WriteLine();

                    Console.Write("Continuar? (");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("'Sim' ");
                    Console.ResetColor();
                    Console.Write("para continuar / ");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("'Qualquer tecla' ");
                    Console.ResetColor();
                    Console.Write("para sair): ");

                    opcao2 = Console.ReadLine().ToUpper();
                    Console.WriteLine();
                } while (opcao2 == "SIM");
            }

            catch (OverflowException ex)
            {
                Console.WriteLine();
                Console.Write("Mensagem: ");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("O valor de entrada ultrapassou o valor de números suportado.");
                Console.ResetColor();

                Console.Write("Tipo: ");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write($"{ex.GetType()}");
                Console.ResetColor();
                Console.WriteLine();
                Console.WriteLine();
            }

            catch (FormatException ex)
            {
                Console.WriteLine();
                Console.Write("Mensagem: ");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("O valor de entrada não estava no formato correto.");
                Console.ResetColor();

                Console.Write("Tipo: ");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write($"{ex.GetType()}");
                Console.ResetColor();
                Console.WriteLine();
                Console.WriteLine();
            }
        }

        static void radiciacao()
        {
            try
            {
                double valor1;
                double resul;
                string opcao2;

                Console.Clear();
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine(" ______________________________________________");
                Console.WriteLine("|-- Bem vindo a Radiciação (Raíz Quadrada)--");
                Console.ResetColor();
                Console.WriteLine("|");

                do
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write("|-");
                    Console.ResetColor();
                    Console.Write(" Digite o Radicando: ");
                    valor1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("|");

                    resul = Math.Sqrt(valor1);
                    Console.WriteLine("|");

                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write("|--> ");
                    Console.ResetColor();
                    Console.Beep();
                    Console.WriteLine($"Raíz Quadrada de {valor1} é igual a {resul}.");
                    Console.Beep();
                    Console.WriteLine();

                    if (valor1 < 0)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine("Não existe raíz de número negativo.");
                        Console.ResetColor();
                        Console.WriteLine();
                    }

                    Console.Write("Continuar? (");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("'Sim' ");
                    Console.ResetColor();
                    Console.Write("para continuar / ");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("'Qualquer tecla' ");
                    Console.ResetColor();
                    Console.Write("para sair): ");

                    opcao2 = Console.ReadLine().ToUpper();
                    Console.WriteLine();
                } while (opcao2 == "SIM");
            }

            catch (OverflowException ex)
            {
                Console.WriteLine();
                Console.Write("Mensagem: ");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("O valor de entrada ultrapassou o valor de números suportado.");
                Console.ResetColor();

                Console.Write("Tipo: ");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write($"{ex.GetType()}");
                Console.ResetColor();
                Console.WriteLine();
                Console.WriteLine();
            }

            catch (FormatException ex)
            {
                Console.WriteLine();
                Console.Write("Mensagem: ");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("O valor de entrada não estava no formato correto.");
                Console.ResetColor();

                Console.Write("Tipo: ");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write($"{ex.GetType()}");
                Console.ResetColor();
                Console.WriteLine();
                Console.WriteLine();
            }
        }

        static void creditos()
        {

            Console.Clear();
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(" __________________");
            Console.Write("|");
            Console.ResetColor();
            Console.WriteLine("-- Créditos --");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("|");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("|-");
            Console.ResetColor();
            Console.WriteLine(" Desenvolvedor: Rodrigo Alves. ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("|-");
            Console.ResetColor();
            Console.WriteLine(" Orientadores educacionais: Profº Ermogenes Palácio & Profº Diego Neri.");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("|-");
            Console.ResetColor();
            Console.WriteLine(" Etec Adolpho Berezin. ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("|-");
            Console.ResetColor();
            Console.Write(" Projeto desenvolvido para fins acadêmicos, ");
            Console.WriteLine("programa de fechamento do primeiro módulo do curso de Técnico em Informática.");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("|");
            Console.WriteLine();
            Console.ResetColor();
        }

        static void sair()
        {
            string opcao;

            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("--> Deseja sair?");
            Console.ResetColor();
            Console.Write(" (");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("'Sim' ");
            Console.ResetColor();
            Console.Write("para fechar / ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("'Qualquer tecla' ");
            Console.ResetColor();
            Console.Write("para voltar ao menu): ");

            opcao = Convert.ToString(Console.ReadLine()).ToUpper();

            if (opcao == "SIM")
            {
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Beep();
                Console.WriteLine("** Obrigado, e até mais!! **");
                Console.ResetColor();
                Environment.Exit(-1);
            }
        }

    }
}
