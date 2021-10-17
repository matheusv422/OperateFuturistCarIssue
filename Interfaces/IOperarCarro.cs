using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DirecaoEnum;

namespace InterfaceOperarCarro
{
   public interface IOperarCarro
    {
        public void LigarMotor();
        public void DesligarMotor();

        public int Acelerar(int velocidadeDesejada);
        public int Frear(int velocidadeDesejada);

        public void Buzinar();

        public void Sinalizar(bool ligarSinal);
        public void Curva();
        public void MudarPista();

        public int GetRadarFrontal(double distanciaDoCarro, int velocidadeDoCarro);
        public int GetRadarTraseiro(double distanciaDoCarro, int velocidadeDoCarro);






    }
}
