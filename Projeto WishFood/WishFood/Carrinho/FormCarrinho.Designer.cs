namespace WishFood {
    partial class FormCarrinho {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listaProdutos = new System.Windows.Forms.ListBox();
            this.textoEndereco = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.comboEndereco = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textoValor = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listaProdutos);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(476, 255);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seu Carrinho";
            // 
            // listaProdutos
            // 
            this.listaProdutos.FormattingEnabled = true;
            this.listaProdutos.ItemHeight = 18;
            this.listaProdutos.Location = new System.Drawing.Point(0, 23);
            this.listaProdutos.Name = "listaProdutos";
            this.listaProdutos.Size = new System.Drawing.Size(471, 220);
            this.listaProdutos.TabIndex = 0;
            // 
            // textoEndereco
            // 
            this.textoEndereco.AutoSize = true;
            this.textoEndereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.textoEndereco.Location = new System.Drawing.Point(12, 293);
            this.textoEndereco.Name = "textoEndereco";
            this.textoEndereco.Size = new System.Drawing.Size(157, 18);
            this.textoEndereco.TabIndex = 1;
            this.textoEndereco.Text = "Endereço de entrega:  ";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.button2.Location = new System.Drawing.Point(12, 418);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(169, 31);
            this.button2.TabIndex = 3;
            this.button2.Text = "Forma de Pagamento";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.button3.Location = new System.Drawing.Point(187, 418);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(169, 31);
            this.button3.TabIndex = 4;
            this.button3.Text = "Finalizar compra";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // comboEndereco
            // 
            this.comboEndereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.comboEndereco.FormattingEnabled = true;
            this.comboEndereco.Location = new System.Drawing.Point(175, 290);
            this.comboEndereco.Name = "comboEndereco";
            this.comboEndereco.Size = new System.Drawing.Size(294, 26);
            this.comboEndereco.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.button1.Location = new System.Drawing.Point(362, 418);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 31);
            this.button1.TabIndex = 6;
            this.button1.Text = "Novo endereço";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textoValor
            // 
            this.textoValor.AutoSize = true;
            this.textoValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.textoValor.Location = new System.Drawing.Point(12, 342);
            this.textoValor.Name = "textoValor";
            this.textoValor.Size = new System.Drawing.Size(125, 18);
            this.textoValor.TabIndex = 7;
            this.textoValor.Text = "Valor da compra: ";
            // 
            // FormCarrinho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 473);
            this.Controls.Add(this.textoValor);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboEndereco);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textoEndereco);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormCarrinho";
            this.Text = "FormCarrinho";
            this.Load += new System.EventHandler(this.FormCarrinho_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox listaProdutos;
        private System.Windows.Forms.Label textoEndereco;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label textoValor;
        public System.Windows.Forms.ComboBox comboEndereco;
    }
}