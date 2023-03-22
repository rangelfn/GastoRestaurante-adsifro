
namespace GastoRestaurante
{
    partial class GastoRestaurante
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
            this.lblDespesa = new System.Windows.Forms.Label();
            this.txtTotalDaConta = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.txtTotalDesconto = new System.Windows.Forms.TextBox();
            this.lblDesc = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblDespesa
            // 
            this.lblDespesa.AutoSize = true;
            this.lblDespesa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblDespesa.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDespesa.Location = new System.Drawing.Point(13, 27);
            this.lblDespesa.Name = "lblDespesa";
            this.lblDespesa.Size = new System.Drawing.Size(106, 21);
            this.lblDespesa.TabIndex = 0;
            this.lblDespesa.Text = "Despesa Total";
            // 
            // txtTotalDaConta
            // 
            this.txtTotalDaConta.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalDaConta.Location = new System.Drawing.Point(125, 23);
            this.txtTotalDaConta.Name = "txtTotalDaConta";
            this.txtTotalDaConta.Size = new System.Drawing.Size(100, 29);
            this.txtTotalDaConta.TabIndex = 1;
            this.txtTotalDaConta.TextChanged += new System.EventHandler(this.txtTotalDaConta_TextChanged);
            // 
            // btnCalcular
            // 
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Location = new System.Drawing.Point(125, 58);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(99, 23);
            this.btnCalcular.TabIndex = 2;
            this.btnCalcular.Text = "CALCULAR";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // txtTotalDesconto
            // 
            this.txtTotalDesconto.BackColor = System.Drawing.Color.Yellow;
            this.txtTotalDesconto.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalDesconto.Location = new System.Drawing.Point(125, 85);
            this.txtTotalDesconto.Name = "txtTotalDesconto";
            this.txtTotalDesconto.Size = new System.Drawing.Size(100, 29);
            this.txtTotalDesconto.TabIndex = 4;
            this.txtTotalDesconto.TextChanged += new System.EventHandler(this.txtTotalDesconto_TextChanged);
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblDesc.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesc.ForeColor = System.Drawing.Color.Blue;
            this.lblDesc.Location = new System.Drawing.Point(13, 90);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(100, 21);
            this.lblDesc.TabIndex = 3;
            this.lblDesc.Text = "Total + 10%";
            // 
            // GastoRestaurante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(245, 138);
            this.Controls.Add(this.txtTotalDesconto);
            this.Controls.Add(this.lblDesc);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtTotalDaConta);
            this.Controls.Add(this.lblDespesa);
            this.Name = "GastoRestaurante";
            this.Text = "Total Gasto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDespesa;
        private System.Windows.Forms.TextBox txtTotalDaConta;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.TextBox txtTotalDesconto;
        private System.Windows.Forms.Label lblDesc;
    }
}

