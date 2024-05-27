namespace ejercicio_personajes
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
            this.button1 = new System.Windows.Forms.Button();
            this.botoncargar = new System.Windows.Forms.Button();
            this.dataGridViewPersonajes = new System.Windows.Forms.DataGridView();
            this.textBox1_TextChanged = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.insertar = new System.Windows.Forms.Button();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.textBoxnombre = new System.Windows.Forms.TextBox();
            this.textBoxraza = new System.Windows.Forms.TextBox();
            this.textBoxhistoria = new System.Windows.Forms.TextBox();
            this.dateTimePickerFechaCreacion = new System.Windows.Forms.DateTimePicker();
            this.numericUpDownNivel_de_Poder = new System.Windows.Forms.NumericUpDown();
            this.ButtonBuscar_Click = new System.Windows.Forms.Button();
            this.Actualizar_Click = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPersonajes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNivel_de_Poder)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(388, 114);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(149, 28);
            this.button1.TabIndex = 0;
            this.button1.Text = "Click";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // botoncargar
            // 
            this.botoncargar.Location = new System.Drawing.Point(388, 158);
            this.botoncargar.Name = "botoncargar";
            this.botoncargar.Size = new System.Drawing.Size(149, 25);
            this.botoncargar.TabIndex = 1;
            this.botoncargar.Text = "Cargar";
            this.botoncargar.UseVisualStyleBackColor = true;
            this.botoncargar.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridViewPersonajes
            // 
            this.dataGridViewPersonajes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPersonajes.Location = new System.Drawing.Point(-1, 114);
            this.dataGridViewPersonajes.Name = "dataGridViewPersonajes";
            this.dataGridViewPersonajes.Size = new System.Drawing.Size(389, 118);
            this.dataGridViewPersonajes.TabIndex = 2;
            // 
            // textBox1_TextChanged
            // 
            this.textBox1_TextChanged.Location = new System.Drawing.Point(388, 202);
            this.textBox1_TextChanged.Name = "textBox1_TextChanged";
            this.textBox1_TextChanged.Size = new System.Drawing.Size(143, 20);
            this.textBox1_TextChanged.TabIndex = 3;
            this.textBox1_TextChanged.TextChanged += new System.EventHandler(this.textBox1_TextChanged_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "NOMBRE:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "RAZA:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label4.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label4.Location = new System.Drawing.Point(22, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "NIVEL DE PODER:";
            // 
            // insertar
            // 
            this.insertar.Location = new System.Drawing.Point(388, 196);
            this.insertar.Name = "insertar";
            this.insertar.Size = new System.Drawing.Size(149, 30);
            this.insertar.TabIndex = 8;
            this.insertar.Text = "Crear";
            this.insertar.UseVisualStyleBackColor = true;
            this.insertar.Click += new System.EventHandler(this.insertar_Click);
            // 
            // textBoxId
            // 
            this.textBoxId.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.textBoxId.ForeColor = System.Drawing.SystemColors.Menu;
            this.textBoxId.Location = new System.Drawing.Point(58, 19);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(200, 20);
            this.textBoxId.TabIndex = 9;
            // 
            // textBoxnombre
            // 
            this.textBoxnombre.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.textBoxnombre.ForeColor = System.Drawing.SystemColors.Menu;
            this.textBoxnombre.Location = new System.Drawing.Point(85, 40);
            this.textBoxnombre.Name = "textBoxnombre";
            this.textBoxnombre.Size = new System.Drawing.Size(200, 20);
            this.textBoxnombre.TabIndex = 10;
            // 
            // textBoxraza
            // 
            this.textBoxraza.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.textBoxraza.ForeColor = System.Drawing.SystemColors.Menu;
            this.textBoxraza.Location = new System.Drawing.Point(85, 67);
            this.textBoxraza.Name = "textBoxraza";
            this.textBoxraza.Size = new System.Drawing.Size(200, 20);
            this.textBoxraza.TabIndex = 11;
            // 
            // textBoxhistoria
            // 
            this.textBoxhistoria.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.textBoxhistoria.ForeColor = System.Drawing.SystemColors.Menu;
            this.textBoxhistoria.Location = new System.Drawing.Point(314, 40);
            this.textBoxhistoria.Name = "textBoxhistoria";
            this.textBoxhistoria.Size = new System.Drawing.Size(100, 20);
            this.textBoxhistoria.TabIndex = 12;
            // 
            // dateTimePickerFechaCreacion
            // 
            this.dateTimePickerFechaCreacion.Location = new System.Drawing.Point(314, 67);
            this.dateTimePickerFechaCreacion.Name = "dateTimePickerFechaCreacion";
            this.dateTimePickerFechaCreacion.Size = new System.Drawing.Size(216, 20);
            this.dateTimePickerFechaCreacion.TabIndex = 13;
            // 
            // numericUpDownNivel_de_Poder
            // 
            this.numericUpDownNivel_de_Poder.Location = new System.Drawing.Point(128, 91);
            this.numericUpDownNivel_de_Poder.Name = "numericUpDownNivel_de_Poder";
            this.numericUpDownNivel_de_Poder.Size = new System.Drawing.Size(222, 20);
            this.numericUpDownNivel_de_Poder.TabIndex = 14;
            // 
            // ButtonBuscar_Click
            // 
            this.ButtonBuscar_Click.BackgroundImage = global::ejercicio_personajes.Properties.Resources._88ec24a4aa88beae2d403d9d79ec1a27;
            this.ButtonBuscar_Click.Location = new System.Drawing.Point(311, 7);
            this.ButtonBuscar_Click.Name = "ButtonBuscar_Click";
            this.ButtonBuscar_Click.Size = new System.Drawing.Size(112, 27);
            this.ButtonBuscar_Click.TabIndex = 15;
            this.ButtonBuscar_Click.Text = "Buscar";
            this.ButtonBuscar_Click.UseVisualStyleBackColor = true;
            this.ButtonBuscar_Click.Click += new System.EventHandler(this.ButtonBuscar_Click_Click);
            // 
            // Actualizar_Click
            // 
            this.Actualizar_Click.Location = new System.Drawing.Point(387, 89);
            this.Actualizar_Click.Name = "Actualizar_Click";
            this.Actualizar_Click.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Actualizar_Click.Size = new System.Drawing.Size(142, 25);
            this.Actualizar_Click.TabIndex = 16;
            this.Actualizar_Click.Text = "Actualizar";
            this.Actualizar_Click.UseVisualStyleBackColor = true;
            this.Actualizar_Click.Click += new System.EventHandler(this.Actualizar_Click_Click);
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = global::ejercicio_personajes.Properties.Resources._88ec24a4aa88beae2d403d9d79ec1a27;
            this.ClientSize = new System.Drawing.Size(636, 261);
            this.Controls.Add(this.Actualizar_Click);
            this.Controls.Add(this.ButtonBuscar_Click);
            this.Controls.Add(this.numericUpDownNivel_de_Poder);
            this.Controls.Add(this.dateTimePickerFechaCreacion);
            this.Controls.Add(this.textBoxhistoria);
            this.Controls.Add(this.textBoxraza);
            this.Controls.Add(this.textBoxnombre);
            this.Controls.Add(this.textBoxId);
            this.Controls.Add(this.insertar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1_TextChanged);
            this.Controls.Add(this.dataGridViewPersonajes);
            this.Controls.Add(this.botoncargar);
            this.Controls.Add(this.button1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPersonajes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNivel_de_Poder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1_Click;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button botoncargar;
        private System.Windows.Forms.DataGridView dataGridViewPersonajes;
        private System.Windows.Forms.TextBox textBox1_TextChanged;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button insertar;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.TextBox textBoxnombre;
        private System.Windows.Forms.TextBox textBoxraza;
        private System.Windows.Forms.TextBox textBoxhistoria;
        private System.Windows.Forms.DateTimePicker dateTimePickerFechaCreacion;
        private System.Windows.Forms.NumericUpDown numericUpDownNivel_de_Poder;
        private System.Windows.Forms.Button ButtonBuscar_Click;
        private System.Windows.Forms.Button Actualizar_Click;
    }
}
