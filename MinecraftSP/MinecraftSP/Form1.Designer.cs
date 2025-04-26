namespace MinecraftSP
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
            Nombre_Jugador = new TextBox();
            NameJugador = new Label();
            Nivel_Jugador = new NumericUpDown();
            Level_Jugador = new Label();
            Agregar_Jugador = new Button();
            Actualizar_Jugador = new Button();
            Eliminar_Jugador = new Button();
            Mostrar_Informacion = new DataGridView();
            Tipos_Bloque = new ComboBox();
            Seleccion_TipoBloque = new Label();
            Seleccion_RarezaBloque = new Label();
            Rareza_Bloques = new ComboBox();
            Filtro = new Button();
            Imagen_Bloques = new PictureBox();
            Seleccion_TipoDoc = new Label();
            Boton_CSV = new Button();
            Boton_Excel = new Button();
            ((System.ComponentModel.ISupportInitialize)Nivel_Jugador).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Mostrar_Informacion).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Imagen_Bloques).BeginInit();
            SuspendLayout();
            // 
            // Nombre_Jugador
            // 
            Nombre_Jugador.BackColor = Color.NavajoWhite;
            Nombre_Jugador.Location = new Point(168, 184);
            Nombre_Jugador.Name = "Nombre_Jugador";
            Nombre_Jugador.Size = new Size(238, 27);
            Nombre_Jugador.TabIndex = 0;
            // 
            // NameJugador
            // 
            NameJugador.AutoSize = true;
            NameJugador.Location = new Point(12, 184);
            NameJugador.Name = "NameJugador";
            NameJugador.Size = new Size(150, 20);
            NameJugador.TabIndex = 1;
            NameJugador.Text = "Nombre del Jugador ";
            // 
            // Nivel_Jugador
            // 
            Nivel_Jugador.BackColor = Color.NavajoWhite;
            Nivel_Jugador.Location = new Point(671, 187);
            Nivel_Jugador.Name = "Nivel_Jugador";
            Nivel_Jugador.Size = new Size(238, 27);
            Nivel_Jugador.TabIndex = 2;
            Nivel_Jugador.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // Level_Jugador
            // 
            Level_Jugador.AutoSize = true;
            Level_Jugador.Location = new Point(515, 187);
            Level_Jugador.Name = "Level_Jugador";
            Level_Jugador.Size = new Size(125, 20);
            Level_Jugador.TabIndex = 3;
            Level_Jugador.Text = "Nivel del Jugador";
            // 
            // Agregar_Jugador
            // 
            Agregar_Jugador.BackColor = Color.Peru;
            Agregar_Jugador.Location = new Point(49, 254);
            Agregar_Jugador.Name = "Agregar_Jugador";
            Agregar_Jugador.Size = new Size(100, 30);
            Agregar_Jugador.TabIndex = 2;
            Agregar_Jugador.Text = "AGREGAR";
            Agregar_Jugador.UseVisualStyleBackColor = false;
            Agregar_Jugador.Click += Agregar_Click;
            // 
            // Actualizar_Jugador
            // 
            Actualizar_Jugador.BackColor = Color.Peru;
            Actualizar_Jugador.Location = new Point(179, 254);
            Actualizar_Jugador.Name = "Actualizar_Jugador";
            Actualizar_Jugador.Size = new Size(106, 29);
            Actualizar_Jugador.TabIndex = 5;
            Actualizar_Jugador.Text = "ACTUALIZAR";
            Actualizar_Jugador.UseVisualStyleBackColor = false;
            Actualizar_Jugador.Click += Actualizar_Click;
            // 
            // Eliminar_Jugador
            // 
            Eliminar_Jugador.BackColor = Color.Peru;
            Eliminar_Jugador.Location = new Point(329, 254);
            Eliminar_Jugador.Name = "Eliminar_Jugador";
            Eliminar_Jugador.Size = new Size(94, 29);
            Eliminar_Jugador.TabIndex = 6;
            Eliminar_Jugador.Text = "ELIMINAR";
            Eliminar_Jugador.UseVisualStyleBackColor = false;
            Eliminar_Jugador.Click += Eliminar_Click;
            // 
            // Mostrar_Informacion
            // 
            Mostrar_Informacion.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Mostrar_Informacion.BackgroundColor = Color.FromArgb(255, 192, 192);
            Mostrar_Informacion.ColumnHeadersHeight = 29;
            Mostrar_Informacion.Location = new Point(488, 254);
            Mostrar_Informacion.MultiSelect = false;
            Mostrar_Informacion.Name = "Mostrar_Informacion";
            Mostrar_Informacion.RowHeadersWidth = 51;
            Mostrar_Informacion.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            Mostrar_Informacion.Size = new Size(515, 328);
            Mostrar_Informacion.TabIndex = 3;
            Mostrar_Informacion.CellContentClick += Mostrar_Informacion_CellContentClick;
            // 
            // Tipos_Bloque
            // 
            Tipos_Bloque.BackColor = Color.NavajoWhite;
            Tipos_Bloque.FormattingEnabled = true;
            Tipos_Bloque.Location = new Point(31, 448);
            Tipos_Bloque.Name = "Tipos_Bloque";
            Tipos_Bloque.Size = new Size(151, 28);
            Tipos_Bloque.TabIndex = 8;
            Tipos_Bloque.Text = "Bloques";
            Tipos_Bloque.SelectedIndexChanged += Tipos_Bloque_SelectedIndexChanged;
            // 
            // Seleccion_TipoBloque
            // 
            Seleccion_TipoBloque.AutoSize = true;
            Seleccion_TipoBloque.Location = new Point(12, 364);
            Seleccion_TipoBloque.Name = "Seleccion_TipoBloque";
            Seleccion_TipoBloque.Size = new Size(202, 20);
            Seleccion_TipoBloque.TabIndex = 9;
            Seleccion_TipoBloque.Text = "Selecciona el Tipo de Bloque";
            // 
            // Seleccion_RarezaBloque
            // 
            Seleccion_RarezaBloque.AutoSize = true;
            Seleccion_RarezaBloque.Location = new Point(242, 364);
            Seleccion_RarezaBloque.Name = "Seleccion_RarezaBloque";
            Seleccion_RarezaBloque.Size = new Size(225, 20);
            Seleccion_RarezaBloque.TabIndex = 10;
            Seleccion_RarezaBloque.Text = "Selecciona la Rareza del Bloque ";
            Seleccion_RarezaBloque.Click += Seleccion_RarezaBloque_Click;
            // 
            // Rareza_Bloques
            // 
            Rareza_Bloques.BackColor = Color.NavajoWhite;
            Rareza_Bloques.FormattingEnabled = true;
            Rareza_Bloques.Location = new Point(272, 448);
            Rareza_Bloques.Name = "Rareza_Bloques";
            Rareza_Bloques.Size = new Size(151, 28);
            Rareza_Bloques.TabIndex = 11;
            Rareza_Bloques.Text = "Rarezas";
            Rareza_Bloques.SelectedIndexChanged += Rareza_Bloques_SelectedIndexChanged;
            // 
            // Filtro
            // 
            Filtro.BackColor = Color.Peru;
            Filtro.Location = new Point(168, 532);
            Filtro.Name = "Filtro";
            Filtro.Size = new Size(94, 29);
            Filtro.TabIndex = 12;
            Filtro.Text = "FILTRAR";
            Filtro.UseVisualStyleBackColor = false;
            Filtro.Click += Filtro_Click;
            // 
            // Imagen_Bloques
            // 
            Imagen_Bloques.Location = new Point(12, 19);
            Imagen_Bloques.Name = "Imagen_Bloques";
            Imagen_Bloques.Size = new Size(524, 147);
            Imagen_Bloques.SizeMode = PictureBoxSizeMode.StretchImage;
            Imagen_Bloques.TabIndex = 13;
            Imagen_Bloques.TabStop = false;
            // 
            // Seleccion_TipoDoc
            // 
            Seleccion_TipoDoc.AutoSize = true;
            Seleccion_TipoDoc.Location = new Point(579, 19);
            Seleccion_TipoDoc.Name = "Seleccion_TipoDoc";
            Seleccion_TipoDoc.Size = new Size(311, 20);
            Seleccion_TipoDoc.TabIndex = 14;
            Seleccion_TipoDoc.Text = "Selecciona tipo de documento de expotacion";
            // 
            // Boton_CSV
            // 
            Boton_CSV.BackColor = Color.Peru;
            Boton_CSV.Location = new Point(609, 88);
            Boton_CSV.Name = "Boton_CSV";
            Boton_CSV.Size = new Size(85, 28);
            Boton_CSV.TabIndex = 15;
            Boton_CSV.Text = "EXP. CSV";
            Boton_CSV.UseVisualStyleBackColor = false;
            Boton_CSV.Click += ExportarInventarioACSV;
            // 
            // Boton_Excel
            // 
            Boton_Excel.BackColor = Color.Peru;
            Boton_Excel.Location = new Point(742, 87);
            Boton_Excel.Name = "Boton_Excel";
            Boton_Excel.Size = new Size(94, 29);
            Boton_Excel.TabIndex = 16;
            Boton_Excel.Text = "EXP. EXCEL";
            Boton_Excel.UseVisualStyleBackColor = false;
            Boton_Excel.Click += ExportarInventarioAExcel;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 255, 128);
            ClientSize = new Size(1033, 619);
            Controls.Add(Boton_Excel);
            Controls.Add(Boton_CSV);
            Controls.Add(Seleccion_TipoDoc);
            Controls.Add(Imagen_Bloques);
            Controls.Add(Filtro);
            Controls.Add(Rareza_Bloques);
            Controls.Add(Seleccion_RarezaBloque);
            Controls.Add(Seleccion_TipoBloque);
            Controls.Add(Tipos_Bloque);
            Controls.Add(Mostrar_Informacion);
            Controls.Add(Eliminar_Jugador);
            Controls.Add(Actualizar_Jugador);
            Controls.Add(Agregar_Jugador);
            Controls.Add(Level_Jugador);
            Controls.Add(Nivel_Jugador);
            Controls.Add(NameJugador);
            Controls.Add(Nombre_Jugador);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)Nivel_Jugador).EndInit();
            ((System.ComponentModel.ISupportInitialize)Mostrar_Informacion).EndInit();
            ((System.ComponentModel.ISupportInitialize)Imagen_Bloques).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }


        private void ExportarInventarioACSV(object sender, EventArgs e)
        {
            
        }

        private void ExportarInventarioAExcel(object sender, EventArgs e)
        {

        }

        #endregion

        private System.Windows.Forms.TextBox Nombre_Jugador;
        private Label NameJugador;
        private System.Windows.Forms.NumericUpDown Nivel_Jugador;
        private Label Level_Jugador;
        private System.Windows.Forms.Button Agregar_Jugador;
        private System.Windows.Forms.Button Actualizar_Jugador;
        private System.Windows.Forms.Button Eliminar_Jugador;
        private System.Windows.Forms.DataGridView Mostrar_Informacion;
        private ComboBox Tipos_Bloque;
        private Label Seleccion_TipoBloque;
        private Label Seleccion_RarezaBloque;
        private ComboBox Rareza_Bloques;
        private Button Filtro;
        private PictureBox Imagen_Bloques;
        private Label Seleccion_TipoDoc;
        private Button Boton_CSV;
        private Button Boton_Excel;
    }
}