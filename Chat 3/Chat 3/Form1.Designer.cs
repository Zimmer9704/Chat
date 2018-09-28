namespace Chat_3
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
            this.btnconectar = new System.Windows.Forms.Button();
            this.btniniciar = new System.Windows.Forms.Button();
            this.btnenviar = new System.Windows.Forms.Button();
            this.mensajebox = new System.Windows.Forms.TextBox();
            this.Chatscreen = new System.Windows.Forms.TextBox();
            this.Puertocliente = new System.Windows.Forms.TextBox();
            this.Ipcliente = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Puertoserver = new System.Windows.Forms.TextBox();
            this.IPserver = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnconectar
            // 
            this.btnconectar.Location = new System.Drawing.Point(635, 256);
            this.btnconectar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnconectar.Name = "btnconectar";
            this.btnconectar.Size = new System.Drawing.Size(84, 29);
            this.btnconectar.TabIndex = 28;
            this.btnconectar.Text = "Conectar";
            this.btnconectar.UseVisualStyleBackColor = true;
            this.btnconectar.Click += new System.EventHandler(this.btnconectar_Click);
            // 
            // btniniciar
            // 
            this.btniniciar.Location = new System.Drawing.Point(635, 110);
            this.btniniciar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btniniciar.Name = "btniniciar";
            this.btniniciar.Size = new System.Drawing.Size(84, 29);
            this.btniniciar.TabIndex = 27;
            this.btniniciar.Text = "Iniciar";
            this.btniniciar.UseVisualStyleBackColor = true;
            this.btniniciar.Click += new System.EventHandler(this.btniniciar_Click);
            // 
            // btnenviar
            // 
            this.btnenviar.Location = new System.Drawing.Point(706, 715);
            this.btnenviar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnenviar.Name = "btnenviar";
            this.btnenviar.Size = new System.Drawing.Size(117, 46);
            this.btnenviar.TabIndex = 26;
            this.btnenviar.Text = "Enviar";
            this.btnenviar.UseVisualStyleBackColor = true;
            this.btnenviar.Click += new System.EventHandler(this.btnenviar_Click);
            // 
            // mensajebox
            // 
            this.mensajebox.Location = new System.Drawing.Point(51, 727);
            this.mensajebox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.mensajebox.Name = "mensajebox";
            this.mensajebox.Size = new System.Drawing.Size(602, 22);
            this.mensajebox.TabIndex = 25;
            // 
            // Chatscreen
            // 
            this.Chatscreen.Location = new System.Drawing.Point(37, 323);
            this.Chatscreen.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Chatscreen.Multiline = true;
            this.Chatscreen.Name = "Chatscreen";
            this.Chatscreen.Size = new System.Drawing.Size(786, 330);
            this.Chatscreen.TabIndex = 24;
            // 
            // Puertocliente
            // 
            this.Puertocliente.Location = new System.Drawing.Point(419, 256);
            this.Puertocliente.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Puertocliente.Name = "Puertocliente";
            this.Puertocliente.Size = new System.Drawing.Size(195, 22);
            this.Puertocliente.TabIndex = 23;
            // 
            // Ipcliente
            // 
            this.Ipcliente.Location = new System.Drawing.Point(108, 256);
            this.Ipcliente.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Ipcliente.Name = "Ipcliente";
            this.Ipcliente.Size = new System.Drawing.Size(195, 22);
            this.Ipcliente.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 192);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 17);
            this.label6.TabIndex = 21;
            this.label6.Text = "Cliente";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(344, 262);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 17);
            this.label5.TabIndex = 20;
            this.label5.Text = "Puerto";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 262);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 17);
            this.label4.TabIndex = 19;
            this.label4.Text = "IP";
            // 
            // Puertoserver
            // 
            this.Puertoserver.Location = new System.Drawing.Point(419, 110);
            this.Puertoserver.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Puertoserver.Name = "Puertoserver";
            this.Puertoserver.Size = new System.Drawing.Size(195, 22);
            this.Puertoserver.TabIndex = 18;
            // 
            // IPserver
            // 
            this.IPserver.Location = new System.Drawing.Point(108, 116);
            this.IPserver.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.IPserver.Name = "IPserver";
            this.IPserver.Size = new System.Drawing.Size(195, 22);
            this.IPserver.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 17);
            this.label2.TabIndex = 16;
            this.label2.Text = "IP";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 17);
            this.label1.TabIndex = 15;
            this.label1.Text = "Servidor";
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // backgroundWorker2
            // 
            this.backgroundWorker2.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker2_DoWork);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(344, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 17);
            this.label3.TabIndex = 29;
            this.label3.Text = "Puerto";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 820);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnconectar);
            this.Controls.Add(this.btniniciar);
            this.Controls.Add(this.btnenviar);
            this.Controls.Add(this.mensajebox);
            this.Controls.Add(this.Chatscreen);
            this.Controls.Add(this.Puertocliente);
            this.Controls.Add(this.Ipcliente);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Puertoserver);
            this.Controls.Add(this.IPserver);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnconectar;
        private System.Windows.Forms.Button btniniciar;
        private System.Windows.Forms.Button btnenviar;
        private System.Windows.Forms.TextBox mensajebox;
        private System.Windows.Forms.TextBox Chatscreen;
        private System.Windows.Forms.TextBox Puertocliente;
        private System.Windows.Forms.TextBox Ipcliente;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Puertoserver;
        private System.Windows.Forms.TextBox IPserver;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.Label label3;
    }
}

