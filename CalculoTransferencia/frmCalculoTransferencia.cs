using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculoTransferencia
{
    public partial class frmCalculoTransferencia : Form
    {
        public frmCalculoTransferencia()
        {
            InitializeComponent();
        }

        calculoTransferencia calculo;
        decimal downBits = 1, upBits = 1, downByte = 1, upByte = 1;
        decimal tamanho1 = 1, tamanho2 = 1, tamahoArquivo = 1, tempoTransferenciaDown = 1, tempoTransferenciaUp = 1;
        decimal horasDown = 1, minutosDown = 1, diasDown = 1;
        decimal horasUp = 1, minutosUp = 1, diasUp = 1;
        decimal porcentagem = 0;
        int tipoArquivo;

        private void txtBiteUp_Enter(object sender, EventArgs e)
        {
            if (txtBiteUp.Text == "1")
            {
                txtBiteUp.Text = "";
            }
        }

        private void txtArquivoTamanho1_Enter(object sender, EventArgs e)
        {
            if (txtArquivoTamanho1.Text == "1")
            {
                txtArquivoTamanho1.Text = "";
            }
        }

        private void txtArquivoTamanho2_Enter(object sender, EventArgs e)
        {
            if (txtArquivoTamanho2.Text == "0")
            {
                txtArquivoTamanho2.Text = "";
            }
        }

        private void cbxTipoArquivo1_Leave(object sender, EventArgs e)
        {
            cbxTipoArquivo1_SelectedIndexChanged(e, e);
        }

        private void txtBiteDown_Enter(object sender, EventArgs e)
        {
            if (txtBiteDown.Text == "1")
            {
                txtBiteDown.Text = "";
            }
        }

        private void txtBiteDown_Leave(object sender, EventArgs e)
        {
            if (txtBiteDown.Text == "")
            {
                txtBiteDown.Text = "1";
            }
            calcByte();
            calcTempo();
        }

        private void txtBiteUp_Leave(object sender, EventArgs e)
        {
            if (txtBiteUp.Text == "")
            {
                txtBiteUp.Text = "1";
            }
            calcByte();
            calcTempo();
        }

        private void txtArquivoTamanho1_Leave(object sender, EventArgs e)
        {
            if (txtArquivoTamanho1.Text == "")
            {
                txtArquivoTamanho1.Text = "1";
            }
            calcTamanho();
        }

        private void txtArquivoTamanho2_Leave(object sender, EventArgs e)
        {
            if (txtArquivoTamanho2.Text == "")
            {
                txtArquivoTamanho2.Text = "0";
            }

            calcTamanho();
            calcTempo();
        }



        private void cbxTipoArquivo1_SelectedIndexChanged(object sender, EventArgs e)
        {
            calcTempo();
        }

        private void frmCalculoTransferencia_Load(object sender, EventArgs e)
        {
            cbxTipoArquivo1.SelectedIndex = 3;
        }

        private void calcTamanho()
        {
            try
            {
                calculo = new calculoTransferencia();
                tamanho1 = decimal.Parse(txtArquivoTamanho1.Text);
                tamanho2 = decimal.Parse(txtArquivoTamanho2.Text);
                tamahoArquivo = calculo.tamanhoDiferenca(tamanho1, tamanho2);
                lblTamDiferenca.Text = "Tamanho Diferença: " + tamahoArquivo.ToString("#,##0.0000");
            }
            catch
            {
            }
        }

        private void calcByte()
        {
            try
            {
                calculo = new calculoTransferencia();
                downBits = decimal.Parse(txtBiteDown.Text);
                upBits = decimal.Parse(txtBiteUp.Text);
                downByte = calculo.downByte(downBits);
                upByte = calculo.upByte(upBits);


                txtByteDown.Text = downByte.ToString("#,##0.0000");
                txtByteUp.Text = upByte.ToString("#,##0.0000");
            }
            catch
            {
            }
        }
        private void calcTempo()
        {
            try
            {
                calculo = new calculoTransferencia();
                tipoArquivo = cbxTipoArquivo1.SelectedIndex;

                tempoTransferenciaDown = calculo.tempoTranferenciaDown(tipoArquivo, tamahoArquivo, downByte);
                tempoTransferenciaUp = calculo.tempoTranferenciaUp(tipoArquivo, tamahoArquivo, upByte);

                minutosDown = tempoTransferenciaDown / 60;
                horasDown = tempoTransferenciaDown / 60 / 60;
                diasDown = tempoTransferenciaDown / 60 / 60 / 24;

                minutosUp = tempoTransferenciaUp / 60;
                horasUp = tempoTransferenciaUp / 60 / 60;
                diasUp = tempoTransferenciaUp / 60 / 60 / 24;

                porcentagem = (tamanho2 * 100) / tamanho1;

                txtInformacao.Text = "TEMPO DE DOWNLOAD" +
                                     "\nHoras: " + horasDown.ToString("#,##0.0000") +
                                     "\nMinutos: " + minutosDown.ToString("#,##0.0000") +
                                     "\nDias: " + diasDown.ToString("#,##0.0000") +
                                     "\n\nTEMPO DE UPLOAD" +
                                     "\nHoras: " + horasUp.ToString("#,##0.0000") +
                                     "\nMinutos: " + minutosUp.ToString("#,##0.0000") +
                                     "\nDias: " + diasUp.ToString("#,##0.0000") +
                                     "\n\nPORCENTAGEM" +
                                     "\nConcluido: " + porcentagem.ToString("00.00") + "%";

            }
            catch
            {
            }
        }
    }
}
