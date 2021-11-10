namespace G6_UnionDe2Proyectos
{
    partial class FrmMenu
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
            this.btnnotas = new System.Windows.Forms.Button();
            this.btnareas = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnsalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnnotas
            // 
            this.btnnotas.Location = new System.Drawing.Point(63, 143);
            this.btnnotas.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnnotas.Name = "btnnotas";
            this.btnnotas.Size = new System.Drawing.Size(115, 54);
            this.btnnotas.TabIndex = 0;
            this.btnnotas.Text = "Registro de notas";
            this.btnnotas.UseVisualStyleBackColor = true;
            this.btnnotas.Click += new System.EventHandler(this.btnnotas_Click);
            // 
            // btnareas
            // 
            this.btnareas.Location = new System.Drawing.Point(204, 143);
            this.btnareas.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnareas.Name = "btnareas";
            this.btnareas.Size = new System.Drawing.Size(101, 54);
            this.btnareas.TabIndex = 1;
            this.btnareas.Text = "Calculo de áreas";
            this.btnareas.UseVisualStyleBackColor = true;
            this.btnareas.Click += new System.EventHandler(this.btnareas_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Constantia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(186, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "Actividad 2 G6";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(200, 67);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Menú Principal";
            // 
            // btnsalir
            // 
            this.btnsalir.Location = new System.Drawing.Point(333, 143);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(115, 54);
            this.btnsalir.TabIndex = 4;
            this.btnsalir.Text = "Salir";
            this.btnsalir.UseVisualStyleBackColor = true;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 249);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnareas);
            this.Controls.Add(this.btnnotas);
            this.Font = new System.Drawing.Font("Constantia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "FrmMenu";
            this.Text = "Union de dos proyectos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnnotas;
        private System.Windows.Forms.Button btnareas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnsalir;
    }
}