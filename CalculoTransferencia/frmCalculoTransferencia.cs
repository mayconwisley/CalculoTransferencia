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
        calculoTempo tempo;
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
            calculo = new calculoTransferencia();

            decimal val = 0;

            if (decimal.TryParse(txtArquivoTamanho1.Text.Trim(), out val))
            {
                tamanho1 = val;
            }
            else
            {
                MessageBox.Show("Digite apenas números", "Erro");
                txtArquivoTamanho1.Text = "1";
            }

            if (decimal.TryParse(txtArquivoTamanho2.Text.Trim(), out val))
            {
                tamanho2 = val;
            }
            else
            {
                MessageBox.Show("Digite apenas números", "Erro");
                txtArquivoTamanho2.Text = "0";
            }

            tamahoArquivo = calculo.tamanhoDiferenca(tamanho1, tamanho2);
            lblTamDiferenca.Text = "Tamanho Diferença: " + tamahoArquivo.ToString("#,##0.0000");
        }

        private void calcByte()
        {
            calculo = new calculoTransferencia();
            decimal val = 0;

            if (decimal.TryParse(txtBiteDown.Text.Trim(), out val))
            {
                downBits = val;
            }
            else
            {
                MessageBox.Show("Digite apenas números", "Erro");
                txtBiteDown.Text = "1";
            }

            if (decimal.TryParse(txtBiteUp.Text.Trim(), out val))
            {
                upBits = val;
            }
            else
            {
                MessageBox.Show("Digite apenas números", "Erro");
                txtBiteUp.Text = "1";
            }
            downByte = calculo.downByte(downBits);
            upByte = calculo.upByte(upBits);
            txtByteDown.Text = downByte.ToString("#,##0.0000");
            txtByteUp.Text = upByte.ToString("#,##0.0000");

        }
        private void calcTempo()
        {
            calculo = new calculoTransferencia();
            tempo = new calculoTempo();
            tipoArquivo = cbxTipoArquivo1.SelectedIndex;

            tempoTransferenciaDown = calculo.tempoTranferenciaDown(tipoArquivo, tamahoArquivo, downByte);
            tempoTransferenciaUp = calculo.tempoTranferenciaUp(tipoArquivo, tamahoArquivo, upByte);

            minutosDown = tempo.minutosDown(tempoTransferenciaDown);
            horasDown = tempo.horasDown(tempoTransferenciaDown);
            diasDown = tempo.diasDown(tempoTransferenciaDown);

            minutosUp = tempo.minutosUp(tempoTransferenciaUp);
            horasUp = tempo.horasUp(tempoTransferenciaUp);
            diasUp = tempo.diasUp(tempoTransferenciaUp);

            porcentagem = tempo.porcentagem(tamanho1, tamanho2);

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
    }
}
