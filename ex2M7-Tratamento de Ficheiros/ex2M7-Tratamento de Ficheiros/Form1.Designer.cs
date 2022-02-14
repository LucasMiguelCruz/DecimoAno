namespace ex2M7_Tratamento_de_Ficheiros
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.textBoxNomeFicheiro = new System.Windows.Forms.TextBox();
            this.buttonPesquisar = new System.Windows.Forms.Button();
            this.buttonLerFicheiro = new System.Windows.Forms.Button();
            this.textBoxConteudo = new System.Windows.Forms.TextBox();
            this.labelData = new System.Windows.Forms.Label();
            this.textBoxNovaLinha = new System.Windows.Forms.TextBox();
            this.buttonLimpar = new System.Windows.Forms.Button();
            this.buttonSubstituir = new System.Windows.Forms.Button();
            this.buttonAnexarLinha = new System.Windows.Forms.Button();
            this.buttonGuardar = new System.Windows.Forms.Button();
            this.buttonAbrirFicheiro = new System.Windows.Forms.Button();
            this.linkLabelSite = new System.Windows.Forms.LinkLabel();
            this.buttonSair = new System.Windows.Forms.Button();
            this.labelPastaAtual = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonExercicio1 = new System.Windows.Forms.Button();
            this.buttonExercicio2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // textBoxNomeFicheiro
            // 
            this.textBoxNomeFicheiro.Location = new System.Drawing.Point(0, 0);
            this.textBoxNomeFicheiro.Name = "textBoxNomeFicheiro";
            this.textBoxNomeFicheiro.Size = new System.Drawing.Size(400, 20);
            this.textBoxNomeFicheiro.TabIndex = 0;
            // 
            // buttonPesquisar
            // 
            this.buttonPesquisar.BackgroundImage = global::ex2M7_Tratamento_de_Ficheiros.Properties.Resources.lupa;
            this.buttonPesquisar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPesquisar.Location = new System.Drawing.Point(587, 0);
            this.buttonPesquisar.Name = "buttonPesquisar";
            this.buttonPesquisar.Size = new System.Drawing.Size(66, 45);
            this.buttonPesquisar.TabIndex = 1;
            this.buttonPesquisar.UseVisualStyleBackColor = true;
            this.buttonPesquisar.Click += new System.EventHandler(this.buttonPesquisar_Click);
            // 
            // buttonLerFicheiro
            // 
            this.buttonLerFicheiro.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLerFicheiro.Location = new System.Drawing.Point(431, 0);
            this.buttonLerFicheiro.Name = "buttonLerFicheiro";
            this.buttonLerFicheiro.Size = new System.Drawing.Size(150, 51);
            this.buttonLerFicheiro.TabIndex = 2;
            this.buttonLerFicheiro.Text = "Ler Ficheiro";
            this.buttonLerFicheiro.UseVisualStyleBackColor = true;
            this.buttonLerFicheiro.Click += new System.EventHandler(this.buttonLerFicheiro_Click);
            // 
            // textBoxConteudo
            // 
            this.textBoxConteudo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxConteudo.Location = new System.Drawing.Point(0, 27);
            this.textBoxConteudo.Multiline = true;
            this.textBoxConteudo.Name = "textBoxConteudo";
            this.textBoxConteudo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxConteudo.Size = new System.Drawing.Size(400, 328);
            this.textBoxConteudo.TabIndex = 3;
            // 
            // labelData
            // 
            this.labelData.AutoSize = true;
            this.labelData.Location = new System.Drawing.Point(659, 27);
            this.labelData.Name = "labelData";
            this.labelData.Size = new System.Drawing.Size(30, 13);
            this.labelData.TabIndex = 4;
            this.labelData.Text = "Data";
            // 
            // textBoxNovaLinha
            // 
            this.textBoxNovaLinha.Location = new System.Drawing.Point(0, 418);
            this.textBoxNovaLinha.Name = "textBoxNovaLinha";
            this.textBoxNovaLinha.Size = new System.Drawing.Size(400, 20);
            this.textBoxNovaLinha.TabIndex = 5;
            // 
            // buttonLimpar
            // 
            this.buttonLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLimpar.Location = new System.Drawing.Point(431, 57);
            this.buttonLimpar.Name = "buttonLimpar";
            this.buttonLimpar.Size = new System.Drawing.Size(150, 51);
            this.buttonLimpar.TabIndex = 6;
            this.buttonLimpar.Text = "Limpar";
            this.buttonLimpar.UseVisualStyleBackColor = true;
            this.buttonLimpar.Click += new System.EventHandler(this.buttonLimpar_Click);
            // 
            // buttonSubstituir
            // 
            this.buttonSubstituir.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSubstituir.Location = new System.Drawing.Point(431, 114);
            this.buttonSubstituir.Name = "buttonSubstituir";
            this.buttonSubstituir.Size = new System.Drawing.Size(150, 51);
            this.buttonSubstituir.TabIndex = 7;
            this.buttonSubstituir.Text = "Substituir";
            this.buttonSubstituir.UseVisualStyleBackColor = true;
            this.buttonSubstituir.Click += new System.EventHandler(this.buttonSubstituir_Click);
            // 
            // buttonAnexarLinha
            // 
            this.buttonAnexarLinha.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAnexarLinha.Location = new System.Drawing.Point(431, 171);
            this.buttonAnexarLinha.Name = "buttonAnexarLinha";
            this.buttonAnexarLinha.Size = new System.Drawing.Size(150, 51);
            this.buttonAnexarLinha.TabIndex = 8;
            this.buttonAnexarLinha.Text = "Anexar Linha";
            this.buttonAnexarLinha.UseVisualStyleBackColor = true;
            this.buttonAnexarLinha.Click += new System.EventHandler(this.buttonAnexarLinha_Click);
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGuardar.Location = new System.Drawing.Point(431, 228);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(150, 51);
            this.buttonGuardar.TabIndex = 9;
            this.buttonGuardar.Text = "Guardar";
            this.buttonGuardar.UseVisualStyleBackColor = true;
            this.buttonGuardar.Click += new System.EventHandler(this.buttonGuardar_Click);
            // 
            // buttonAbrirFicheiro
            // 
            this.buttonAbrirFicheiro.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAbrirFicheiro.Location = new System.Drawing.Point(431, 279);
            this.buttonAbrirFicheiro.Name = "buttonAbrirFicheiro";
            this.buttonAbrirFicheiro.Size = new System.Drawing.Size(150, 51);
            this.buttonAbrirFicheiro.TabIndex = 10;
            this.buttonAbrirFicheiro.Text = "Abrir Ficheiro";
            this.buttonAbrirFicheiro.UseVisualStyleBackColor = true;
            this.buttonAbrirFicheiro.Click += new System.EventHandler(this.buttonAbrirFicheiro_Click);
            // 
            // linkLabelSite
            // 
            this.linkLabelSite.AutoSize = true;
            this.linkLabelSite.Location = new System.Drawing.Point(659, 3);
            this.linkLabelSite.Name = "linkLabelSite";
            this.linkLabelSite.Size = new System.Drawing.Size(116, 13);
            this.linkLabelSite.TabIndex = 11;
            this.linkLabelSite.TabStop = true;
            this.linkLabelSite.Text = "Letra Rap do Minecraft";
            this.linkLabelSite.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelSite_LinkClicked);
            // 
            // buttonSair
            // 
            this.buttonSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSair.Location = new System.Drawing.Point(431, 336);
            this.buttonSair.Name = "buttonSair";
            this.buttonSair.Size = new System.Drawing.Size(150, 51);
            this.buttonSair.TabIndex = 12;
            this.buttonSair.Text = "Sair";
            this.buttonSair.UseVisualStyleBackColor = true;
            // 
            // labelPastaAtual
            // 
            this.labelPastaAtual.AutoSize = true;
            this.labelPastaAtual.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPastaAtual.Location = new System.Drawing.Point(596, 81);
            this.labelPastaAtual.Name = "labelPastaAtual";
            this.labelPastaAtual.Size = new System.Drawing.Size(79, 16);
            this.labelPastaAtual.TabIndex = 13;
            this.labelPastaAtual.Text = "Pasta Atual:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(595, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 24);
            this.label1.TabIndex = 14;
            this.label1.Text = "Pasta Atual:";
            // 
            // buttonExercicio1
            // 
            this.buttonExercicio1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExercicio1.Location = new System.Drawing.Point(587, 114);
            this.buttonExercicio1.Name = "buttonExercicio1";
            this.buttonExercicio1.Size = new System.Drawing.Size(150, 51);
            this.buttonExercicio1.TabIndex = 15;
            this.buttonExercicio1.Text = "Exercicio 1";
            this.buttonExercicio1.UseVisualStyleBackColor = true;
            this.buttonExercicio1.Click += new System.EventHandler(this.buttonExercicio1_Click);
            // 
            // buttonExercicio2
            // 
            this.buttonExercicio2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExercicio2.Location = new System.Drawing.Point(587, 171);
            this.buttonExercicio2.Name = "buttonExercicio2";
            this.buttonExercicio2.Size = new System.Drawing.Size(150, 51);
            this.buttonExercicio2.TabIndex = 16;
            this.buttonExercicio2.Text = "Exercicio 2";
            this.buttonExercicio2.UseVisualStyleBackColor = true;
            this.buttonExercicio2.Click += new System.EventHandler(this.buttonExercicio2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 397);
            this.Controls.Add(this.buttonExercicio2);
            this.Controls.Add(this.buttonExercicio1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelPastaAtual);
            this.Controls.Add(this.buttonSair);
            this.Controls.Add(this.linkLabelSite);
            this.Controls.Add(this.buttonAbrirFicheiro);
            this.Controls.Add(this.buttonGuardar);
            this.Controls.Add(this.buttonAnexarLinha);
            this.Controls.Add(this.buttonSubstituir);
            this.Controls.Add(this.buttonLimpar);
            this.Controls.Add(this.textBoxNovaLinha);
            this.Controls.Add(this.labelData);
            this.Controls.Add(this.textBoxConteudo);
            this.Controls.Add(this.buttonLerFicheiro);
            this.Controls.Add(this.buttonPesquisar);
            this.Controls.Add(this.textBoxNomeFicheiro);
            this.Name = "Form1";
            this.Text = "Leitura e escrita de ficheiros";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox textBoxNomeFicheiro;
        private System.Windows.Forms.Button buttonPesquisar;
        private System.Windows.Forms.Button buttonLerFicheiro;
        private System.Windows.Forms.TextBox textBoxConteudo;
        private System.Windows.Forms.Label labelData;
        private System.Windows.Forms.TextBox textBoxNovaLinha;
        private System.Windows.Forms.Button buttonLimpar;
        private System.Windows.Forms.Button buttonSubstituir;
        private System.Windows.Forms.Button buttonAnexarLinha;
        private System.Windows.Forms.Button buttonGuardar;
        private System.Windows.Forms.Button buttonAbrirFicheiro;
        private System.Windows.Forms.LinkLabel linkLabelSite;
        private System.Windows.Forms.Button buttonSair;
        private System.Windows.Forms.Label labelPastaAtual;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonExercicio1;
        private System.Windows.Forms.Button buttonExercicio2;
    }
}

