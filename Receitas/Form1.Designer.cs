
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
            this.bntBuscar = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.txtEliminar = new System.Windows.Forms.TextBox();
            this.bntEliminar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dGVReceitas)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(143, 21);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(253, 23);
            this.textBoxNome.TabIndex = 0;
            // 
            // textBoxTempoPrep
            // 
            this.textBoxTempoPrep.Location = new System.Drawing.Point(143, 60);
            this.textBoxTempoPrep.Name = "textBoxTempoPrep";
            this.textBoxTempoPrep.Size = new System.Drawing.Size(100, 23);
            this.textBoxTempoPrep.TabIndex = 1;
            // 
            // richTextBoxDesc
            // 
            this.richTextBoxDesc.Location = new System.Drawing.Point(12, 245);
            this.richTextBoxDesc.Name = "richTextBoxDesc";
            this.richTextBoxDesc.Size = new System.Drawing.Size(384, 233);
            this.richTextBoxDesc.TabIndex = 2;
            this.richTextBoxDesc.Text = "";
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.Location = new System.Drawing.Point(12, 24);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(40, 15);
            this.lbNome.TabIndex = 6;
            this.lbNome.Text = "Nome";
            // 
            // lbTempoPrep
            // 
            this.lbTempoPrep.AutoSize = true;
            this.lbTempoPrep.Location = new System.Drawing.Point(12, 63);
            this.lbTempoPrep.Name = "lbTempoPrep";
            this.lbTempoPrep.Size = new System.Drawing.Size(121, 15);
            this.lbTempoPrep.TabIndex = 7;
            this.lbTempoPrep.Text = "Tempo de Preparação";
            // 
            // lbNumeroPessoas
            // 
            this.lbNumeroPessoas.AutoSize = true;
            this.lbNumeroPessoas.Location = new System.Drawing.Point(12, 144);
            this.lbNumeroPessoas.Name = "lbNumeroPessoas";
            this.lbNumeroPessoas.Size = new System.Drawing.Size(111, 15);
            this.lbNumeroPessoas.TabIndex = 8;
            this.lbNumeroPessoas.Text = "Numero de Pessoas";
            this.lbNumeroPessoas.Click += new System.EventHandler(this.label2_Click);
            // 
            // lbCategoria
            // 
            this.lbCategoria.AutoSize = true;
            this.lbCategoria.Location = new System.Drawing.Point(12, 184);
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
            this.buttonGravar.Location = new System.Drawing.Point(326, 484);
            this.buttonGravar.Name = "buttonGravar";
            this.buttonGravar.Size = new System.Drawing.Size(70, 23);
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
            this.cBGrauDificuldade.Location = new System.Drawing.Point(143, 102);
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
            this.cBNumeroPessoas.Location = new System.Drawing.Point(143, 141);
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
            this.cBCategoria.Location = new System.Drawing.Point(143, 181);
            this.cBCategoria.Name = "cBCategoria";
            this.cBCategoria.Size = new System.Drawing.Size(100, 23);
            this.cBCategoria.TabIndex = 16;
            // 
            // lbGrauDificuldade
            // 
            this.lbGrauDificuldade.AutoSize = true;
            this.lbGrauDificuldade.Location = new System.Drawing.Point(12, 105);
            this.lbGrauDificuldade.Name = "lbGrauDificuldade";
            this.lbGrauDificuldade.Size = new System.Drawing.Size(111, 15);
            this.lbGrauDificuldade.TabIndex = 11;
            this.lbGrauDificuldade.Text = "Grau de Dificuldade";
            // 
            // dGVReceitas
            // 
            this.dGVReceitas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVReceitas.Location = new System.Drawing.Point(423, 51);
            this.dGVReceitas.Name = "dGVReceitas";
            this.dGVReceitas.RowTemplate.Height = 25;
            this.dGVReceitas.Size = new System.Drawing.Size(747, 522);
            this.dGVReceitas.TabIndex = 17;
            // 
            // bntLimpar
            // 
            this.bntLimpar.BackColor = System.Drawing.Color.Red;
            this.bntLimpar.ForeColor = System.Drawing.Color.White;
            this.bntLimpar.Location = new System.Drawing.Point(1051, 17);
            this.bntLimpar.Name = "bntLimpar";
            this.bntLimpar.Size = new System.Drawing.Size(118, 28);
            this.bntLimpar.TabIndex = 19;
            this.bntLimpar.Text = "Limpar Tabela";
            this.bntLimpar.UseVisualStyleBackColor = false;
            this.bntLimpar.Click += new System.EventHandler(this.bntLimpar_Click_1);
            // 
            // bntBuscar
            // 
            this.bntBuscar.Location = new System.Drawing.Point(637, 22);
            this.bntBuscar.Name = "bntBuscar";
            this.bntBuscar.Size = new System.Drawing.Size(75, 23);
            this.bntBuscar.TabIndex = 20;
            this.bntBuscar.Text = "Filtrar";
            this.bntBuscar.UseVisualStyleBackColor = true;
            this.bntBuscar.Click += new System.EventHandler(this.bntBuscar_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(423, 21);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.PlaceholderText = "Nome da receita";
            this.txtBuscar.Size = new System.Drawing.Size(208, 23);
            this.txtBuscar.TabIndex = 21;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // txtEliminar
            // 
            this.txtEliminar.Location = new System.Drawing.Point(751, 21);
            this.txtEliminar.Name = "txtEliminar";
            this.txtEliminar.PlaceholderText = "ID da receita";
            this.txtEliminar.Size = new System.Drawing.Size(100, 23);
            this.txtEliminar.TabIndex = 23;
            // 
            // bntEliminar
            // 
            this.bntEliminar.Location = new System.Drawing.Point(857, 22);
            this.bntEliminar.Name = "bntEliminar";
            this.bntEliminar.Size = new System.Drawing.Size(75, 23);
            this.bntEliminar.TabIndex = 22;
            this.bntEliminar.Text = "Eliminar";
            this.bntEliminar.UseVisualStyleBackColor = true;
            this.bntEliminar.Click += new System.EventHandler(this.bntEliminar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1181, 597);
            this.Controls.Add(this.txtEliminar);
            this.Controls.Add(this.bntEliminar);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.bntBuscar);
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
            this.Load += new System.EventHandler(this.Form1_Load);
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
        private System.Windows.Forms.Button bntBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.TextBox txtEliminar;
        private System.Windows.Forms.Button bntEliminar;
    }
}

