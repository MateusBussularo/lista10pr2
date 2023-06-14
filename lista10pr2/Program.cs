using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista10pr2
{
    internal class Program
    {
        static void Exercicio1()
        {

            {
                int numeromaior, numeromenor, media, soma = 0;
                int[] vet;
                Console.WriteLine("Entre com o valor");
                int j = int.Parse(Console.ReadLine());
                vet = new int[j];
                numeromenor = vet[0];
                for (int i = 0; i < j; i++)
                {
                    Console.WriteLine("Qual o valor do vetor");
                    vet[i] = int.Parse(Console.ReadLine());
                }

                numeromenor = vet[0];
                for (int i = 0; i < j; i++)
                {
                    if (numeromenor > vet[i])
                    {
                        numeromenor = vet[i];
                    }
                }
                numeromaior = vet[0];
                for (int i = 0; i < j; i++)
                {
                    if (numeromaior < vet[i])
                    {
                        numeromaior = vet[i];
                    }

                }
                for (int i = j; i < j; i++)
                {
                    soma = +vet[i];
                }
                media = soma / j;
                Console.WriteLine("O maior número é {0}, o menor número é {1} e a média é {2}", numeromaior, numeromenor, media);
            }

        }

            public static void Exercicio2()
            {
                Console.WriteLine("here ex2 will be encoded");

                int[] vet2;
                int t, soma = 0, media;

                Console.WriteLine("entre com o tamanho");
                t = int.Parse(Console.ReadLine());
                vet2 = new int[t];

                for (int i = 0; i < t; i++)
                {

                    Console.WriteLine("qual o valor do vetor : ");
                    vet2[i] = int.Parse(Console.ReadLine());
                    if (vet2[i] == 0)
                    {
                        break;
                    }
                }



                for (int i = 0; i < t; i++)
                {

                    soma += vet2[i];
                }

                media = soma / t;

                for (int i = 0; i < t; i++)
                {
                    if (vet2[i] >= media)
                    {
                        Console.WriteLine("os numeros que são maiores ou iguais à media :" + vet2[i]);
                    }
                }
                Console.WriteLine("a media é :" + media);
            }



        public static void Exercicio3()
        {
            int t, soma = 0, media = 0;
            int[] vet3;

            Random rand = new Random();

            do
            {

                Console.WriteLine("Digite quantos numeros serao, tem que sair maior que 0");
                t = int.Parse(Console.ReadLine());
                vet3 = new int[t];

            } while (t <= 0);

            for (int i = 0; i < t; i++)

            {
                vet3[i] = rand.Next(1, 1000);
                soma = soma + vet3[i];
            }

            media = soma / t;

            for (int i = 0; i < t; i++)

            {
                if (vet3[i] >= media)
                {

                    Console.WriteLine("Os números maiores ou iguais a média " + vet3[i]);
                }
            }
        }
        public static void Exercicio4()
        {

            Console.WriteLine("here ex4 will be encoded");
            string[] vet2;
            int tee;

            Console.WriteLine("entre com o tamanho");
            tee = int.Parse(Console.ReadLine());
            vet2 = new string[tee];


            for (int i = 0; i < tee; i++)
            {

                Console.WriteLine("quais os nomes :");
                vet2[i] = Console.ReadLine();


            }
            for (int i = 0; i < tee; i--)
            {
                Console.WriteLine(" os nomes:" + vet2[i]);

            }
        }

                    public static void Exercicio5()

                    {
                        int te, somaa = 0, mediaa = 0, par = 0, impar = 0;
                        int[] vet5;
                        Random randi = new Random();

                        do
                        {
                            Console.WriteLine("Digite quantos numeros serao, tem que sair maior que 0");
                            te = int.Parse(Console.ReadLine());
                            vet5 = new int[te];

                        } while (te <= 0);

                        for (int i = 0; i < te; i++)
                        {
                            vet5[i] = randi.Next(1, 100);
                            if (vet5[i] % 2 == 0)
                            {
                                par += 1;
                            }
                            else
                            {
                                impar += 1;
                            }
                        }
                        Console.WriteLine("Sao {0} numeros pares e {1} numeros impares ", par, impar);
                    }

                    public static void Main(string[] args)

                    {

                        int opcao;
                        do
                        {
                            Console.WriteLine("=================MENU=================");
                            Console.WriteLine("Para sair - digite 0");
                            Console.WriteLine("Para executar o exercicio 1 - digite 1");
                            Console.WriteLine("Para executar o exercicio 2 - digite 2");
                            Console.WriteLine("Para executar o exercicio 3 - digite 3");
                            Console.WriteLine("Para executar o exercicio 4 - digite 4");
                            Console.WriteLine("Para executar o exercicio 5 - digite 5");
                            Console.WriteLine("======================================");

                            opcao = int.Parse(Console.ReadLine());

                            switch (opcao)
                            {
                                case 0:
                                    Console.WriteLine("Obrigado por utilizar o programa");

                                    break;
                                case 1:
                                    Exercicio1();

                                    break;
                                case 2:
                                    Exercicio2();

                                    break;
                                case 3:
                                    Exercicio3();

                                    break;
                                case 4:
                                    Exercicio4();

                                    break;

                                case 5:
                                    Exercicio5();

                                    break;
                            }
                        } while (opcao != 0);
                    }
                }

            }
        
    





