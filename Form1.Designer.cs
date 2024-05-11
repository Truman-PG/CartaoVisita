namespace CartaoVisita
{
    partial class FrmInicio
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblNome = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            panel1 = new Panel();
            btnSalvar = new Button();
            txtEndereço = new TextBox();
            txtEmail = new TextBox();
            txtTelefone = new TextBox();
            txtIdade = new TextBox();
            txtNome = new TextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(12, 39);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(61, 25);
            lblNome.TabIndex = 0;
            lblNome.Text = "Nome";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 125);
            label1.Name = "label1";
            label1.Size = new Size(57, 25);
            label1.TabIndex = 1;
            label1.Text = "Idade";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 214);
            label2.Name = "label2";
            label2.Size = new Size(77, 25);
            label2.TabIndex = 2;
            label2.Text = "Telefone";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 302);
            label3.Name = "label3";
            label3.Size = new Size(61, 25);
            label3.TabIndex = 3;
            label3.Text = "E-mail";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(4, 389);
            label4.Name = "label4";
            label4.Size = new Size(85, 25);
            label4.TabIndex = 4;
            label4.Text = "Endereço";
            // 
            // panel1
            // 
            panel1.Controls.Add(btnSalvar);
            panel1.Controls.Add(txtEndereço);
            panel1.Controls.Add(txtEmail);
            panel1.Controls.Add(txtTelefone);
            panel1.Controls.Add(txtIdade);
            panel1.Controls.Add(txtNome);
            panel1.Location = new Point(4, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(295, 498);
            panel1.TabIndex = 5;
            // 
            // btnSalvar
            // 
            btnSalvar.Cursor = Cursors.Hand;
            btnSalvar.Location = new Point(96, 445);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(112, 34);
            btnSalvar.TabIndex = 5;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // txtEndereço
            // 
            txtEndereço.Location = new Point(96, 371);
            txtEndereço.Name = "txtEndereço";
            txtEndereço.Size = new Size(150, 31);
            txtEndereço.TabIndex = 4;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(96, 287);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(150, 31);
            txtEmail.TabIndex = 3;
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(96, 202);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(150, 31);
            txtTelefone.TabIndex = 2;
            // 
            // txtIdade
            // 
            txtIdade.Location = new Point(96, 107);
            txtIdade.Name = "txtIdade";
            txtIdade.Size = new Size(150, 31);
            txtIdade.TabIndex = 1;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(96, 27);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(150, 31);
            txtNome.TabIndex = 0;
            // 
            // FrmInicio
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(308, 522);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblNome);
            Controls.Add(panel1);
            Name = "FrmInicio";
            Text = "Cartão de visitas (dados)";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNome;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Panel panel1;
        private TextBox txtEndereço;
        private TextBox txtEmail;
        private TextBox txtTelefone;
        private TextBox txtIdade;
        private TextBox txtNome;
        private Button btnSalvar;
    }
}
