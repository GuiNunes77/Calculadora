using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraApp
{
    public class Calculadora
    {
        private List<string> _historico;
        private string data;

        public Calculadora(string data)
        {
            _historico = new List<string>();
            this.data = data;
        }
        public int Somar(int valor1, int valor2)
        {
            int resultado = (valor1 + valor2);
            _historico.Insert(0, "Resultado: " + resultado + " - data: " + data);
            return resultado;
        }
        public int Subtrair(int valor1, int valor2)
        {
            int resultado = (valor1 - valor2);
            _historico.Insert(0, "Resultado: " + resultado + " - data: " + data);
            return resultado;
        }
        public int Multiplicar(int valor1, int valor2)
        {
            int resultado = (valor1 * valor2);
            _historico.Insert(0, "Resultado: " + resultado + " - data: " + data);
            return resultado;
        }
        public int Dividir(int valor1, int valor2)
        {
            int resultado = (valor1 / valor2);
            _historico.Insert(0, "Resultado: " + resultado + " - data: " + data);
            return resultado;
        }

        public List<string> Historico()
        {
            _historico.RemoveRange(3, _historico.Count - 3);
            return _historico;
        }
    }
}
