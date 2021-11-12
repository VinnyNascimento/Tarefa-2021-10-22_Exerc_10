using System;

namespace Exerc_10
{
    class Program
    {
        static void Main(string[] args)
        {
            #region declarações & instâncias
            Calculo s;
            s = new Calculo();
            #endregion

            #region Introducao
            Console.Write("Descubra a Área de um Retângulo");
            Console.ReadLine();
            #endregion

            #region entrada
            Console.Write("Informe o valor da Base do Retangulo: ");
            s.setNum1(int.Parse(Console.ReadLine()));

            Console.Write("Informe o valor da Altura do Retangulo: ");
            s.setNum2(int.Parse(Console.ReadLine()));
            #endregion

            #region processo
            s.calcular();
            #endregion

            #region saída
            Console.WriteLine("A base do retângulo {0} com a Altura do retângulo {1}, da uma área de: {2}", s.getNum1(), s.getNum2(), s.getResultado());
            #endregion
        }
    }
}