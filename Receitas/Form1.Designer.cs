
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
            this.lbNome = new System.Windows.Forms.Label();
            this.lbTempoPrep = new System.Windows.Forms.Label();
            this.lbNumeroPessoas = new System.Windows.Forms.Label();
            this.lbCategoria = new System.Windows.Forms.Label();
            this.lbDescricao = new System.Windows.Forms.Label();
            this.buttonGravar = new System.Windows.Forms.Button();
            this.cBGrauDificuldade = new System.Windows.Forms.ComboBox();
            this.cBNumeroPessoas = new System.Windows.Forms.ComboBox();
            this.cBCategoria = new System.Windows.Forms.ComboBox();
            this.lbGrauDificuldade = new System.Windows.Forms.Label();
            this.dGVReceitas = new System.Windows.Forms.DataGridView();
            this.bntLimpar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dGVReceitas)).BeginInit();
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
            this.buttonGravar.Location = new System.Drawing.Point(470, 471);
            this.buttonGravar.Name = "buttonGravar";
            this.buttonGravar.Size = new System.Drawing.Size(75, 23);
            this.buttonGravar.TabIndex = 13;
            this.buttonGravar.Text = "Gravar";
            this.buttonGravar.UseVisualStyleBackColor = true;
            this.buttonGravar.Click += new System.EventHandler(this.buttonGravar_Click);
            // 
            // cBGrauDificuldade
            // 
            this.cBGrauDificuldade.FormattingEnabled = true;
            this.cBGrauDificuldade.Items.AddRange(new object[] {
            "1",
            "2",
            "4",
            "5"});
            this.cBGrauDificuldade.Location = new System.Drawing.Point(143, 93);
            this.cBGrauDificuldade.Name = "cBGrauDificuldade";
            this.cBGrauDificuldade.Size = new System.Drawing.Size(37, 23);
            this.cBGrauDificuldade.TabIndex = 14;
            // 
            // cBNumeroPessoas
            // 
            this.cBNumeroPessoas.FormattingEnabled = true;
            this.cBNumeroPessoas.Items.AddRange(new object[] {
            "1",
            "2",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cBNumeroPessoas.Location = new System.Drawing.Point(143, 132);
            this.cBNumeroPessoas.Name = "cBNumeroPessoas";
            this.cBNumeroPessoas.Size = new System.Drawing.Size(37, 23);
            this.cBNumeroPessoas.TabIndex = 15;
            // 
            // cBCategoria
            // 
            this.cBCategoria.FormattingEnabled = true;
            this.cBCategoria.Items.AddRange(new object[] {
            "Carne",
            "Peixe"});
            this.cBCategoria.Location = new System.Drawing.Point(143, 174);
            this.cBCategoria.Name = "cBCategoria";
            this.cBCategoria.Size = new System.Drawing.Size(100, 23);
            this.cBCategoria.TabIndex = 16;
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
            // dGVReceitas
            // 
            this.dGVReceitas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVReceitas.Location = new System.Drawing.Point(564, 51);
            this.dGVReceitas.Name = "dGVReceitas";
            this.dGVReceitas.RowTemplate.Height = 25;
            this.dGVReceitas.Size = new System.Drawing.Size(568, 414);
            this.dGVReceitas.TabIndex = 17;
            // 
            // bntLimpar
            // 
            this.bntLimpar.Location = new System.Drawing.Point(1014, 22);
            this.bntLimpar.Name = "bntLimpar";
            this.bntLimpar.Size = new System.Drawing.Size(118, 23);
            this.bntLimpar.TabIndex = 18;
            this.bntLimpar.Text = "Limpar Tablela";
            this.bntLimpar.UseVisualStyleBackColor = true;
            this.bntLimpar.Click += new System.EventHandler(this.bntLimpar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1155, 497);
            this.Controls.Add(this.bntLimpar);
            this.Controls.Add(this.dGVReceitas);
            this.Controls.Add(this.cBCategoria);
            this.Controls.Add(this.cBNumeroPessoas);
            this.Controls.Add(this.cBGrauDificuldade);
            this.Controls.Add(this.buttonGravar);
            this.Controls.Add(this.lbDescricao);
            this.Controls.Add(this.lbGrauDificuldade);
            this.Controls.Add(this.lbCategoria);
            this.Controls.Add(this.lbNumeroPessoas);
            this.Controls.Add(this.lbTempoPrep);
            this.Controls.Add(this.lbNome);
            this.Controls.Add(this.richTextBoxDesc);
            this.Controls.Add(this.textBoxTempoPrep);
            this.Controls.Add(this.textBoxNome);
            this.Name = "Form1";
            this.Text = "Receitas";
            ((System.ComponentModel.ISupportInitialize)(this.dGVReceitas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxNome;
        private System.Windows.Forms.TextBox textBoxTempoPrep;
        private System.Windows.Forms.RichTextBox richTextBoxDesc;
        private System.Windows.Forms.Label lbNome;
        private System.Windows.Forms.Label lbTempoPrep;
        private System.Windows.Forms.Label lbNumeroPessoas;
        private System.Windows.Forms.Label lbCategoria;
        private System.Windows.Forms.Label lbDescricao;
        private System.Windows.Forms.Button buttonGravar;
        private System.Windows.Forms.ComboBox cBGrauDificuldade;
        private System.Windows.Forms.ComboBox cBNumeroPessoas;
        private System.Windows.Forms.ComboBox cBCategoria;
        private System.Windows.Forms.Label lbGrauDificuldade;
        private System.Windows.Forms.DataGridView dGVReceitas;
        private System.Windows.Forms.Button bntLimpar;
    }
}

