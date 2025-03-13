//desafio: Escrever um programa que funcione como uma calculadora, que pode realizar as 4 operações básicas, além de calcular raiz quadrada e potências. O usuario deve entrar com dois números e um simbolo que represente a operação a ser feita.

namespace Calculadora
{
    public class Calculadora
    {
        public double Somar(double a, double b) => a + b;
        public double Subtrair(double a, double b) => a - b;
        public double Multiplicar(double a, double b) => a * b;

        public double Dividir(double a, double b)
        {
            if (b == 0)
            {
                throw new DivideByZeroException("Erro: Divisão por zero não permitida.");
            }
            return a / b;
        }

        public double Potencia(double baseNum, double expoente) => Math.Pow(baseNum, expoente);

        public double RaizQuadrada(double num)
        {
            if (num < 0)
            {
                throw new ArgumentException("Erro: Não é possível calcular a raiz quadrada de um número negativo.");
            }
            return Math.Sqrt(num);
        }
    }
}
