namespace busquedaborradoarbol
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
            this.lblmatricula = new System.Windows.Forms.Label();
            this.lblnombre = new System.Windows.Forms.Label();
            this.lblcalifica = new System.Windows.Forms.Label();
            this.nudmatricula = new System.Windows.Forms.NumericUpDown();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.nudcalif = new System.Windows.Forms.NumericUpDown();
            this.btnagregar = new System.Windows.Forms.Button();
            this.btnconsultar = new System.Windows.Forms.Button();
            this.btnborrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudmatricula)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudcalif)).BeginInit();
            this.SuspendLayout();
            // 
            // lblmatricula
            // 
            this.lblmatricula.AutoSize = true;
            this.lblmatricula.Location = new System.Drawing.Point(81, 40);
            this.lblmatricula.Name = "lblmatricula";
            this.lblmatricula.Size = new System.Drawing.Size(57, 15);
            this.lblmatricula.TabIndex = 0;
            this.lblmatricula.Text = "Matricula";
            // 
            // lblnombre
            // 
            this.lblnombre.AutoSize = true;
            this.lblnombre.Location = new System.Drawing.Point(81, 73);
            this.lblnombre.Name = "lblnombre";
            this.lblnombre.Size = new System.Drawing.Size(51, 15);
            this.lblnombre.TabIndex = 1;
            this.lblnombre.Text = "Nombre";
            // 
            // lblcalifica
            // 
            this.lblcalifica.AutoSize = true;
            this.lblcalifica.Location = new System.Drawing.Point(81, 112);
            this.lblcalifica.Name = "lblcalifica";
            this.lblcalifica.Size = new System.Drawing.Size(69, 15);
            this.lblcalifica.TabIndex = 2;
            this.lblcalifica.Text = "Calificación";
            // 
            // nudmatricula
            // 
            this.nudmatricula.Location = new System.Drawing.Point(168, 39);
            this.nudmatricula.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudmatricula.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudmatricula.Name = "nudmatricula";
            this.nudmatricula.Size = new System.Drawing.Size(164, 23);
            this.nudmatricula.TabIndex = 3;
            this.nudmatricula.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(173, 70);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(202, 23);
            this.txtnombre.TabIndex = 4;
            // 
            // nudcalif
            // 
            this.nudcalif.DecimalPlaces = 2;
            this.nudcalif.Location = new System.Drawing.Point(173, 104);
            this.nudcalif.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudcalif.Name = "nudcalif";
            this.nudcalif.Size = new System.Drawing.Size(89, 23);
            this.nudcalif.TabIndex = 5;
            // 
            // btnagregar
            // 
            this.btnagregar.Location = new System.Drawing.Point(90, 163);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(75, 23);
            this.btnagregar.TabIndex = 6;
            this.btnagregar.Text = "agregar";
            this.btnagregar.UseVisualStyleBackColor = true;
            this.btnagregar.Click += new System.EventHandler(this.btnagregar_Click);
            // 
            // btnconsultar
            // 
            this.btnconsultar.Location = new System.Drawing.Point(187, 163);
            this.btnconsultar.Name = "btnconsultar";
            this.btnconsultar.Size = new System.Drawing.Size(75, 23);
            this.btnconsultar.TabIndex = 7;
            this.btnconsultar.Text = "consultar";
            this.btnconsultar.UseVisualStyleBackColor = true;
            this.btnconsultar.Click += new System.EventHandler(this.btnconsultar_Click);
            // 
            // btnborrar
            // 
            this.btnborrar.Location = new System.Drawing.Point(288, 163);
            this.btnborrar.Name = "btnborrar";
            this.btnborrar.Size = new System.Drawing.Size(75, 23);
            this.btnborrar.TabIndex = 8;
            this.btnborrar.Text = "Borrar";
            this.btnborrar.UseVisualStyleBackColor = true;
            this.btnborrar.Click += new System.EventHandler(this.btnborrar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnborrar);
            this.Controls.Add(this.btnconsultar);
            this.Controls.Add(this.btnagregar);
            this.Controls.Add(this.nudcalif);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.nudmatricula);
            this.Controls.Add(this.lblcalifica);
            this.Controls.Add(this.lblnombre);
            this.Controls.Add(this.lblmatricula);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nudmatricula)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudcalif)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblmatricula;
        private System.Windows.Forms.Label lblnombre;
        private System.Windows.Forms.Label lblcalifica;
        private System.Windows.Forms.NumericUpDown nudmatricula;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.NumericUpDown nudcalif;
        private System.Windows.Forms.Button btnagregar;
        private System.Windows.Forms.Button btnconsultar;
        private System.Windows.Forms.Button btnborrar;
    }
}
