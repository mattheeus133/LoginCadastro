
namespace LoginCadastro
{
    partial class Cadastro
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEmailCa = new System.Windows.Forms.TextBox();
            this.txtSenhaCa = new System.Windows.Forms.TextBox();
            this.txtConfiSenhaCa = new System.Windows.Forms.TextBox();
            this.btnCadasCa = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(129, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cadastro";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(65, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Senha";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(65, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Confirmação de senha";
            // 
            // txtEmailCa
            // 
            this.txtEmailCa.Location = new System.Drawing.Point(68, 85);
            this.txtEmailCa.Name = "txtEmailCa";
            this.txtEmailCa.Size = new System.Drawing.Size(212, 20);
            this.txtEmailCa.TabIndex = 4;
            // 
            // txtSenhaCa
            // 
            this.txtSenhaCa.Location = new System.Drawing.Point(68, 139);
            this.txtSenhaCa.Name = "txtSenhaCa";
            this.txtSenhaCa.PasswordChar = '*';
            this.txtSenhaCa.Size = new System.Drawing.Size(212, 20);
            this.txtSenhaCa.TabIndex = 5;
            // 
            // txtConfiSenhaCa
            // 
            this.txtConfiSenhaCa.Location = new System.Drawing.Point(68, 194);
            this.txtConfiSenhaCa.Name = "txtConfiSenhaCa";
            this.txtConfiSenhaCa.PasswordChar = '*';
            this.txtConfiSenhaCa.Size = new System.Drawing.Size(212, 20);
            this.txtConfiSenhaCa.TabIndex = 6;
            // 
            // btnCadasCa
            // 
            this.btnCadasCa.Location = new System.Drawing.Point(205, 242);
            this.btnCadasCa.Name = "btnCadasCa";
            this.btnCadasCa.Size = new System.Drawing.Size(75, 23);
            this.btnCadasCa.TabIndex = 7;
            this.btnCadasCa.Text = "Cadastrar";
            this.btnCadasCa.UseVisualStyleBackColor = true;
            // 
            // Cadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 397);
            this.Controls.Add(this.btnCadasCa);
            this.Controls.Add(this.txtConfiSenhaCa);
            this.Controls.Add(this.txtSenhaCa);
            this.Controls.Add(this.txtEmailCa);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Cadastro";
            this.Text = "Cadastro";
            this.Load += new System.EventHandler(this.Cadastro_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEmailCa;
        private System.Windows.Forms.TextBox txtSenhaCa;
        private System.Windows.Forms.TextBox txtConfiSenhaCa;
        private System.Windows.Forms.Button btnCadasCa;
    }
}