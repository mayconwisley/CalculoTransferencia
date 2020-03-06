using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculoTransferencia
{
    class calculoTransferencia
    {

        decimal DownByte = 1, UpByte = 1, tamanhos = 1;
        decimal TamanhoDiferenca = 1, TempoTransferencia = 1;

        public decimal downByte(decimal downBits)
        {
            try
            {
                downBits *= 1024;
                DownByte = downBits / 8;

                return DownByte;
            }
            catch (Exception)
            {
                throw;
            }

        }
        public decimal upByte(decimal upBits)
        {
            try
            {
                upBits *= 1024;
                UpByte = upBits / 8;

                return UpByte;
            }
            catch (Exception)
            {
                throw;
            }

        }
        public decimal tamanhoDiferenca(decimal tamanho1, decimal tamanho2)
        {
            try
            {
                TamanhoDiferenca = tamanho1 - tamanho2;
                return TamanhoDiferenca;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public decimal tempoTranferenciaDown(int tipoArquivo, decimal tamanhoArquivo, decimal downByte)
        {
            try
            {
                //Tranferencia em MagaBytes por segundo

                switch (tipoArquivo)
                {

                    case 0: // Bits
                        TempoTransferencia = (tamanhoArquivo * 8) / downByte;
                        break;
                    case 1: //Byte
                        TempoTransferencia = (tamanhoArquivo / 1024) / downByte;
                        break;
                    case 2: //Kilobytes
                        TempoTransferencia = tamanhoArquivo / downByte;
                        break;
                    case 3: // Megabytes
                        TempoTransferencia = (tamanhoArquivo * 1024) / downByte;
                        break;
                    case 4: //Gigabytes
                        TempoTransferencia = ((tamanhoArquivo * 1024) * 1024) / downByte;
                        break;
                    case 5: //Terabytes
                        TempoTransferencia = (((tamanhoArquivo * 1024) * 1024) * 1024) / downByte;
                        break;
                    case 6: //Petabyte
                        TempoTransferencia = ((((tamanhoArquivo * 1024) * 1024) * 1024) * 1024) / downByte;
                        break;
                    case 7: //Exabyte
                        TempoTransferencia = (((((tamanhoArquivo * 1024) * 1024) * 1024) * 1024) * 1024) / downByte;
                        break;
                    case 8: //Zettabyte
                        TempoTransferencia = ((((((tamanhoArquivo * 1024) * 1024) * 1024) * 1024) * 1024) * 1024) / downByte;
                        break;
                    case 9: //Yottabyte
                        TempoTransferencia = (((((((tamanhoArquivo * 1024) * 1024) * 1024) * 1024) * 1024) * 1024) * 1024) / downByte;
                        break;
                }

                return TempoTransferencia;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public decimal tempoTranferenciaUp(int tipoArquivo, decimal tamanhoArquivo, decimal upByte)
        {
            try
            {
                //Tranferencia em MagaBytes por segundo

                switch (tipoArquivo)
                {

                    case 0: // Bits
                        TempoTransferencia = (tamanhoArquivo * 8) / upByte;
                        break;
                    case 1: //Byte
                        TempoTransferencia = (tamanhoArquivo / 1024) / upByte;
                        break;
                    case 2: //Kilobytes
                        TempoTransferencia = tamanhoArquivo / upByte;
                        break;
                    case 3: // Megabytes
                        TempoTransferencia = (tamanhoArquivo * 1024) / upByte;
                        break;
                    case 4: //Gigabytes
                        TempoTransferencia = ((tamanhoArquivo * 1024) * 1024) / upByte;
                        break;
                    case 5: //Terabytes
                        TempoTransferencia = (((tamanhoArquivo * 1024) * 1024) * 1024) / upByte;
                        break;
                    case 6: //Petabyte
                        TempoTransferencia = ((((tamanhoArquivo * 1024) * 1024) * 1024) * 1024) / upByte;
                        break;
                    case 7: //Exabyte
                        TempoTransferencia = (((((tamanhoArquivo * 1024) * 1024) * 1024) * 1024) * 1024) / upByte;
                        break;
                    case 8: //Zettabyte
                        TempoTransferencia = ((((((tamanhoArquivo * 1024) * 1024) * 1024) * 1024) * 1024) * 1024) / upByte;
                        break;
                    case 9: //Yottabyte
                        TempoTransferencia = (((((((tamanhoArquivo * 1024) * 1024) * 1024) * 1024) * 1024) * 1024) * 1024) / upByte;
                        break;
                }

                return TempoTransferencia;
            }
            catch (Exception)
            {

                throw;
            }
        }

    }
}
