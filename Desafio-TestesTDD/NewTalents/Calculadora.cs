using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewTalents
{
    public class Calculadora
    {
        private List<String> _listaHistorico;
        private String _data;

        public Calculadora(string data)
        {
            _listaHistorico = new List<String>();
            _data = data;
        }

        public int Somar(int val1, int val2)
        {
            var resultado = val1 + val2;
            _listaHistorico.Insert(0, $"{val1} + {val2} = {resultado} | Data: {_data}");
            return resultado;
        }

        public int Subtrair(int val1, int val2)
        {
            var resultado = val1 - val2;
            _listaHistorico.Insert(0, $"{val1} - {val2} = {resultado} | Data: {_data}");
            return resultado;
        }

        public int Multiplicar(int val1, int val2)
        {
            var resultado = val1 * val2;
            _listaHistorico.Insert(0, $"{val1} * {val2} = {resultado} | Data: {_data}");
            return resultado;
        }

        public int Dividir(int val1, int val2)
        {
            var resultado = val1 / val2;
            _listaHistorico.Insert(0, $"{val1} / {val2} = {resultado} | Data: {_data}");
            return resultado;
        }

        public List<String> Historico()
        {
            _listaHistorico.RemoveRange(3, _listaHistorico.Count - 3);
            return _listaHistorico;
        }
    }
}