namespace ProjetoGames
{
    partial class Pedido
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
            this.cmbTiposdejogos = new System.Windows.Forms.ComboBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.valordojogo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ValorJogo = new System.Windows.Forms.TextBox();
            this.ValorOpcionais = new System.Windows.Forms.TextBox();
            this.ValorPagar = new System.Windows.Forms.TextBox();
            this.grpOpcionais = new System.Windows.Forms.GroupBox();
            this.chk2contas = new System.Windows.Forms.CheckBox();
            this.chk2controles = new System.Windows.Forms.CheckBox();
            this.chktotalpassgamer = new System.Windows.Forms.CheckBox();
            this.chkTesteDrive = new System.Windows.Forms.CheckBox();
            this.dgvPedido = new System.Windows.Forms.DataGridView();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.BTNCalcular = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.grpOpcionais.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedido)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbTiposdejogos
            // 
            this.cmbTiposdejogos.FormattingEnabled = true;
            this.cmbTiposdejogos.Items.AddRange(new object[] {
            "tipo de jogos"});
            this.cmbTiposdejogos.Location = new System.Drawing.Point(25, 31);
            this.cmbTiposdejogos.Name = "cmbTiposdejogos";
            this.cmbTiposdejogos.Size = new System.Drawing.Size(121, 21);
            this.cmbTiposdejogos.TabIndex = 0;
            this.cmbTiposdejogos.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // valordojogo
            // 
            this.valordojogo.AutoSize = true;
            this.valordojogo.Location = new System.Drawing.Point(150, 81);
            this.valordojogo.Name = "valordojogo";
            this.valordojogo.Size = new System.Drawing.Size(94, 13);
            this.valordojogo.TabIndex = 1;
            this.valordojogo.Text = "VALOR DO JOGO";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(283, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "VALOR DOS OPCIONAIS";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(476, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "VALOR A PAGAR";
            // 
            // ValorJogo
            // 
            this.ValorJogo.Location = new System.Drawing.Point(144, 109);
            this.ValorJogo.Name = "ValorJogo";
            this.ValorJogo.Size = new System.Drawing.Size(100, 20);
            this.ValorJogo.TabIndex = 4;
            // 
            // ValorOpcionais
            // 
            this.ValorOpcionais.Location = new System.Drawing.Point(298, 109);
            this.ValorOpcionais.Name = "ValorOpcionais";
            this.ValorOpcionais.Size = new System.Drawing.Size(100, 20);
            this.ValorOpcionais.TabIndex = 5;
            // 
            // ValorPagar
            // 
            this.ValorPagar.Location = new System.Drawing.Point(469, 109);
            this.ValorPagar.Name = "ValorPagar";
            this.ValorPagar.Size = new System.Drawing.Size(100, 20);
            this.ValorPagar.TabIndex = 6;
            // 
            // grpOpcionais
            // 
            this.grpOpcionais.Controls.Add(this.chkTesteDrive);
            this.grpOpcionais.Controls.Add(this.chktotalpassgamer);
            this.grpOpcionais.Controls.Add(this.chk2controles);
            this.grpOpcionais.Controls.Add(this.chk2contas);
            this.grpOpcionais.Location = new System.Drawing.Point(25, 159);
            this.grpOpcionais.Name = "grpOpcionais";
            this.grpOpcionais.Size = new System.Drawing.Size(200, 171);
            this.grpOpcionais.TabIndex = 7;
            this.grpOpcionais.TabStop = false;
            this.grpOpcionais.Text = "ESCOLHA OPCIONAIS";
            // 
            // chk2contas
            // 
            this.chk2contas.AutoSize = true;
            this.chk2contas.Location = new System.Drawing.Point(6, 19);
            this.chk2contas.Name = "chk2contas";
            this.chk2contas.Size = new System.Drawing.Size(79, 17);
            this.chk2contas.TabIndex = 8;
            this.chk2contas.Text = "2 CONTAS";
            this.chk2contas.UseVisualStyleBackColor = true;
            // 
            // chk2controles
            // 
            this.chk2controles.AutoSize = true;
            this.chk2controles.Location = new System.Drawing.Point(6, 58);
            this.chk2controles.Name = "chk2controles";
            this.chk2controles.Size = new System.Drawing.Size(101, 17);
            this.chk2controles.TabIndex = 9;
            this.chk2controles.Text = "2 CONTROLES";
            this.chk2controles.UseVisualStyleBackColor = true;
            // 
            // chktotalpassgamer
            // 
            this.chktotalpassgamer.AutoSize = true;
            this.chktotalpassgamer.Location = new System.Drawing.Point(6, 92);
            this.chktotalpassgamer.Name = "chktotalpassgamer";
            this.chktotalpassgamer.Size = new System.Drawing.Size(134, 17);
            this.chktotalpassgamer.TabIndex = 10;
            this.chktotalpassgamer.Text = "TOTAL PASS GAMER";
            this.chktotalpassgamer.UseVisualStyleBackColor = true;
            this.chktotalpassgamer.CheckedChanged += new System.EventHandler(this.chktotalpassgamer_CheckedChanged);
            // 
            // chkTesteDrive
            // 
            this.chkTesteDrive.AutoSize = true;
            this.chkTesteDrive.Location = new System.Drawing.Point(6, 125);
            this.chkTesteDrive.Name = "chkTesteDrive";
            this.chkTesteDrive.Size = new System.Drawing.Size(97, 17);
            this.chkTesteDrive.TabIndex = 11;
            this.chkTesteDrive.Text = "TESTE DRIVE";
            this.chkTesteDrive.UseVisualStyleBackColor = true;
            // 
            // dgvPedido
            // 
            this.dgvPedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPedido.Location = new System.Drawing.Point(247, 180);
            this.dgvPedido.Name = "dgvPedido";
            this.dgvPedido.Size = new System.Drawing.Size(481, 150);
            this.dgvPedido.TabIndex = 8;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(315, 363);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 9;
            this.btnSalvar.Text = "SALVAR";
            this.btnSalvar.UseVisualStyleBackColor = true;
            // 
            // BTNCalcular
            // 
            this.BTNCalcular.Location = new System.Drawing.Point(410, 363);
            this.BTNCalcular.Name = "BTNCalcular";
            this.BTNCalcular.Size = new System.Drawing.Size(75, 23);
            this.BTNCalcular.TabIndex = 10;
            this.BTNCalcular.Text = "CALCULAR";
            this.BTNCalcular.UseVisualStyleBackColor = true;
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(517, 363);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 11;
            this.btnSair.Text = "SAIR";
            this.btnSair.UseVisualStyleBackColor = true;
            // 
            // Pedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.BTNCalcular);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.dgvPedido);
            this.Controls.Add(this.grpOpcionais);
            this.Controls.Add(this.ValorPagar);
            this.Controls.Add(this.ValorOpcionais);
            this.Controls.Add(this.ValorJogo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.valordojogo);
            this.Controls.Add(this.cmbTiposdejogos);
            this.Name = "Pedido";
            this.Text = "Pedido";
            this.grpOpcionais.ResumeLayout(false);
            this.grpOpcionais.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedido)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbTiposdejogos;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Label valordojogo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ValorJogo;
        private System.Windows.Forms.TextBox ValorOpcionais;
        private System.Windows.Forms.TextBox ValorPagar;
        private System.Windows.Forms.GroupBox grpOpcionais;
        private System.Windows.Forms.CheckBox chk2contas;
        private System.Windows.Forms.CheckBox chkTesteDrive;
        private System.Windows.Forms.CheckBox chktotalpassgamer;
        private System.Windows.Forms.CheckBox chk2controles;
        private System.Windows.Forms.DataGridView dgvPedido;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button BTNCalcular;
        private System.Windows.Forms.Button btnSair;
    }
}