using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculoTransferencia
{
    class calculoTempo
    {
        /*Downloads*/
        public decimal minutosDown(decimal tempoTransferencia)
        {
            return tempoTransferencia / 60;
        }
        public decimal horasDown(decimal tempoTransferencia)
        {
            return tempoTransferencia / 60 / 60;
        }
        public decimal diasDown(decimal tempoTransferencia)
        {
            return tempoTransferencia / 60 / 60 / 24;
        }

        /*Uploads*/
        public decimal minutosUp(decimal tempoTransferencia)
        {
            return tempoTransferencia / 60;
        }
        public decimal horasUp(decimal tempoTransferencia)
        {
            return tempoTransferencia / 60 / 60;
        }
        public decimal diasUp(decimal tempoTransferencia)
        {
            return tempoTransferencia / 60 / 60 / 24;
        }

        /*Porcentagem*/
        public decimal porcentagem(decimal tamanho1, decimal tamanho2)
        {
            return (tamanho2 * 100) / tamanho1;
        }

    }
}
