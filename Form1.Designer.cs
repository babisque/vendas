namespace Aula30
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
            this.txtProduto = new System.Windows.Forms.TextBox();
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.lblNome = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbNome = new System.Windows.Forms.ListBox();
            this.lbPreco = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblPrecoTotal = new System.Windows.Forms.Label();
            this.btRemover = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtProduto
            // 
            this.txtProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProduto.Location = new System.Drawing.Point(16, 64);
            this.txtProduto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtProduto.Name = "txtProduto";
            this.txtProduto.Size = new System.Drawing.Size(209, 26);
            this.txtProduto.TabIndex = 0;
            // 
            // txtPreco
            // 
            this.txtPreco.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPreco.Location = new System.Drawing.Point(269, 64);
            this.txtPreco.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(209, 26);
            this.txtPreco.TabIndex = 0;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Location = new System.Drawing.Point(508, 60);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(141, 35);
            this.btnSalvar.TabIndex = 1;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(19, 36);
            this.lblNome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(55, 20);
            this.lblNome.TabIndex = 2;
            this.lblNome.Text = "Nome:";
            this.lblNome.Click += new System.EventHandler(this.lblNome_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(273, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Preço:";
            this.label1.Click += new System.EventHandler(this.lblNome_Click);
            // 
            // lbNome
            // 
            this.lbNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNome.FormattingEnabled = true;
            this.lbNome.ItemHeight = 16;
            this.lbNome.Location = new System.Drawing.Point(16, 126);
            this.lbNome.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(209, 388);
            this.lbNome.TabIndex = 3;
            // 
            // lbPreco
            // 
            this.lbPreco.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPreco.FormattingEnabled = true;
            this.lbPreco.ItemHeight = 16;
            this.lbPreco.Location = new System.Drawing.Point(269, 126);
            this.lbPreco.Margin = new System.Windows.Forms.Padding(4);
            this.lbPreco.Name = "lbPreco";
            this.lbPreco.Size = new System.Drawing.Size(209, 388);
            this.lbPreco.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(505, 389);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Valor total:";
            // 
            // lblPrecoTotal
            // 
            this.lblPrecoTotal.AutoSize = true;
            this.lblPrecoTotal.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecoTotal.Location = new System.Drawing.Point(608, 389);
            this.lblPrecoTotal.Name = "lblPrecoTotal";
            this.lblPrecoTotal.Size = new System.Drawing.Size(34, 25);
            this.lblPrecoTotal.TabIndex = 4;
            this.lblPrecoTotal.Text = "R$";
            // 
            // btRemover
            // 
            this.btRemover.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRemover.Location = new System.Drawing.Point(508, 126);
            this.btRemover.Name = "btRemover";
            this.btRemover.Size = new System.Drawing.Size(141, 35);
            this.btRemover.TabIndex = 5;
            this.btRemover.Text = "Remover";
            this.btRemover.UseVisualStyleBackColor = true;
            this.btRemover.Click += new System.EventHandler(this.btRemover_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 554);
            this.Controls.Add(this.btRemover);
            this.Controls.Add(this.lblPrecoTotal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbPreco);
            this.Controls.Add(this.lbNome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.txtPreco);
            this.Controls.Add(this.txtProduto);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtProduto;
        private System.Windows.Forms.TextBox txtPreco;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbNome;
        private System.Windows.Forms.ListBox lbPreco;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblPrecoTotal;
        private System.Windows.Forms.Button btRemover;
    }
}

