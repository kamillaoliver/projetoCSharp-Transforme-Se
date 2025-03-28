namespace FolhaPagamento
{
    partial class frmFluxoCaixa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFluxoCaixa));
            this.lblDataDaFolha = new System.Windows.Forms.Label();
            this.lblSalarioBruto = new System.Windows.Forms.Label();
            this.lblClubeLazer = new System.Windows.Forms.Label();
            this.lbl_ImpostoRenda = new System.Windows.Forms.Label();
            this.lblSalarioFolha = new System.Windows.Forms.Label();
            this.lblSalarioLiquido = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.txtSalarioBruto = new System.Windows.Forms.TextBox();
            this.txtSalarioFolha = new System.Windows.Forms.TextBox();
            this.txtSalarioLiquido = new System.Windows.Forms.TextBox();
            this.txtImpostoRenda = new System.Windows.Forms.TextBox();
            this.ckbPlanoDeSaude = new System.Windows.Forms.CheckBox();
            this.dtpData = new System.Windows.Forms.DateTimePicker();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.cbbClubeLazer = new System.Windows.Forms.ComboBox();
            this.lblPlanoSaude = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblDataDaFolha
            // 
            this.lblDataDaFolha.AutoSize = true;
            this.lblDataDaFolha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataDaFolha.Location = new System.Drawing.Point(54, 24);
            this.lblDataDaFolha.Name = "lblDataDaFolha";
            this.lblDataDaFolha.Size = new System.Drawing.Size(110, 20);
            this.lblDataDaFolha.TabIndex = 0;
            this.lblDataDaFolha.Text = "Data da Folha";
            // 
            // lblSalarioBruto
            // 
            this.lblSalarioBruto.AutoSize = true;
            this.lblSalarioBruto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalarioBruto.Location = new System.Drawing.Point(54, 98);
            this.lblSalarioBruto.Name = "lblSalarioBruto";
            this.lblSalarioBruto.Size = new System.Drawing.Size(58, 20);
            this.lblSalarioBruto.TabIndex = 0;
            this.lblSalarioBruto.Text = "Salário";
            // 
            // lblClubeLazer
            // 
            this.lblClubeLazer.AutoSize = true;
            this.lblClubeLazer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClubeLazer.Location = new System.Drawing.Point(54, 217);
            this.lblClubeLazer.Name = "lblClubeLazer";
            this.lblClubeLazer.Size = new System.Drawing.Size(120, 20);
            this.lblClubeLazer.TabIndex = 0;
            this.lblClubeLazer.Text = "Clube  de Lazer";
            // 
            // lbl_ImpostoRenda
            // 
            this.lbl_ImpostoRenda.AutoSize = true;
            this.lbl_ImpostoRenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ImpostoRenda.Location = new System.Drawing.Point(320, 105);
            this.lbl_ImpostoRenda.Name = "lbl_ImpostoRenda";
            this.lbl_ImpostoRenda.Size = new System.Drawing.Size(141, 20);
            this.lbl_ImpostoRenda.TabIndex = 0;
            this.lbl_ImpostoRenda.Text = "Imposto de Renda";
            // 
            // lblSalarioFolha
            // 
            this.lblSalarioFolha.AutoSize = true;
            this.lblSalarioFolha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalarioFolha.Location = new System.Drawing.Point(320, 50);
            this.lblSalarioFolha.Name = "lblSalarioFolha";
            this.lblSalarioFolha.Size = new System.Drawing.Size(102, 20);
            this.lblSalarioFolha.TabIndex = 0;
            this.lblSalarioFolha.Text = "Salário Folha";
            // 
            // lblSalarioLiquido
            // 
            this.lblSalarioLiquido.AutoSize = true;
            this.lblSalarioLiquido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalarioLiquido.Location = new System.Drawing.Point(320, 181);
            this.lblSalarioLiquido.Name = "lblSalarioLiquido";
            this.lblSalarioLiquido.Size = new System.Drawing.Size(113, 20);
            this.lblSalarioLiquido.TabIndex = 0;
            this.lblSalarioLiquido.Text = "Salário Liquido";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Image = ((System.Drawing.Image)(resources.GetObject("btnCalcular.Image")));
            this.btnCalcular.Location = new System.Drawing.Point(368, 243);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(199, 43);
            this.btnCalcular.TabIndex = 7;
            this.btnCalcular.Text = "&Calcular";
            this.btnCalcular.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCalcular.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // txtSalarioBruto
            // 
            this.txtSalarioBruto.Location = new System.Drawing.Point(54, 121);
            this.txtSalarioBruto.Name = "txtSalarioBruto";
            this.txtSalarioBruto.Size = new System.Drawing.Size(100, 20);
            this.txtSalarioBruto.TabIndex = 1;
            this.txtSalarioBruto.TextChanged += new System.EventHandler(this.txtSalarioBruto_TextChanged);
            // 
            // txtSalarioFolha
            // 
            this.txtSalarioFolha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSalarioFolha.Location = new System.Drawing.Point(467, 50);
            this.txtSalarioFolha.Name = "txtSalarioFolha";
            this.txtSalarioFolha.Size = new System.Drawing.Size(100, 20);
            this.txtSalarioFolha.TabIndex = 4;
            // 
            // txtSalarioLiquido
            // 
            this.txtSalarioLiquido.Location = new System.Drawing.Point(467, 181);
            this.txtSalarioLiquido.Name = "txtSalarioLiquido";
            this.txtSalarioLiquido.Size = new System.Drawing.Size(100, 20);
            this.txtSalarioLiquido.TabIndex = 6;
            // 
            // txtImpostoRenda
            // 
            this.txtImpostoRenda.Location = new System.Drawing.Point(467, 107);
            this.txtImpostoRenda.Name = "txtImpostoRenda";
            this.txtImpostoRenda.Size = new System.Drawing.Size(100, 20);
            this.txtImpostoRenda.TabIndex = 5;
            // 
            // ckbPlanoDeSaude
            // 
            this.ckbPlanoDeSaude.AutoSize = true;
            this.ckbPlanoDeSaude.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbPlanoDeSaude.Location = new System.Drawing.Point(54, 168);
            this.ckbPlanoDeSaude.Name = "ckbPlanoDeSaude";
            this.ckbPlanoDeSaude.Size = new System.Drawing.Size(138, 24);
            this.ckbPlanoDeSaude.TabIndex = 2;
            this.ckbPlanoDeSaude.Text = "Plano de saúde";
            this.ckbPlanoDeSaude.UseVisualStyleBackColor = true;
            this.ckbPlanoDeSaude.CheckedChanged += new System.EventHandler(this.ckbPlanoDeSaude_CheckedChanged);
            // 
            // dtpData
            // 
            this.dtpData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpData.Location = new System.Drawing.Point(54, 60);
            this.dtpData.Name = "dtpData";
            this.dtpData.Size = new System.Drawing.Size(100, 20);
            this.dtpData.TabIndex = 0;
            this.dtpData.TabStop = false;
            this.dtpData.Value = new System.DateTime(2025, 3, 28, 0, 0, 0, 0);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Image = ((System.Drawing.Image)(resources.GetObject("btnLimpar.Image")));
            this.btnLimpar.Location = new System.Drawing.Point(368, 292);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(199, 43);
            this.btnLimpar.TabIndex = 8;
            this.btnLimpar.Text = "&Limpar";
            this.btnLimpar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimpar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Image = ((System.Drawing.Image)(resources.GetObject("btnSair.Image")));
            this.btnSair.Location = new System.Drawing.Point(368, 341);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(199, 43);
            this.btnSair.TabIndex = 9;
            this.btnSair.Text = "&Sair";
            this.btnSair.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // cbbClubeLazer
            // 
            this.cbbClubeLazer.FormattingEnabled = true;
            this.cbbClubeLazer.Location = new System.Drawing.Point(58, 240);
            this.cbbClubeLazer.Name = "cbbClubeLazer";
            this.cbbClubeLazer.Size = new System.Drawing.Size(121, 21);
            this.cbbClubeLazer.TabIndex = 3;
            // 
            // lblPlanoSaude
            // 
            this.lblPlanoSaude.AutoSize = true;
            this.lblPlanoSaude.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlanoSaude.Location = new System.Drawing.Point(75, 341);
            this.lblPlanoSaude.Name = "lblPlanoSaude";
            this.lblPlanoSaude.Size = new System.Drawing.Size(0, 20);
            this.lblPlanoSaude.TabIndex = 0;
            // 
            // frmFluxoCaixa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 430);
            this.Controls.Add(this.cbbClubeLazer);
            this.Controls.Add(this.dtpData);
            this.Controls.Add(this.ckbPlanoDeSaude);
            this.Controls.Add(this.txtImpostoRenda);
            this.Controls.Add(this.txtSalarioLiquido);
            this.Controls.Add(this.txtSalarioFolha);
            this.Controls.Add(this.txtSalarioBruto);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.lblSalarioLiquido);
            this.Controls.Add(this.lblSalarioFolha);
            this.Controls.Add(this.lbl_ImpostoRenda);
            this.Controls.Add(this.lblClubeLazer);
            this.Controls.Add(this.lblPlanoSaude);
            this.Controls.Add(this.lblSalarioBruto);
            this.Controls.Add(this.lblDataDaFolha);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmFluxoCaixa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmFluxoCaixa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDataDaFolha;
        private System.Windows.Forms.Label lblSalarioBruto;
        private System.Windows.Forms.Label lblClubeLazer;
        private System.Windows.Forms.Label lbl_ImpostoRenda;
        private System.Windows.Forms.Label lblSalarioFolha;
        private System.Windows.Forms.Label lblSalarioLiquido;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.TextBox txtSalarioBruto;
        private System.Windows.Forms.TextBox txtSalarioFolha;
        private System.Windows.Forms.TextBox txtSalarioLiquido;
        private System.Windows.Forms.TextBox txtImpostoRenda;
        private System.Windows.Forms.CheckBox ckbPlanoDeSaude;
        private System.Windows.Forms.DateTimePicker dtpData;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.ComboBox cbbClubeLazer;
        private System.Windows.Forms.Label lblPlanoSaude;
    }
}