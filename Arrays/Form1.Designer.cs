namespace arreys
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnvetor = new System.Windows.Forms.Button();
            this.btntextos = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnmulti = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnvetor
            // 
            this.btnvetor.BackColor = System.Drawing.Color.DarkOrange;
            this.btnvetor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnvetor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnvetor.Location = new System.Drawing.Point(26, 48);
            this.btnvetor.Name = "btnvetor";
            this.btnvetor.Size = new System.Drawing.Size(103, 71);
            this.btnvetor.TabIndex = 0;
            this.btnvetor.Text = "teste  vetor";
            this.btnvetor.UseVisualStyleBackColor = false;
            this.btnvetor.Click += new System.EventHandler(this.btnvetor_Click);
            // 
            // btntextos
            // 
            this.btntextos.BackColor = System.Drawing.Color.DarkOrange;
            this.btntextos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btntextos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntextos.Location = new System.Drawing.Point(157, 48);
            this.btntextos.Name = "btntextos";
            this.btntextos.Size = new System.Drawing.Size(114, 71);
            this.btntextos.TabIndex = 0;
            this.btntextos.Text = "vetor textos";
            this.btntextos.UseVisualStyleBackColor = false;
            this.btntextos.Click += new System.EventHandler(this.btntextos_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(121, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Array";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(66, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Array Multidimencional";
            // 
            // btnmulti
            // 
            this.btnmulti.BackColor = System.Drawing.Color.DarkOrange;
            this.btnmulti.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnmulti.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmulti.Location = new System.Drawing.Point(99, 192);
            this.btnmulti.Name = "btnmulti";
            this.btnmulti.Size = new System.Drawing.Size(112, 58);
            this.btnmulti.TabIndex = 3;
            this.btnmulti.Text = "arrey multi";
            this.btnmulti.UseVisualStyleBackColor = false;
            this.btnmulti.Click += new System.EventHandler(this.btnmulti_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(321, 284);
            this.Controls.Add(this.btnmulti);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btntextos);
            this.Controls.Add(this.btnvetor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Array";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnvetor;
        private System.Windows.Forms.Button btntextos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnmulti;
    }
}

