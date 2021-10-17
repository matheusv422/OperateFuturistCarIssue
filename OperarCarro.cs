using AtributosCarro;
using DirecaoEnum;
using InterfaceOperarCarro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperateFuturistCar
{
    public class OperarCarro : IOperarCarro
    {
        private  bool _MotorLigado;
        private  int _VelocidadeInicial;
        private  int _VelocidadeAtual;
        private  Direcao _Direcao;

        public OperarCarro()
        {

        }

        public OperarCarro(FuncionalidadesCarro atributo, Direcao direcao)
        {
            _MotorLigado = atributo.MotorLigado;
            _VelocidadeInicial = atributo.VelocidadeInicial;
            _VelocidadeAtual = atributo.VelocidadeAtual;
            _Direcao = direcao;
        }
        public void LigarMotor()
        {
            Console.WriteLine("Vamos Acelerar!");
     
        }

        public void DesligarMotor()
        {
            Console.WriteLine("Desligando motor em 3, 2, 1 ...");
        }

        public int Acelerar(int velocidadeDesejada)
        {
            _VelocidadeAtual += velocidadeDesejada;
            _VelocidadeInicial = velocidadeDesejada;
            
            return _VelocidadeAtual;
        }

        public int Frear(int velocidadeDesejada)
        {
            _VelocidadeAtual -= velocidadeDesejada;

            if(_VelocidadeAtual < 0)
            {
                Console.WriteLine("Iremos começar a dar ré no carro.");
            }

            return _VelocidadeAtual;

        }

        public void Buzinar()
        {
            Console.WriteLine("Beep! BEEP!"); 
        }

        public void Sinalizar(bool ligarSinal)
        {
            if (!ligarSinal)
            {
                Console.WriteLine("Por favor, sinalize antes de fazer uma curva ou mudar de pista.");
            }
        }

        public void Curva()
        {
            if (_Direcao.Equals(1))
            {
                Console.WriteLine("Fazendo curva pra direita.");
            }

            if (_Direcao.Equals(2))
            {
                Console.WriteLine("Fazendo curva pra esquerda.");
            }

          
        }

        public void MudarPista()
        {
            Console.WriteLine("Mudando de pista de acordo com a curva selecionada.");
        }
        
        public int GetRadarFrontal(double distanciaDoCarro, int velocidadeDoCarro)
        {
            distanciaDoCarro = 1;
            velocidadeDoCarro = _VelocidadeAtual;

            if(distanciaDoCarro == 1 && velocidadeDoCarro == _VelocidadeAtual)
            {
                Console.WriteLine("Há Veículos a frente, por favor desvie o caminho.");
            }

            else
            {
                Console.WriteLine("Caminho limpo, por favor continue seguindo em frente.");
            }

            return velocidadeDoCarro;
        }

        public int GetRadarTraseiro(double distanciaDoCarro, int velocidadeDoCarro)
        {
            if (distanciaDoCarro == 2 && velocidadeDoCarro == _VelocidadeInicial)
            {
                Console.WriteLine("Veículos se aproximando por trás, por favor desvie o caminho.");
            }

            else
            {
                Console.WriteLine("Nenhum veículo foi encontrado.");
            }

            return velocidadeDoCarro;
        }



    }
}
