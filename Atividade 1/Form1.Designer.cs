namespace Atividade_1
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tx_nome = new System.Windows.Forms.TextBox();
            this.tx_idade = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tx_resultado = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Nome = new System.Windows.Forms.Label();
            this.mask_cpf = new System.Windows.Forms.MaskedTextBox();
            this.num_peso = new System.Windows.Forms.NumericUpDown();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.combox_sexo = new System.Windows.Forms.ComboBox();
            this.mask_altura = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.num_peso)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Condensed", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(369, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 53);
            this.label1.TabIndex = 0;
            this.label1.Text = "Calculo de IMC";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Bahnschrift Condensed", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button1.Location = new System.Drawing.Point(602, 444);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 44);
            this.button1.TabIndex = 1;
            this.button1.Text = "Calcular";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tx_nome
            // 
            this.tx_nome.Location = new System.Drawing.Point(124, 115);
            this.tx_nome.Name = "tx_nome";
            this.tx_nome.Size = new System.Drawing.Size(328, 22);
            this.tx_nome.TabIndex = 2;
            // 
            // tx_idade
            // 
            this.tx_idade.Location = new System.Drawing.Point(124, 207);
            this.tx_idade.Name = "tx_idade";
            this.tx_idade.Size = new System.Drawing.Size(328, 22);
            this.tx_idade.TabIndex = 7;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Bahnschrift Condensed", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button2.Location = new System.Drawing.Point(180, 444);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(125, 44);
            this.button2.TabIndex = 8;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(65, 299);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 24);
            this.label2.TabIndex = 9;
            this.label2.Text = "Peso";
            // 
            // tx_resultado
            // 
            this.tx_resultado.AutoSize = true;
            this.tx_resultado.Font = new System.Drawing.Font("Bahnschrift", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tx_resultado.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.tx_resultado.Location = new System.Drawing.Point(279, 356);
            this.tx_resultado.Name = "tx_resultado";
            this.tx_resultado.Size = new System.Drawing.Size(116, 28);
            this.tx_resultado.TabIndex = 10;
            this.tx_resultado.Text = "Resultado";
            this.tx_resultado.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(490, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 24);
            this.label4.TabIndex = 11;
            this.label4.Text = "CPF";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(481, 203);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 24);
            this.label5.TabIndex = 12;
            this.label5.Text = "Sexo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(468, 296);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 24);
            this.label6.TabIndex = 13;
            this.label6.Text = "Altura";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label7.Location = new System.Drawing.Point(58, 203);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 24);
            this.label7.TabIndex = 14;
            this.label7.Text = "Idade";
            // 
            // Nome
            // 
            this.Nome.AutoSize = true;
            this.Nome.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nome.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Nome.Location = new System.Drawing.Point(55, 113);
            this.Nome.Name = "Nome";
            this.Nome.Size = new System.Drawing.Size(63, 24);
            this.Nome.TabIndex = 15;
            this.Nome.Text = "Nome";
            // 
            // mask_cpf
            // 
            this.mask_cpf.Location = new System.Drawing.Point(541, 117);
            this.mask_cpf.Mask = "000,000,000-00";
            this.mask_cpf.Name = "mask_cpf";
            this.mask_cpf.Size = new System.Drawing.Size(328, 22);
            this.mask_cpf.TabIndex = 16;
            // 
            // num_peso
            // 
            this.num_peso.Location = new System.Drawing.Point(124, 301);
            this.num_peso.Name = "num_peso";
            this.num_peso.Size = new System.Drawing.Size(328, 22);
            this.num_peso.TabIndex = 19;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // combox_sexo
            // 
            this.combox_sexo.FormattingEnabled = true;
            this.combox_sexo.Items.AddRange(new object[] {
            "Feminino",
            "Maculino"});
            this.combox_sexo.Location = new System.Drawing.Point(541, 207);
            this.combox_sexo.Name = "combox_sexo";
            this.combox_sexo.Size = new System.Drawing.Size(328, 24);
            this.combox_sexo.TabIndex = 21;
            // 
            // mask_altura
            // 
            this.mask_altura.Location = new System.Drawing.Point(541, 301);
            this.mask_altura.Mask = "0.00";
            this.mask_altura.Name = "mask_altura";
            this.mask_altura.Size = new System.Drawing.Size(328, 22);
            this.mask_altura.TabIndex = 22;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(971, 566);
            this.Controls.Add(this.mask_altura);
            this.Controls.Add(this.combox_sexo);
            this.Controls.Add(this.num_peso);
            this.Controls.Add(this.mask_cpf);
            this.Controls.Add(this.Nome);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tx_resultado);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.tx_idade);
            this.Controls.Add(this.tx_nome);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Calculo IMC";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.num_peso)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tx_nome;
        private System.Windows.Forms.TextBox tx_idade;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label tx_resultado;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label Nome;
        private System.Windows.Forms.MaskedTextBox mask_cpf;
        private System.Windows.Forms.NumericUpDown num_peso;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ComboBox combox_sexo;
        private System.Windows.Forms.MaskedTextBox mask_altura;
    }
}

