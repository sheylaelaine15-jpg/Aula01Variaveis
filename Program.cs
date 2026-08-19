//ALT, SHIFT + F --> Identação
//Comentário teste comit Aula 03 
using System;
using System.Globalization;

namespace Aula01Variaveis
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Exibe o menu na tela
            Console.WriteLine("Observe o menu abaixo e digite o número referente a opção desejada:");
            Console.WriteLine("1 - Concatenar Palavras");
            Console.WriteLine("2 - Verificar Dia da Semana");
            Console.WriteLine("3 - Calcular Média");
            Console.WriteLine("4 - Calcular Tabuada");
            Console.WriteLine("5 - Detalhar Data");
            Console.WriteLine("6 - Calcular Desconto INSS");

            // Lê a opção escolhida pelo usuário
            int opcaoEscolhida = int.Parse(Console.ReadLine());

            // Direciona para o método correto
            switch (opcaoEscolhida)
            {
                case 1:
                    ConcatenarPalavras();
                    break;

                case 2:
                    VerificarAulaEtec();
                    break;

                case 3:
                    CalcularMedia();
                    break;

                case 4:
                    CalcularTabuada();
                    break;

                case 5:
                    DetalharData();
                    break;

                case 6:
                    CalcularDescontoINSS();
                    break;

                default:
                    Console.WriteLine("Opção inválida!");
                    break;
            }
        }

        // MÉTODO 1 - CONCATENAR PALAVRAS

        static void ConcatenarPalavras()
        {
            Console.Clear();

            Console.WriteLine("--- CONCATENAR PALAVRAS ---");

            Console.Write("Digite a primeira palavra: ");
            string p1 = Console.ReadLine();

            Console.Write("Digite a segunda palavra: ");
            string p2 = Console.ReadLine();

            Console.WriteLine($"\nResultado da união: {p1} {p2}");

            AguardarTecla();
        }

        // MÉTODO 2 - VERIFICAR AULA ETEC

        static void VerificarAulaEtec()
        {
            Console.Clear();

            Console.WriteLine("--- VERIFICAR DIA DA SEMANA ---");

            Console.Write("Digite o dia da semana (ex: Segunda, Terça...): ");
            string dia = Console.ReadLine().ToLower();

            if (dia == "sábado" || dia == "sabado" || dia == "domingo")
            {
                Console.WriteLine("Fim de semana! Sem aulas na Etec.");
            }
            else
            {
                Console.WriteLine("Dia letivo! Tem aula na Etec.");
            }

            AguardarTecla();
        }

        // MÉTODO 3 - CALCULAR MÉDIA

        static void CalcularMedia()
        {
            Console.Clear();

            Console.WriteLine("--- CALCULAR MÉDIA ---");

            Console.Write("Digite a primeira nota: ");
            double n1 = double.Parse(Console.ReadLine());

            Console.Write("Digite a segunda nota: ");
            double n2 = double.Parse(Console.ReadLine());

            double media = (n1 + n2) / 2;

            Console.WriteLine($"A média final é: {media:F2}");

            AguardarTecla();
        }

        // MÉTODO 4 - CALCULAR TABUADA
        

        static void CalcularTabuada()
        {
            Console.Clear();

            Console.WriteLine("--- CALCULAR TABUADA ---");

            Console.Write("Digite um número para a tabuada: ");
            int numero = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
            {
                int resultado = numero * i;

                Console.WriteLine($"{numero} x {i} = {resultado}");
            }

            AguardarTecla();
        }

        
        // MÉTODO 5 - DETALHAR DATA
        

        static void DetalharData()
        {
            Console.Clear();

            Console.WriteLine("--- DETALHAR DATA ---");

            Console.Write("Digite uma data (dd/MM/yyyy): ");
            DateTime data = DateTime.Parse(Console.ReadLine());

            // Mostra o dia da semana, dia e mês por extenso
            string diaSemana = data.ToString("dddd", new CultureInfo("pt-BR"));
            string mes = data.ToString("MMMM", new CultureInfo("pt-BR"));

            Console.WriteLine();
            Console.WriteLine($"Dia da semana: {diaSemana}");
            Console.WriteLine($"Dia: {data.Day}");
            Console.WriteLine($"Mês: {mes}");

            // Se for domingo, mostra a hora atual
            if (data.DayOfWeek == DayOfWeek.Sunday)
            {
                Console.WriteLine($"Hora atual: {DateTime.Now:HH:mm}");
            }

            AguardarTecla();
        }

        
        // MÉTODO 6 - CALCULAR DESCONTO INSS
        

        static void CalcularDescontoINSS()
        {
            Console.Clear();

            Console.WriteLine("--- CALCULAR DESCONTO INSS ---");

            Console.Write("Digite o valor do salário: R$ ");
            decimal salario = decimal.Parse(Console.ReadLine());

            decimal desconto;

            if (salario <= 1621.00m)
            {
                desconto = salario * 0.075m;
            }
            else if (salario <= 2902.84m)
            {
                desconto = (salario * 0.09m) - 24.32m;
            }
            else if (salario <= 4354.27m)
            {
                desconto = (salario * 0.12m) - 111.40m;
            }
            else
            {
                desconto = (salario * 0.14m) - 198.49m;

                // Limite máximo do desconto
                if (desconto > 988.09m)
                {
                    desconto = 988.09m;
                }
            }

            decimal salarioLiquido = salario - desconto;

            Console.WriteLine();
            Console.WriteLine($"Salário informado: R$ {salario:F2}");
            Console.WriteLine($"Desconto do INSS: R$ {desconto:F2}");
            Console.WriteLine($"Salário após o desconto: R$ {salarioLiquido:F2}");

            AguardarTecla();
        }

        
        // MÉTODO AUXILIAR
        

        static void AguardarTecla()
        {
            Console.WriteLine();
            Console.WriteLine("Pressione qualquer tecla para voltar...");
            Console.ReadKey();
        }
    }
}
