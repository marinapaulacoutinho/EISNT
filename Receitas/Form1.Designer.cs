
namespace Receitas
{
    partial class Form1
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
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.textBoxTempoPrep = new System.Windows.Forms.TextBox();
            this.richTextBoxDesc = new System.Windows.Forms.RichTextBox();
            this.textBoxGrauDificuldade = new System.Windows.Forms.TextBox();
            this.textBoxNumeroPessoas = new System.Windows.Forms.TextBox();
            this.textBoxCategoria = new System.Windows.Forms.TextBox();
            this.lbNome = new System.Windows.Forms.Label();
            this.lbTempoPrep = new System.Windows.Forms.Label();
            this.lbNumeroPessoas = new System.Windows.Forms.Label();
            this.lbCategoria = new System.Windows.Forms.Label();
            this.lbGrauDificuldade = new System.Windows.Forms.Label();
            this.lbDescricao = new System.Windows.Forms.Label();
            this.buttonGravar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(143, 12);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(253, 23);
            this.textBoxNome.TabIndex = 0;
            // 
            // textBoxTempoPrep
            // 
            this.textBoxTempoPrep.Location = new System.Drawing.Point(143, 51);
            this.textBoxTempoPrep.Name = "textBoxTempoPrep";
            this.textBoxTempoPrep.Size = new System.Drawing.Size(100, 23);
            this.textBoxTempoPrep.TabIndex = 1;
            // 
            // richTextBoxDesc
            // 
            this.richTextBoxDesc.Location = new System.Drawing.Point(12, 232);
            this.richTextBoxDesc.Name = "richTextBoxDesc";
            this.richTextBoxDesc.Size = new System.Drawing.Size(533, 233);
            this.richTextBoxDesc.TabIndex = 2;
            this.richTextBoxDesc.Text = "";
            // 
            // textBoxGrauDificuldade
            // 
            this.textBoxGrauDificuldade.Location = new System.Drawing.Point(143, 93);
            this.textBoxGrauDificuldade.Name = "textBoxGrauDificuldade";
            this.textBoxGrauDificuldade.Size = new System.Drawing.Size(100, 23);
            this.textBoxGrauDificuldade.TabIndex = 3;
            // 
            // textBoxNumeroPessoas
            // 
            this.textBoxNumeroPessoas.Location = new System.Drawing.Point(143, 132);
            this.textBoxNumeroPessoas.Name = "textBoxNumeroPessoas";
            this.textBoxNumeroPessoas.Size = new System.Drawing.Size(100, 23);
            this.textBoxNumeroPessoas.TabIndex = 4;
            // 
            // textBoxCategoria
            // 
            this.textBoxCategoria.Location = new System.Drawing.Point(143, 174);
            this.textBoxCategoria.Name = "textBoxCategoria";
            this.textBoxCategoria.Size = new System.Drawing.Size(100, 23);
            this.textBoxCategoria.TabIndex = 5;
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.Location = new System.Drawing.Point(12, 15);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(40, 15);
            this.lbNome.TabIndex = 6;
            this.lbNome.Text = "Nome";
            // 
            // lbTempoPrep
            // 
            this.lbTempoPrep.AutoSize = true;
            this.lbTempoPrep.Location = new System.Drawing.Point(12, 54);
            this.lbTempoPrep.Name = "lbTempoPrep";
            this.lbTempoPrep.Size = new System.Drawing.Size(121, 15);
            this.lbTempoPrep.TabIndex = 7;
            this.lbTempoPrep.Text = "Tempo de Preparação";
            // 
            // lbNumeroPessoas
            // 
            this.lbNumeroPessoas.AutoSize = true;
            this.lbNumeroPessoas.Location = new System.Drawing.Point(12, 135);
            this.lbNumeroPessoas.Name = "lbNumeroPessoas";
            this.lbNumeroPessoas.Size = new System.Drawing.Size(111, 15);
            this.lbNumeroPessoas.TabIndex = 8;
            this.lbNumeroPessoas.Text = "Numero de Pessoas";
            this.lbNumeroPessoas.Click += new System.EventHandler(this.label2_Click);
            // 
            // lbCategoria
            // 
            this.lbCategoria.AutoSize = true;
            this.lbCategoria.Location = new System.Drawing.Point(12, 177);
            this.lbCategoria.Name = "lbCategoria";
            this.lbCategoria.Size = new System.Drawing.Size(58, 15);
            this.lbCategoria.TabIndex = 9;
            this.lbCategoria.Text = "Categoria";
            // 
            // lbGrauDificuldade
            // 
            this.lbGrauDificuldade.AutoSize = true;
            this.lbGrauDificuldade.Location = new System.Drawing.Point(12, 96);
            this.lbGrauDificuldade.Name = "lbGrauDificuldade";
            this.lbGrauDificuldade.Size = new System.Drawing.Size(111, 15);
            this.lbGrauDificuldade.TabIndex = 11;
            this.lbGrauDificuldade.Text = "Grau de Dificuldade";
            // 
            // lbDescricao
            // 
            this.lbDescricao.AutoSize = true;
            this.lbDescricao.Location = new System.Drawing.Point(12, 214);
            this.lbDescricao.Name = "lbDescricao";
            this.lbDescricao.Size = new System.Drawing.Size(58, 15);
            this.lbDescricao.TabIndex = 12;
            this.lbDescricao.Text = "Descrição";
            // 
            // buttonGravar
            // 
            this.buttonGravar.Location = new System.Drawing.Point(470, 15);
            this.buttonGravar.Name = "buttonGravar";
            this.buttonGravar.Size = new System.Drawing.Size(75, 23);
            this.buttonGravar.TabIndex = 13;
            this.buttonGravar.Text = "Gravar";
            this.buttonGravar.UseVisualStyleBackColor = true;
            this.buttonGravar.Click += new System.EventHandler(this.buttonGravar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1155, 497);
            this.Controls.Add(this.buttonGravar);
            this.Controls.Add(this.lbDescricao);
            this.Controls.Add(this.lbGrauDificuldade);
            this.Controls.Add(this.lbCategoria);
            this.Controls.Add(this.lbNumeroPessoas);
            this.Controls.Add(this.lbTempoPrep);
            this.Controls.Add(this.lbNome);
            this.Controls.Add(this.textBoxCategoria);
            this.Controls.Add(this.textBoxNumeroPessoas);
            this.Controls.Add(this.textBoxGrauDificuldade);
            this.Controls.Add(this.richTextBoxDesc);
            this.Controls.Add(this.textBoxTempoPrep);
            this.Controls.Add(this.textBoxNome);
            this.Name = "Form1";
            this.Text = "Receitas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxNome;
        private System.Windows.Forms.TextBox textBoxTempoPrep;
        private System.Windows.Forms.RichTextBox richTextBoxDesc;
        private System.Windows.Forms.TextBox textBoxGrauDificuldade;
        private System.Windows.Forms.TextBox textBoxNumeroPessoas;
        private System.Windows.Forms.TextBox textBoxCategoria;
        private System.Windows.Forms.Label lbNome;
        private System.Windows.Forms.Label lbTempoPrep;
        private System.Windows.Forms.Label lbNumeroPessoas;
        private System.Windows.Forms.Label lbCategoria;
        private System.Windows.Forms.Label lbGrauDificuldade;
        private System.Windows.Forms.Label lbDescricao;
        private System.Windows.Forms.Button buttonGravar;
    }
}

