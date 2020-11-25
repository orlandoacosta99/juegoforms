
namespace juego
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
            this.Salir = new System.Windows.Forms.Button();
            this.Limpiar = new System.Windows.Forms.Button();
            this.groupCodificador = new System.Windows.Forms.GroupBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtSinDecimal = new System.Windows.Forms.RichTextBox();
            this.txtDatosCodificados = new System.Windows.Forms.RichTextBox();
            this.btnCodificar = new System.Windows.Forms.Button();
            this.textCodificar = new System.Windows.Forms.TextBox();
            this.comboBoxCodificar = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupDecodificador = new System.Windows.Forms.GroupBox();
            this.txtDecodificado = new System.Windows.Forms.RichTextBox();
            this.btnDecodificar = new System.Windows.Forms.Button();
            this.textDecodificar = new System.Windows.Forms.RichTextBox();
            this.comboBoxDecodificar = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.Buscar = new System.Windows.Forms.Button();
            this.comboBoxBuscar = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupCodificador.SuspendLayout();
            this.groupDecodificador.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Salir
            // 
            this.Salir.BackColor = System.Drawing.Color.Silver;
            this.Salir.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Salir.Location = new System.Drawing.Point(42, 12);
            this.Salir.Name = "Salir";
            this.Salir.Size = new System.Drawing.Size(96, 32);
            this.Salir.TabIndex = 0;
            this.Salir.Text = "Salir";
            this.Salir.UseVisualStyleBackColor = false;
            this.Salir.Click += new System.EventHandler(this.Salir_Click);
            // 
            // Limpiar
            // 
            this.Limpiar.BackColor = System.Drawing.Color.Silver;
            this.Limpiar.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Limpiar.Location = new System.Drawing.Point(164, 12);
            this.Limpiar.Name = "Limpiar";
            this.Limpiar.Size = new System.Drawing.Size(96, 31);
            this.Limpiar.TabIndex = 1;
            this.Limpiar.Text = "Limpiar Datos";
            this.Limpiar.UseVisualStyleBackColor = false;
            this.Limpiar.Click += new System.EventHandler(this.Limpiar_Click);
            // 
            // groupCodificador
            // 
            this.groupCodificador.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.groupCodificador.Controls.Add(this.richTextBox1);
            this.groupCodificador.Controls.Add(this.label8);
            this.groupCodificador.Controls.Add(this.txtSinDecimal);
            this.groupCodificador.Controls.Add(this.txtDatosCodificados);
            this.groupCodificador.Controls.Add(this.btnCodificar);
            this.groupCodificador.Controls.Add(this.textCodificar);
            this.groupCodificador.Controls.Add(this.comboBoxCodificar);
            this.groupCodificador.Controls.Add(this.label4);
            this.groupCodificador.Controls.Add(this.label3);
            this.groupCodificador.Controls.Add(this.label2);
            this.groupCodificador.Controls.Add(this.label1);
            this.groupCodificador.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupCodificador.Location = new System.Drawing.Point(42, 60);
            this.groupCodificador.Name = "groupCodificador";
            this.groupCodificador.Size = new System.Drawing.Size(374, 547);
            this.groupCodificador.TabIndex = 2;
            this.groupCodificador.TabStop = false;
            this.groupCodificador.Text = "Codificador";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(36, 241);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(303, 65);
            this.richTextBox1.TabIndex = 10;
            this.richTextBox1.Text = "";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(32, 206);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(143, 18);
            this.label8.TabIndex = 9;
            this.label8.Text = "Palabra Codificada";
            // 
            // txtSinDecimal
            // 
            this.txtSinDecimal.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSinDecimal.Location = new System.Drawing.Point(33, 464);
            this.txtSinDecimal.Name = "txtSinDecimal";
            this.txtSinDecimal.Size = new System.Drawing.Size(303, 65);
            this.txtSinDecimal.TabIndex = 8;
            this.txtSinDecimal.Text = "";
            // 
            // txtDatosCodificados
            // 
            this.txtDatosCodificados.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDatosCodificados.Location = new System.Drawing.Point(34, 348);
            this.txtDatosCodificados.Name = "txtDatosCodificados";
            this.txtDatosCodificados.Size = new System.Drawing.Size(303, 65);
            this.txtDatosCodificados.TabIndex = 7;
            this.txtDatosCodificados.Text = "";
            // 
            // btnCodificar
            // 
            this.btnCodificar.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnCodificar.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCodificar.ForeColor = System.Drawing.Color.DarkRed;
            this.btnCodificar.Location = new System.Drawing.Point(122, 167);
            this.btnCodificar.Name = "btnCodificar";
            this.btnCodificar.Size = new System.Drawing.Size(119, 36);
            this.btnCodificar.TabIndex = 6;
            this.btnCodificar.Text = "Cifrar Datos";
            this.btnCodificar.UseVisualStyleBackColor = false;
            // 
            // textCodificar
            // 
            this.textCodificar.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textCodificar.Location = new System.Drawing.Point(34, 73);
            this.textCodificar.Name = "textCodificar";
            this.textCodificar.Size = new System.Drawing.Size(304, 26);
            this.textCodificar.TabIndex = 5;
            // 
            // comboBoxCodificar
            // 
            this.comboBoxCodificar.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxCodificar.FormattingEnabled = true;
            this.comboBoxCodificar.Items.AddRange(new object[] {
            "a",
            "b",
            "c",
            "d",
            "e",
            "f",
            "g",
            "h",
            "i",
            "j",
            "k",
            "l",
            "m",
            "n",
            "ñ",
            "o",
            "p",
            "q",
            "r",
            "s",
            "t",
            "u",
            "v",
            "w",
            "x",
            "y",
            "z"});
            this.comboBoxCodificar.Location = new System.Drawing.Point(35, 123);
            this.comboBoxCodificar.Name = "comboBoxCodificar";
            this.comboBoxCodificar.Size = new System.Drawing.Size(305, 26);
            this.comboBoxCodificar.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(31, 428);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(230, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Datos Codificados sin Decimal";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(31, 317);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Datos Codificados";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Letra Pista";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese texto a codificar";
            // 
            // groupDecodificador
            // 
            this.groupDecodificador.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.groupDecodificador.Controls.Add(this.txtDecodificado);
            this.groupDecodificador.Controls.Add(this.btnDecodificar);
            this.groupDecodificador.Controls.Add(this.textDecodificar);
            this.groupDecodificador.Controls.Add(this.comboBoxDecodificar);
            this.groupDecodificador.Controls.Add(this.label7);
            this.groupDecodificador.Controls.Add(this.label6);
            this.groupDecodificador.Controls.Add(this.label5);
            this.groupDecodificador.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupDecodificador.Location = new System.Drawing.Point(446, 60);
            this.groupDecodificador.Name = "groupDecodificador";
            this.groupDecodificador.Size = new System.Drawing.Size(371, 401);
            this.groupDecodificador.TabIndex = 0;
            this.groupDecodificador.TabStop = false;
            this.groupDecodificador.Text = "Decodificador";
            // 
            // txtDecodificado
            // 
            this.txtDecodificado.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDecodificado.Location = new System.Drawing.Point(36, 302);
            this.txtDecodificado.Name = "txtDecodificado";
            this.txtDecodificado.Size = new System.Drawing.Size(303, 65);
            this.txtDecodificado.TabIndex = 9;
            this.txtDecodificado.Text = "";
            // 
            // btnDecodificar
            // 
            this.btnDecodificar.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnDecodificar.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDecodificar.ForeColor = System.Drawing.Color.DarkRed;
            this.btnDecodificar.Location = new System.Drawing.Point(141, 229);
            this.btnDecodificar.Name = "btnDecodificar";
            this.btnDecodificar.Size = new System.Drawing.Size(121, 36);
            this.btnDecodificar.TabIndex = 7;
            this.btnDecodificar.Text = "Decodificar Datos";
            this.btnDecodificar.UseVisualStyleBackColor = false;
            // 
            // textDecodificar
            // 
            this.textDecodificar.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textDecodificar.Location = new System.Drawing.Point(36, 67);
            this.textDecodificar.Name = "textDecodificar";
            this.textDecodificar.Size = new System.Drawing.Size(303, 69);
            this.textDecodificar.TabIndex = 4;
            this.textDecodificar.Text = "";
            // 
            // comboBoxDecodificar
            // 
            this.comboBoxDecodificar.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxDecodificar.FormattingEnabled = true;
            this.comboBoxDecodificar.Items.AddRange(new object[] {
            "a",
            "b",
            "c",
            "d",
            "e",
            "f",
            "g",
            "h",
            "i",
            "j",
            "k",
            "l",
            "m",
            "n",
            "ñ",
            "o",
            "p",
            "q",
            "r",
            "s",
            "t",
            "u",
            "v",
            "w",
            "x",
            "y",
            "z"});
            this.comboBoxDecodificar.Location = new System.Drawing.Point(38, 177);
            this.comboBoxDecodificar.Name = "comboBoxDecodificar";
            this.comboBoxDecodificar.Size = new System.Drawing.Size(301, 26);
            this.comboBoxDecodificar.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(33, 268);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(159, 18);
            this.label7.TabIndex = 2;
            this.label7.Text = "Datos Decodificados";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(33, 149);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 18);
            this.label6.TabIndex = 1;
            this.label6.Text = "Letra pista";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(35, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 18);
            this.label5.TabIndex = 0;
            this.label5.Text = "Códico Cifrado";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.groupBox1.Controls.Add(this.richTextBox2);
            this.groupBox1.Controls.Add(this.Buscar);
            this.groupBox1.Controls.Add(this.comboBoxBuscar);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(849, 60);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(371, 286);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Palabra Aleatorea";
            // 
            // richTextBox2
            // 
            this.richTextBox2.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox2.Location = new System.Drawing.Point(36, 177);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(303, 65);
            this.richTextBox2.TabIndex = 9;
            this.richTextBox2.Text = "";
            // 
            // Buscar
            // 
            this.Buscar.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.Buscar.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Buscar.ForeColor = System.Drawing.Color.DarkRed;
            this.Buscar.Location = new System.Drawing.Point(124, 102);
            this.Buscar.Name = "Buscar";
            this.Buscar.Size = new System.Drawing.Size(121, 36);
            this.Buscar.TabIndex = 7;
            this.Buscar.Text = "Buscar";
            this.Buscar.UseVisualStyleBackColor = false;
            // 
            // comboBoxBuscar
            // 
            this.comboBoxBuscar.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxBuscar.FormattingEnabled = true;
            this.comboBoxBuscar.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.comboBoxBuscar.Location = new System.Drawing.Point(38, 67);
            this.comboBoxBuscar.Name = "comboBoxBuscar";
            this.comboBoxBuscar.Size = new System.Drawing.Size(301, 26);
            this.comboBoxBuscar.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(36, 149);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 18);
            this.label9.TabIndex = 2;
            this.label9.Text = "Datos";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(33, 40);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 18);
            this.label10.TabIndex = 1;
            this.label10.Text = "Ronda";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1255, 619);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupDecodificador);
            this.Controls.Add(this.groupCodificador);
            this.Controls.Add(this.Limpiar);
            this.Controls.Add(this.Salir);
            this.Name = "Form1";
            this.Text = "Juego";
            this.groupCodificador.ResumeLayout(false);
            this.groupCodificador.PerformLayout();
            this.groupDecodificador.ResumeLayout(false);
            this.groupDecodificador.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Salir;
        private System.Windows.Forms.Button Limpiar;
        private System.Windows.Forms.GroupBox groupCodificador;
        private System.Windows.Forms.Button btnCodificar;
        private System.Windows.Forms.TextBox textCodificar;
        private System.Windows.Forms.ComboBox comboBoxCodificar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupDecodificador;
        private System.Windows.Forms.Button btnDecodificar;
        private System.Windows.Forms.RichTextBox textDecodificar;
        private System.Windows.Forms.ComboBox comboBoxDecodificar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox txtSinDecimal;
        private System.Windows.Forms.RichTextBox txtDatosCodificados;
        private System.Windows.Forms.RichTextBox txtDecodificado;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.Button Buscar;
        private System.Windows.Forms.ComboBox comboBoxBuscar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
    }
}

