namespace CalculoTransferencia
{
    partial class frmCalculoTransferencia
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCalculoTransferencia));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtByteUp = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtByteDown = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbxTipoArquivo1 = new System.Windows.Forms.ComboBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtInformacao = new System.Windows.Forms.RichTextBox();
            this.lblTamDiferenca = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtBiteDown = new System.Windows.Forms.TextBox();
            this.txtBiteUp = new System.Windows.Forms.TextBox();
            this.txtArquivoTamanho1 = new System.Windows.Forms.TextBox();
            this.txtArquivoTamanho2 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtBiteDown);
            this.groupBox1.Location = new System.Drawing.Point(13, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(141, 64);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Internet Contratada MBits";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(72, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Upload";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Download";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtByteUp);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtByteDown);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(160, 9);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(234, 64);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Taxa de Transf. - Kilobyte";
            // 
            // txtByteUp
            // 
            this.txtByteUp.Location = new System.Drawing.Point(122, 30);
            this.txtByteUp.Name = "txtByteUp";
            this.txtByteUp.ReadOnly = true;
            this.txtByteUp.Size = new System.Drawing.Size(95, 20);
            this.txtByteUp.TabIndex = 7;
            this.txtByteUp.Text = "0";
            this.txtByteUp.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(119, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Upload";
            // 
            // txtByteDown
            // 
            this.txtByteDown.Location = new System.Drawing.Point(21, 30);
            this.txtByteDown.Name = "txtByteDown";
            this.txtByteDown.ReadOnly = true;
            this.txtByteDown.Size = new System.Drawing.Size(95, 20);
            this.txtByteDown.TabIndex = 6;
            this.txtByteDown.Text = "0";
            this.txtByteDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Download";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.txtArquivoTamanho1);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.cbxTipoArquivo1);
            this.groupBox3.Location = new System.Drawing.Point(411, 9);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(198, 64);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tamanho do Arquivo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(82, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Tipo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Tamanho";
            // 
            // cbxTipoArquivo1
            // 
            this.cbxTipoArquivo1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxTipoArquivo1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxTipoArquivo1.FormattingEnabled = true;
            this.cbxTipoArquivo1.Items.AddRange(new object[] {
            "01 - Bits",
            "02 - Bytes",
            "03 - Kilobytes",
            "04 - Megabytes",
            "05 - Gigabytes",
            "06 - Terabytes",
            "07 - Petabyte",
            "08 - Exabyte",
            "09 - Zettabyte",
            "10 - Yottabyte"});
            this.cbxTipoArquivo1.Location = new System.Drawing.Point(85, 30);
            this.cbxTipoArquivo1.Name = "cbxTipoArquivo1";
            this.cbxTipoArquivo1.Size = new System.Drawing.Size(105, 21);
            this.cbxTipoArquivo1.TabIndex = 4;
            this.cbxTipoArquivo1.SelectedIndexChanged += new System.EventHandler(this.cbxTipoArquivo1_SelectedIndexChanged);
            this.cbxTipoArquivo1.Leave += new System.EventHandler(this.cbxTipoArquivo1_Leave);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtArquivoTamanho2);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.txtInformacao);
            this.groupBox4.Controls.Add(this.lblTamDiferenca);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Location = new System.Drawing.Point(13, 79);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(596, 293);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Tempo de Transferência";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(230, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(356, 52);
            this.label8.TabIndex = 9;
            this.label8.Text = "Informações deste progama não especifica o tempo real para a conclusão\r\nApenas de" +
    "monstra uma média baseada em valores fixos.\r\n\r\nLembrando que a taxa de transfere" +
    "ncia não mantem seu valor fixo.";
            // 
            // txtInformacao
            // 
            this.txtInformacao.Location = new System.Drawing.Point(11, 74);
            this.txtInformacao.Name = "txtInformacao";
            this.txtInformacao.ReadOnly = true;
            this.txtInformacao.Size = new System.Drawing.Size(579, 213);
            this.txtInformacao.TabIndex = 8;
            this.txtInformacao.Text = "";
            // 
            // lblTamDiferenca
            // 
            this.lblTamDiferenca.AutoSize = true;
            this.lblTamDiferenca.Location = new System.Drawing.Point(80, 38);
            this.lblTamDiferenca.Name = "lblTamDiferenca";
            this.lblTamDiferenca.Size = new System.Drawing.Size(131, 13);
            this.lblTamDiferenca.TabIndex = 6;
            this.lblTamDiferenca.Text = "Tamanho Diferença: 0000";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 58);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(103, 13);
            this.label9.TabIndex = 5;
            this.label9.Text = "Simulação de tempo";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Tam. já Trans.";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(10, 375);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(168, 13);
            this.label10.TabIndex = 7;
            this.label10.Text = "Desenvolvido por: Maycon Wisley";
            // 
            // txtBiteDown
            // 
            this.txtBiteDown.Location = new System.Drawing.Point(17, 30);
            this.txtBiteDown.Name = "txtBiteDown";
            this.txtBiteDown.Size = new System.Drawing.Size(52, 20);
            this.txtBiteDown.TabIndex = 1;
            this.txtBiteDown.Text = "1";
            this.txtBiteDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtBiteDown.Enter += new System.EventHandler(this.txtBiteDown_Enter);
            this.txtBiteDown.Leave += new System.EventHandler(this.txtBiteDown_Leave);
            // 
            // txtBiteUp
            // 
            this.txtBiteUp.Location = new System.Drawing.Point(88, 39);
            this.txtBiteUp.Name = "txtBiteUp";
            this.txtBiteUp.Size = new System.Drawing.Size(52, 20);
            this.txtBiteUp.TabIndex = 2;
            this.txtBiteUp.Text = "1";
            this.txtBiteUp.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtBiteUp.Enter += new System.EventHandler(this.txtBiteUp_Enter);
            this.txtBiteUp.Leave += new System.EventHandler(this.txtBiteUp_Leave);
            // 
            // txtArquivoTamanho1
            // 
            this.txtArquivoTamanho1.Location = new System.Drawing.Point(11, 30);
            this.txtArquivoTamanho1.Name = "txtArquivoTamanho1";
            this.txtArquivoTamanho1.Size = new System.Drawing.Size(68, 20);
            this.txtArquivoTamanho1.TabIndex = 3;
            this.txtArquivoTamanho1.Text = "1";
            this.txtArquivoTamanho1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtArquivoTamanho1.Enter += new System.EventHandler(this.txtArquivoTamanho1_Enter);
            this.txtArquivoTamanho1.Leave += new System.EventHandler(this.txtArquivoTamanho1_Leave);
            // 
            // txtArquivoTamanho2
            // 
            this.txtArquivoTamanho2.Location = new System.Drawing.Point(11, 35);
            this.txtArquivoTamanho2.Name = "txtArquivoTamanho2";
            this.txtArquivoTamanho2.Size = new System.Drawing.Size(63, 20);
            this.txtArquivoTamanho2.TabIndex = 4;
            this.txtArquivoTamanho2.Text = "0";
            this.txtArquivoTamanho2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtArquivoTamanho2.Enter += new System.EventHandler(this.txtArquivoTamanho2_Enter);
            this.txtArquivoTamanho2.Leave += new System.EventHandler(this.txtArquivoTamanho2_Leave);
            // 
            // frmCalculoTransferencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 400);
            this.Controls.Add(this.txtBiteUp);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCalculoTransferencia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Simulador de Calculo de Transferência";
            this.Load += new System.EventHandler(this.frmCalculoTransferencia_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtByteUp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtByteDown;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbxTipoArquivo1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblTamDiferenca;
        private System.Windows.Forms.RichTextBox txtInformacao;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtBiteDown;
        private System.Windows.Forms.TextBox txtBiteUp;
        private System.Windows.Forms.TextBox txtArquivoTamanho1;
        private System.Windows.Forms.TextBox txtArquivoTamanho2;
    }
}

