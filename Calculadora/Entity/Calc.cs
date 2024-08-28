using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace Calculadora.Entity {
    public class Calc {
        
        private List<double> _last3Results = new();
        private List<double> AttLastResults(double value) {
            // sempre insere o novo resultado na primeira posição da lista
            // se a lista tiver 3 elementos, remove o ultimo
            
            int x = _last3Results.Count;

            switch (x) {
                case 0:
                    _last3Results.Insert(0, value);
                    break;
                case 1:
                    _last3Results.Insert(0, value);
                    break;
                case 2:
                    _last3Results.Insert(0, value);
                    break;
                case 3:
                    _last3Results.RemoveAt(2);
                    _last3Results.Insert(0, value);
                    break;
            }
                
            return _last3Results;
        }


        public List<double> Last3Results {
            // retorna os ultimos 3 resultados
            get { return _last3Results; }
        }

        public double Sum(double a, double b) {
            double result = a + b;
            
            // atualiza a lista de ultimos resultados
            _last3Results = AttLastResults(result);
            return result;
        }

        public double Subtract(double a, double b) {
            double result = a - b;
            
            // atualiza a lista de ultimos resultados
            _last3Results = AttLastResults(result);
            return result;
        }

        public double Multiply(double a, double b) {
            double result = a * b; 
            
            // atualiza a lista de ultimos resultados
            _last3Results = AttLastResults(result);
            return result;
        }

        public double Divide(double a, double b) {
            if (b == 0) // verifica se o divisor é zero
                throw new DivideByZeroException("Não é possível dividir por zero");

            double result = a / b; 
            
            // atualiza a lista de ultimos resultados
            _last3Results = AttLastResults(result);
            return result;
        }
    }
}