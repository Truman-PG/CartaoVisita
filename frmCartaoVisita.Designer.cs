namespace CartaoVisita
{
    partial class frmCartaoVisita
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCartaoVisita));
            lblNome = new Label();
            lblTelefone = new Label();
            lblIdade = new Label();
            lblEmail = new Label();
            lblEndereço = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btnSalvar = new Button();
            SuspendLayout();
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.BackColor = Color.Black;
            lblNome.Font = new Font("Segoe UI Historic", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNome.ForeColor = Color.White;
            lblNome.Location = new Point(359, 9);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(97, 38);
            lblNome.TabIndex = 0;
            lblNome.Text = "Nome";
            // 
            // lblTelefone
            // 
            lblTelefone.AutoSize = true;
            lblTelefone.BackColor = Color.Black;
            lblTelefone.Font = new Font("Segoe UI Historic", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTelefone.ForeColor = Color.White;
            lblTelefone.Location = new Point(81, 125);
            lblTelefone.Name = "lblTelefone";
            lblTelefone.Size = new Size(133, 38);
            lblTelefone.TabIndex = 1;
            lblTelefone.Text = "Telefone";
            // 
            // lblIdade
            // 
            lblIdade.AutoSize = true;
            lblIdade.BackColor = Color.Black;
            lblIdade.Font = new Font("Segoe UI Historic", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblIdade.ForeColor = Color.White;
            lblIdade.Location = new Point(81, 56);
            lblIdade.Name = "lblIdade";
            lblIdade.Size = new Size(90, 38);
            lblIdade.TabIndex = 2;
            lblIdade.Text = "Idade";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.BackColor = Color.Black;
            lblEmail.Font = new Font("Segoe UI Historic", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEmail.ForeColor = Color.White;
            lblEmail.Location = new Point(81, 186);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(88, 38);
            lblEmail.TabIndex = 3;
            lblEmail.Text = "Email";
            // 
            // lblEndereço
            // 
            lblEndereço.AutoSize = true;
            lblEndereço.BackColor = Color.Black;
            lblEndereço.Font = new Font("Segoe UI Historic", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEndereço.ForeColor = Color.White;
            lblEndereço.Location = new Point(81, 242);
            lblEndereço.Name = "lblEndereço";
            lblEndereço.Size = new Size(140, 38);
            lblEndereço.TabIndex = 4;
            lblEndereço.Text = "Endereço";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Black;
            label1.ForeColor = Color.White;
            label1.Location = new Point(38, 67);
            label1.Name = "label1";
            label1.Size = new Size(37, 25);
            label1.TabIndex = 5;
            label1.Text = "🎂";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Black;
            label2.ForeColor = Color.White;
            label2.Location = new Point(40, 136);
            label2.Name = "label2";
            label2.Size = new Size(35, 25);
            label2.TabIndex = 6;
            label2.Text = "📞";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Black;
            label3.ForeColor = Color.White;
            label3.Location = new Point(38, 199);
            label3.Name = "label3";
            label3.Size = new Size(37, 25);
            label3.TabIndex = 7;
            label3.Text = "📧";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Black;
            label4.ForeColor = Color.White;
            label4.Location = new Point(48, 253);
            label4.Name = "label4";
            label4.Size = new Size(27, 25);
            label4.TabIndex = 8;
            label4.Text = "📍";
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(686, 416);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(112, 34);
            btnSalvar.TabIndex = 9;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // frmCartaoVisita
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSalvar);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblEndereço);
            Controls.Add(lblEmail);
            Controls.Add(lblIdade);
            Controls.Add(lblTelefone);
            Controls.Add(lblNome);
            Name = "frmCartaoVisita";
            Text = "frmCartaoVisita";
            Load += frmCartaoVisita_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNome;
        private Label lblTelefone;
        private Label lblIdade;
        private Label lblEmail;
        private Label lblEndereço;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btnSalvar;
    }
}