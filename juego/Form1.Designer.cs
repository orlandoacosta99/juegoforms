
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
            this.btnCodificar = new System.Windows.Forms.Button();
            this.textCodificar = new System.Windows.Forms.TextBox();
            this.comboBoxCodificar = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupDecodificador = new System.Windows.Forms.GroupBox();
            this.btnDecodificar = new System.Windows.Forms.Button();
            this.textDecodificar = new System.Windows.Forms.RichTextBox();
            this.comboBoxDecodificar = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupCodificador.SuspendLayout();
            this.groupDecodificador.SuspendLayout();
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
            this.groupCodificador.BackColor = System.Drawing.SystemColors.ControlLight;
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
            this.groupCodificador.Size = new System.Drawing.Size(374, 459);
            this.groupCodificador.TabIndex = 2;
            this.groupCodificador.TabStop = false;
            this.groupCodificador.Text = "Codificador";
            // 
            // btnCodificar
            // 
            this.btnCodificar.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnCodificar.ForeColor = System.Drawing.Color.DarkRed;
            this.btnCodificar.Location = new System.Drawing.Point(130, 201);
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
            this.comboBoxCodificar.Location = new System.Drawing.Point(34, 159);
            this.comboBoxCodificar.Name = "comboBoxCodificar";
            this.comboBoxCodificar.Size = new System.Drawing.Size(305, 26);
            this.comboBoxCodificar.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(30, 349);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(230, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Datos Codificados sin Decimal";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(30, 246);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Datos Codificados";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 123);
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
            this.groupDecodificador.BackColor = System.Drawing.SystemColors.ControlLight;
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 534);
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
    }
}

