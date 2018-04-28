namespace Tortuga
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
            this.txtAvanzar = new System.Windows.Forms.TextBox();
            this.txtTablero = new System.Windows.Forms.TextBox();
            this.button8 = new System.Windows.Forms.Button();
            this.btnMostrarArreglo = new System.Windows.Forms.Button();
            this.btnAvanza = new System.Windows.Forms.Button();
            this.btnGiraIzquierda = new System.Windows.Forms.Button();
            this.btnGiraDerecha = new System.Windows.Forms.Button();
            this.btnArriva = new System.Windows.Forms.Button();
            this.btnAbajo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtAvanzar
            // 
            this.txtAvanzar.Location = new System.Drawing.Point(333, 25);
            this.txtAvanzar.Name = "txtAvanzar";
            this.txtAvanzar.Size = new System.Drawing.Size(90, 20);
            this.txtAvanzar.TabIndex = 19;
            // 
            // txtTablero
            // 
            this.txtTablero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTablero.Location = new System.Drawing.Point(45, 82);
            this.txtTablero.Multiline = true;
            this.txtTablero.Name = "txtTablero";
            this.txtTablero.Size = new System.Drawing.Size(523, 453);
            this.txtTablero.TabIndex = 18;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(493, 22);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 23);
            this.button8.TabIndex = 17;
            this.button8.Text = "button8";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // btnMostrarArreglo
            // 
            this.btnMostrarArreglo.Location = new System.Drawing.Point(237, 54);
            this.btnMostrarArreglo.Name = "btnMostrarArreglo";
            this.btnMostrarArreglo.Size = new System.Drawing.Size(90, 23);
            this.btnMostrarArreglo.TabIndex = 16;
            this.btnMostrarArreglo.Text = "Mostrar Arreglo";
            this.btnMostrarArreglo.UseVisualStyleBackColor = true;
            this.btnMostrarArreglo.Click += new System.EventHandler(this.btnMostrarArreglo_Click);
            // 
            // btnAvanza
            // 
            this.btnAvanza.Location = new System.Drawing.Point(237, 23);
            this.btnAvanza.Name = "btnAvanza";
            this.btnAvanza.Size = new System.Drawing.Size(90, 23);
            this.btnAvanza.TabIndex = 15;
            this.btnAvanza.Text = "Avanzar ";
            this.btnAvanza.UseVisualStyleBackColor = true;
            this.btnAvanza.Click += new System.EventHandler(this.btnAvanza_Click);
            // 
            // btnGiraIzquierda
            // 
            this.btnGiraIzquierda.Location = new System.Drawing.Point(141, 53);
            this.btnGiraIzquierda.Name = "btnGiraIzquierda";
            this.btnGiraIzquierda.Size = new System.Drawing.Size(90, 23);
            this.btnGiraIzquierda.TabIndex = 13;
            this.btnGiraIzquierda.Text = "Gira Izquierda";
            this.btnGiraIzquierda.UseVisualStyleBackColor = true;
            this.btnGiraIzquierda.Click += new System.EventHandler(this.btnGiraIzquierda_Click);
            // 
            // btnGiraDerecha
            // 
            this.btnGiraDerecha.Location = new System.Drawing.Point(45, 53);
            this.btnGiraDerecha.Name = "btnGiraDerecha";
            this.btnGiraDerecha.Size = new System.Drawing.Size(90, 23);
            this.btnGiraDerecha.TabIndex = 12;
            this.btnGiraDerecha.Text = "Gira Derecha";
            this.btnGiraDerecha.UseVisualStyleBackColor = true;
            this.btnGiraDerecha.Click += new System.EventHandler(this.btnGiraDerecha_Click);
            // 
            // btnArriva
            // 
            this.btnArriva.Location = new System.Drawing.Point(141, 23);
            this.btnArriva.Name = "btnArriva";
            this.btnArriva.Size = new System.Drawing.Size(90, 23);
            this.btnArriva.TabIndex = 11;
            this.btnArriva.Text = "Pluma Arriva";
            this.btnArriva.UseVisualStyleBackColor = true;
            this.btnArriva.Click += new System.EventHandler(this.btnArriva_Click);
            // 
            // btnAbajo
            // 
            this.btnAbajo.Location = new System.Drawing.Point(45, 23);
            this.btnAbajo.Name = "btnAbajo";
            this.btnAbajo.Size = new System.Drawing.Size(90, 23);
            this.btnAbajo.TabIndex = 10;
            this.btnAbajo.Text = "Pluma Abajo";
            this.btnAbajo.UseVisualStyleBackColor = true;
            this.btnAbajo.Click += new System.EventHandler(this.btnAbajo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 557);
            this.Controls.Add(this.txtAvanzar);
            this.Controls.Add(this.txtTablero);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.btnMostrarArreglo);
            this.Controls.Add(this.btnAvanza);
            this.Controls.Add(this.btnGiraIzquierda);
            this.Controls.Add(this.btnGiraDerecha);
            this.Controls.Add(this.btnArriva);
            this.Controls.Add(this.btnAbajo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAvanzar;
        private System.Windows.Forms.TextBox txtTablero;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button btnMostrarArreglo;
        private System.Windows.Forms.Button btnAvanza;
        private System.Windows.Forms.Button btnGiraIzquierda;
        private System.Windows.Forms.Button btnGiraDerecha;
        private System.Windows.Forms.Button btnArriva;
        private System.Windows.Forms.Button btnAbajo;
    }
}

