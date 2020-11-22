namespace Calculadora
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtpantalla = new System.Windows.Forms.TextBox();
            this.txtresultado = new System.Windows.Forms.TextBox();
            this.btnigual = new System.Windows.Forms.Button();
            this.btnsuma = new System.Windows.Forms.Button();
            this.btnresta = new System.Windows.Forms.Button();
            this.btnMultiplicacion = new System.Windows.Forms.Button();
            this.btnDivicion = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btnporcentaje = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btnfactorial = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btnlimpiar = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btnpunto = new System.Windows.Forms.Button();
            this.lblsalir = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtpantalla
            // 
            this.txtpantalla.BackColor = System.Drawing.Color.FloralWhite;
            this.txtpantalla.Font = new System.Drawing.Font("Goudy Old Style", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpantalla.ForeColor = System.Drawing.Color.Black;
            this.txtpantalla.Location = new System.Drawing.Point(32, 25);
            this.txtpantalla.Multiline = true;
            this.txtpantalla.Name = "txtpantalla";
            this.txtpantalla.Size = new System.Drawing.Size(231, 32);
            this.txtpantalla.TabIndex = 0;
            // 
            // txtresultado
            // 
            this.txtresultado.BackColor = System.Drawing.Color.FloralWhite;
            this.txtresultado.Font = new System.Drawing.Font("Goudy Old Style", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtresultado.ForeColor = System.Drawing.Color.Black;
            this.txtresultado.Location = new System.Drawing.Point(146, 83);
            this.txtresultado.Multiline = true;
            this.txtresultado.Name = "txtresultado";
            this.txtresultado.Size = new System.Drawing.Size(117, 32);
            this.txtresultado.TabIndex = 1;
            // 
            // btnigual
            // 
            this.btnigual.BackColor = System.Drawing.Color.FloralWhite;
            this.btnigual.Font = new System.Drawing.Font("Goudy Old Style", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnigual.ForeColor = System.Drawing.Color.Black;
            this.btnigual.Location = new System.Drawing.Point(32, 83);
            this.btnigual.Name = "btnigual";
            this.btnigual.Size = new System.Drawing.Size(70, 35);
            this.btnigual.TabIndex = 2;
            this.btnigual.Text = "=";
            this.btnigual.UseVisualStyleBackColor = false;
            // 
            // btnsuma
            // 
            this.btnsuma.BackColor = System.Drawing.Color.FloralWhite;
            this.btnsuma.Font = new System.Drawing.Font("Goudy Old Style", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsuma.ForeColor = System.Drawing.Color.Black;
            this.btnsuma.Location = new System.Drawing.Point(32, 153);
            this.btnsuma.Name = "btnsuma";
            this.btnsuma.Size = new System.Drawing.Size(47, 35);
            this.btnsuma.TabIndex = 3;
            this.btnsuma.Text = "+";
            this.btnsuma.UseVisualStyleBackColor = false;
            // 
            // btnresta
            // 
            this.btnresta.BackColor = System.Drawing.Color.FloralWhite;
            this.btnresta.Font = new System.Drawing.Font("Goudy Old Style", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnresta.ForeColor = System.Drawing.Color.Black;
            this.btnresta.Location = new System.Drawing.Point(98, 153);
            this.btnresta.Name = "btnresta";
            this.btnresta.Size = new System.Drawing.Size(47, 35);
            this.btnresta.TabIndex = 4;
            this.btnresta.Text = "-";
            this.btnresta.UseVisualStyleBackColor = false;
            // 
            // btnMultiplicacion
            // 
            this.btnMultiplicacion.BackColor = System.Drawing.Color.FloralWhite;
            this.btnMultiplicacion.Font = new System.Drawing.Font("Goudy Old Style", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMultiplicacion.ForeColor = System.Drawing.Color.Black;
            this.btnMultiplicacion.Location = new System.Drawing.Point(159, 153);
            this.btnMultiplicacion.Name = "btnMultiplicacion";
            this.btnMultiplicacion.Size = new System.Drawing.Size(47, 35);
            this.btnMultiplicacion.TabIndex = 5;
            this.btnMultiplicacion.Text = "*";
            this.btnMultiplicacion.UseVisualStyleBackColor = false;
            // 
            // btnDivicion
            // 
            this.btnDivicion.BackColor = System.Drawing.Color.FloralWhite;
            this.btnDivicion.Font = new System.Drawing.Font("Goudy Old Style", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDivicion.ForeColor = System.Drawing.Color.Black;
            this.btnDivicion.Location = new System.Drawing.Point(216, 153);
            this.btnDivicion.Name = "btnDivicion";
            this.btnDivicion.Size = new System.Drawing.Size(47, 35);
            this.btnDivicion.TabIndex = 6;
            this.btnDivicion.Text = "/";
            this.btnDivicion.UseVisualStyleBackColor = false;
            // 
            // btn7
            // 
            this.btn7.BackColor = System.Drawing.Color.FloralWhite;
            this.btn7.Font = new System.Drawing.Font("Goudy Old Style", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn7.ForeColor = System.Drawing.Color.Black;
            this.btn7.Location = new System.Drawing.Point(32, 207);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(47, 35);
            this.btn7.TabIndex = 7;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = false;
            // 
            // btn8
            // 
            this.btn8.BackColor = System.Drawing.Color.FloralWhite;
            this.btn8.Font = new System.Drawing.Font("Goudy Old Style", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn8.ForeColor = System.Drawing.Color.Black;
            this.btn8.Location = new System.Drawing.Point(98, 207);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(47, 35);
            this.btn8.TabIndex = 8;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = false;
            // 
            // btn9
            // 
            this.btn9.BackColor = System.Drawing.Color.FloralWhite;
            this.btn9.Font = new System.Drawing.Font("Goudy Old Style", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn9.ForeColor = System.Drawing.Color.Black;
            this.btn9.Location = new System.Drawing.Point(159, 207);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(47, 35);
            this.btn9.TabIndex = 9;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = false;
            // 
            // btnporcentaje
            // 
            this.btnporcentaje.BackColor = System.Drawing.Color.FloralWhite;
            this.btnporcentaje.Font = new System.Drawing.Font("Goudy Old Style", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnporcentaje.ForeColor = System.Drawing.Color.Black;
            this.btnporcentaje.Location = new System.Drawing.Point(216, 207);
            this.btnporcentaje.Name = "btnporcentaje";
            this.btnporcentaje.Size = new System.Drawing.Size(47, 35);
            this.btnporcentaje.TabIndex = 10;
            this.btnporcentaje.Text = "%";
            this.btnporcentaje.UseVisualStyleBackColor = false;
            // 
            // btn4
            // 
            this.btn4.BackColor = System.Drawing.Color.FloralWhite;
            this.btn4.Font = new System.Drawing.Font("Goudy Old Style", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn4.ForeColor = System.Drawing.Color.Black;
            this.btn4.Location = new System.Drawing.Point(32, 256);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(47, 35);
            this.btn4.TabIndex = 11;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = false;
            // 
            // btn5
            // 
            this.btn5.BackColor = System.Drawing.Color.FloralWhite;
            this.btn5.Font = new System.Drawing.Font("Goudy Old Style", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn5.ForeColor = System.Drawing.Color.Black;
            this.btn5.Location = new System.Drawing.Point(98, 256);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(47, 35);
            this.btn5.TabIndex = 12;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = false;
            // 
            // btn6
            // 
            this.btn6.BackColor = System.Drawing.Color.FloralWhite;
            this.btn6.Font = new System.Drawing.Font("Goudy Old Style", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn6.ForeColor = System.Drawing.Color.Black;
            this.btn6.Location = new System.Drawing.Point(159, 256);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(47, 35);
            this.btn6.TabIndex = 13;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = false;
            // 
            // btnfactorial
            // 
            this.btnfactorial.BackColor = System.Drawing.Color.FloralWhite;
            this.btnfactorial.Font = new System.Drawing.Font("Goudy Old Style", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnfactorial.ForeColor = System.Drawing.Color.Black;
            this.btnfactorial.Location = new System.Drawing.Point(216, 256);
            this.btnfactorial.Name = "btnfactorial";
            this.btnfactorial.Size = new System.Drawing.Size(47, 35);
            this.btnfactorial.TabIndex = 14;
            this.btnfactorial.Text = "n!";
            this.btnfactorial.UseVisualStyleBackColor = false;
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.Color.FloralWhite;
            this.btn1.Font = new System.Drawing.Font("Goudy Old Style", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1.ForeColor = System.Drawing.Color.Black;
            this.btn1.Location = new System.Drawing.Point(32, 307);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(47, 35);
            this.btn1.TabIndex = 15;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = false;
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.Color.FloralWhite;
            this.btn2.Font = new System.Drawing.Font("Goudy Old Style", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2.ForeColor = System.Drawing.Color.Black;
            this.btn2.Location = new System.Drawing.Point(98, 307);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(47, 35);
            this.btn2.TabIndex = 16;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = false;
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.Color.FloralWhite;
            this.btn3.Font = new System.Drawing.Font("Goudy Old Style", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn3.ForeColor = System.Drawing.Color.Black;
            this.btn3.Location = new System.Drawing.Point(159, 307);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(47, 35);
            this.btn3.TabIndex = 17;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = false;
            // 
            // btnlimpiar
            // 
            this.btnlimpiar.BackColor = System.Drawing.Color.FloralWhite;
            this.btnlimpiar.Font = new System.Drawing.Font("Goudy Old Style", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlimpiar.ForeColor = System.Drawing.Color.Black;
            this.btnlimpiar.Location = new System.Drawing.Point(216, 307);
            this.btnlimpiar.Name = "btnlimpiar";
            this.btnlimpiar.Size = new System.Drawing.Size(47, 35);
            this.btnlimpiar.TabIndex = 18;
            this.btnlimpiar.Text = "CE";
            this.btnlimpiar.UseVisualStyleBackColor = false;
            // 
            // btn0
            // 
            this.btn0.BackColor = System.Drawing.Color.FloralWhite;
            this.btn0.Font = new System.Drawing.Font("Goudy Old Style", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn0.ForeColor = System.Drawing.Color.Black;
            this.btn0.Location = new System.Drawing.Point(32, 362);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(101, 35);
            this.btn0.TabIndex = 19;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = false;
            // 
            // btnpunto
            // 
            this.btnpunto.BackColor = System.Drawing.Color.FloralWhite;
            this.btnpunto.Font = new System.Drawing.Font("Goudy Old Style", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnpunto.ForeColor = System.Drawing.Color.Black;
            this.btnpunto.Location = new System.Drawing.Point(146, 362);
            this.btnpunto.Name = "btnpunto";
            this.btnpunto.Size = new System.Drawing.Size(47, 35);
            this.btnpunto.TabIndex = 20;
            this.btnpunto.Text = ".";
            this.btnpunto.UseVisualStyleBackColor = false;
            // 
            // lblsalir
            // 
            this.lblsalir.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblsalir.BackColor = System.Drawing.Color.FloralWhite;
            this.lblsalir.Font = new System.Drawing.Font("Goudy Old Style", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsalir.ForeColor = System.Drawing.Color.Black;
            this.lblsalir.Location = new System.Drawing.Point(199, 362);
            this.lblsalir.Name = "lblsalir";
            this.lblsalir.Size = new System.Drawing.Size(64, 35);
            this.lblsalir.TabIndex = 21;
            this.lblsalir.Text = "Salir\r\n";
            this.lblsalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lblsalir.Click += new System.EventHandler(this.lblsalir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(284, 450);
            this.Controls.Add(this.lblsalir);
            this.Controls.Add(this.btnpunto);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btnlimpiar);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btnfactorial);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btnporcentaje);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btnDivicion);
            this.Controls.Add(this.btnMultiplicacion);
            this.Controls.Add(this.btnresta);
            this.Controls.Add(this.btnsuma);
            this.Controls.Add(this.btnigual);
            this.Controls.Add(this.txtresultado);
            this.Controls.Add(this.txtpantalla);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox txtpantalla;
        public System.Windows.Forms.TextBox txtresultado;
        public System.Windows.Forms.Button btnigual;
        public System.Windows.Forms.Button btnsuma;
        public System.Windows.Forms.Button btnresta;
        public System.Windows.Forms.Button btnMultiplicacion;
        public System.Windows.Forms.Button btnDivicion;
        public System.Windows.Forms.Button btn7;
        public System.Windows.Forms.Button btn8;
        public System.Windows.Forms.Button btn9;
        public System.Windows.Forms.Button btnporcentaje;
        public System.Windows.Forms.Button btn4;
        public System.Windows.Forms.Button btn5;
        public System.Windows.Forms.Button btn6;
        public System.Windows.Forms.Button btnfactorial;
        public System.Windows.Forms.Button btn1;
        public System.Windows.Forms.Button btn2;
        public System.Windows.Forms.Button btn3;
        public System.Windows.Forms.Button btnlimpiar;
        public System.Windows.Forms.Button btn0;
        public System.Windows.Forms.Button btnpunto;
        public System.Windows.Forms.Label lblsalir;
    }
}

