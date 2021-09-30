
namespace LoginCadastro
{
    partial class Login
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCadasLo = new System.Windows.Forms.Button();
            this.btnEntraLo = new System.Windows.Forms.Button();
            this.btnSairLo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEmailLo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSenhaLo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnCadasLo
            // 
            this.btnCadasLo.Location = new System.Drawing.Point(453, 250);
            this.btnCadasLo.Name = "btnCadasLo";
            this.btnCadasLo.Size = new System.Drawing.Size(123, 32);
            this.btnCadasLo.TabIndex = 0;
            this.btnCadasLo.Text = "Cadastro";
            this.btnCadasLo.UseVisualStyleBackColor = true;
            this.btnCadasLo.Click += new System.EventHandler(this.btnCadasLo_Click);
            // 
            // btnEntraLo
            // 
            this.btnEntraLo.Location = new System.Drawing.Point(385, 203);
            this.btnEntraLo.Name = "btnEntraLo";
            this.btnEntraLo.Size = new System.Drawing.Size(75, 23);
            this.btnEntraLo.TabIndex = 1;
            this.btnEntraLo.Text = "Entrar";
            this.btnEntraLo.UseVisualStyleBackColor = true;
            // 
            // btnSairLo
            // 
            this.btnSairLo.Location = new System.Drawing.Point(501, 203);
            this.btnSairLo.Name = "btnSairLo";
            this.btnSairLo.Size = new System.Drawing.Size(75, 23);
            this.btnSairLo.TabIndex = 2;
            this.btnSairLo.Text = "Sair";
            this.btnSairLo.UseVisualStyleBackColor = true;
            this.btnSairLo.Click += new System.EventHandler(this.btnSairLo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(232, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Email";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtEmailLo
            // 
            this.txtEmailLo.Location = new System.Drawing.Point(293, 78);
            this.txtEmailLo.Name = "txtEmailLo";
            this.txtEmailLo.Size = new System.Drawing.Size(283, 20);
            this.txtEmailLo.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(379, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 31);
            this.label2.TabIndex = 5;
            this.label2.Text = "Login";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(226, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Senha";
            // 
            // txtSenhaLo
            // 
            this.txtSenhaLo.Location = new System.Drawing.Point(293, 144);
            this.txtSenhaLo.Name = "txtSenhaLo";
            this.txtSenhaLo.PasswordChar = '*';
            this.txtSenhaLo.Size = new System.Drawing.Size(283, 20);
            this.txtSenhaLo.TabIndex = 7;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 349);
            this.Controls.Add(this.txtSenhaLo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtEmailLo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSairLo);
            this.Controls.Add(this.btnEntraLo);
            this.Controls.Add(this.btnCadasLo);
            this.Name = "Login";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCadasLo;
        private System.Windows.Forms.Button btnEntraLo;
        private System.Windows.Forms.Button btnSairLo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEmailLo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSenhaLo;
    }
}

