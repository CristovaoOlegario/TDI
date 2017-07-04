using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2_2
{
    class Program
    {
        static void Main(String[] args)
        {
			Console.WriteLine("Programadores: Andrew de Oliveira Duchini\n\tCrist�v�o Oleg�rio\n\n");
            int num_formas = 0;
            string tipo_de_forma = "";
            Console.WriteLine("Quantas formas deseja criar?");
            try
            {
                num_formas = Convert.ToInt32(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Formato errado");
            }
            catch (NotFiniteNumberException)
            {
                Console.WriteLine("inv�lido");
            }

            IFormas[] vet = new IFormas[num_formas];

            for (int i = 0; i < num_formas; i++)
            {
                Console.WriteLine("Deseja criar um c�rculo [c], quadrado[q] ou retangulo[r]?");
                tipo_de_forma = Console.ReadLine();

                switch (tipo_de_forma)
                {
                    case "c":
                        int r;
                        Console.WriteLine("Digite o valor do raio");
                        r = Convert.ToInt32(Console.ReadLine());
                        vet[i] = new circulo(r);
                        break;
                    case "q":
                        int l;
                        Console.WriteLine("Digite o lado do quadrado");
                        l = Convert.ToInt32(Console.ReadLine());
                        vet[i] = new quadrado(l);
                        break;
                    case "r":
                        int l1, l2;
                        Console.WriteLine("Digite o primeiro lado do retangulo");
                        l1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Digite o outro lado");
                        l2 = Convert.ToInt32(Console.ReadLine());
                        vet[i] = new retangulos(l1, l2);
                        break;
                }
            }

            for (int j = 0; j < vet.Length; j++)
            {
                vet[j].imprime();
                Console.WriteLine();
            }
            Console.ReadKey();
        }





        public interface IFormas
        {
            double cal_Perimetro();
            double cal_area();
            void imprime();
        }

        public class retangulos : IFormas
        {

            int l1, l2;

            public retangulos(int l1, int l2)
            {
                this.l1 = l1;
                this.l2 = l2;
            }
            public double cal_area()
            {
                return (l1 * l2);
            }
            public double cal_Perimetro()
            {
                return ((2 * l1) + (2 * l2));
            }
            public void imprime()
            {
                Console.WriteLine("Tipo de Forma : Ret�ngulo\nTamanho dos lados : " + l1 + " e " + l2 + "\nPer�metro : " + cal_Perimetro() + "\n�rea : " + cal_area() + "");
            }
        }

        public class quadrado : IFormas
        {
            int lado;
            public quadrado(int l)
            {
                this.lado = l;
            }
            public double cal_area()
            {
                return (Math.Pow(lado, 2));
            }
            public double cal_Perimetro()
            {
                return (lado * 4);
            }
            public void imprime()
            {
                Console.WriteLine("Tipo de Forma : Quadrado\nTamanho dos lado : " + lado + "\nPer�metro : " + cal_Perimetro() + "\n�rea : " + cal_area() + "");
            }
        }

        public class circulo : IFormas
        {
            int raio;

            public circulo(int raio)
            {
                this.raio = raio;
            }
            public double cal_area()
            {
                return (Math.PI * (Math.Pow(raio, 2)));
            }
            public double cal_Perimetro()
            {
                return (2 * Math.PI * raio);
            }
            public void imprime()
            {
                Console.WriteLine("Tipo de Forma : C�rculo\nTamanho dos lado : " + raio + "\nPer�metro : " + cal_Perimetro() + "\n�rea : " + cal_area() + "");
            }
        }
    }
}