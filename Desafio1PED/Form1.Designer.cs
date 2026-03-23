namespace Desafio1PED
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            panelArbol = new Panel();
            treeViewArchivos = new TreeView();
            labelArbol = new Label();
            panelInfo = new Panel();
            labelInfoRuta = new Label();
            labelRutaInfo = new Label();
            textBoxRuta = new TextBox();
            panelOperaciones = new Panel();
            buttonEliminar = new Button();
            buttonMostrarRuta = new Button();
            buttonBuscar = new Button();
            textBoxBuscar = new TextBox();
            labelBuscar = new Label();
            buttonAgregarNodo = new Button();
            comboBoxTipo = new ComboBox();
            textBoxNombreNodo = new TextBox();
            labelNombreNodo = new Label();
            panelResultados = new Panel();
            buttonLimpiarResultados = new Button();
            textBoxResultados = new TextBox();
            labelResultados = new Label();
            panelRecorridos = new Panel();
            buttonEstadisticas = new Button();
            buttonRecorridoPorNiveles = new Button();
            buttonRecorridoPostorden = new Button();
            buttonRecorridoPreorden = new Button();
            buttonCrearEstructuraEjemplo = new Button();
            panelArbol.SuspendLayout();
            panelInfo.SuspendLayout();
            panelOperaciones.SuspendLayout();
            panelResultados.SuspendLayout();
            panelRecorridos.SuspendLayout();
            SuspendLayout();
            // 
            // panelArbol
            // 
            panelArbol.BackColor = Color.FromArgb(40, 42, 58);
            panelArbol.Controls.Add(treeViewArchivos);
            panelArbol.Controls.Add(labelArbol);
            panelArbol.Dock = DockStyle.Left;
            panelArbol.Location = new Point(0, 0);
            panelArbol.Name = "panelArbol";
            panelArbol.Padding = new Padding(15);
            panelArbol.Size = new Size(320, 774);
            panelArbol.TabIndex = 4;
            // 
            // treeViewArchivos
            // 
            treeViewArchivos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            treeViewArchivos.BackColor = Color.FromArgb(36, 39, 58);
            treeViewArchivos.BorderStyle = BorderStyle.None;
            treeViewArchivos.Font = new Font("Cascadia Code", 10F);
            treeViewArchivos.ForeColor = Color.FromArgb(205, 214, 244);
            treeViewArchivos.FullRowSelect = true;
            treeViewArchivos.HotTracking = true;
            treeViewArchivos.Indent = 20;
            treeViewArchivos.ItemHeight = 28;
            treeViewArchivos.Location = new Point(15, 55);
            treeViewArchivos.Name = "treeViewArchivos";
            treeViewArchivos.Size = new Size(290, 704);
            treeViewArchivos.TabIndex = 0;
            // 
            // labelArbol
            // 
            labelArbol.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            labelArbol.ForeColor = Color.FromArgb(137, 180, 250);
            labelArbol.Location = new Point(15, 15);
            labelArbol.Name = "labelArbol";
            labelArbol.Size = new Size(290, 35);
            labelArbol.TabIndex = 1;
            labelArbol.Text = "Estructura del Arbol";
            labelArbol.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panelInfo
            // 
            panelInfo.BackColor = Color.FromArgb(50, 52, 70);
            panelInfo.Controls.Add(labelInfoRuta);
            panelInfo.Controls.Add(labelRutaInfo);
            panelInfo.Dock = DockStyle.Top;
            panelInfo.Location = new Point(320, 0);
            panelInfo.Name = "panelInfo";
            panelInfo.Padding = new Padding(20, 15, 20, 15);
            panelInfo.Size = new Size(891, 70);
            panelInfo.TabIndex = 3;
            // 
            // labelInfoRuta
            // 
            labelInfoRuta.AutoSize = true;
            labelInfoRuta.Font = new Font("Cascadia Code", 12F);
            labelInfoRuta.ForeColor = Color.FromArgb(137, 180, 250);
            labelInfoRuta.Location = new Point(20, 38);
            labelInfoRuta.Name = "labelInfoRuta";
            labelInfoRuta.Size = new Size(55, 21);
            labelInfoRuta.TabIndex = 0;
            labelInfoRuta.Text = "/root";
            // 
            // labelRutaInfo
            // 
            labelRutaInfo.AutoSize = true;
            labelRutaInfo.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            labelRutaInfo.ForeColor = Color.FromArgb(166, 173, 200);
            labelRutaInfo.Location = new Point(20, 12);
            labelRutaInfo.Name = "labelRutaInfo";
            labelRutaInfo.Size = new Size(97, 21);
            labelRutaInfo.TabIndex = 1;
            labelRutaInfo.Text = "Ruta Actual:";
            // 
            // textBoxRuta
            // 
            textBoxRuta.Location = new Point(-100, -100);
            textBoxRuta.Name = "textBoxRuta";
            textBoxRuta.Size = new Size(1, 23);
            textBoxRuta.TabIndex = 0;
            textBoxRuta.Visible = false;
            // 
            // panelOperaciones
            // 
            panelOperaciones.BackColor = Color.FromArgb(40, 42, 58);
            panelOperaciones.Controls.Add(buttonEliminar);
            panelOperaciones.Controls.Add(buttonMostrarRuta);
            panelOperaciones.Controls.Add(buttonBuscar);
            panelOperaciones.Controls.Add(textBoxBuscar);
            panelOperaciones.Controls.Add(labelBuscar);
            panelOperaciones.Controls.Add(buttonAgregarNodo);
            panelOperaciones.Controls.Add(comboBoxTipo);
            panelOperaciones.Controls.Add(textBoxNombreNodo);
            panelOperaciones.Controls.Add(labelNombreNodo);
            panelOperaciones.Dock = DockStyle.Top;
            panelOperaciones.Location = new Point(320, 70);
            panelOperaciones.Name = "panelOperaciones";
            panelOperaciones.Padding = new Padding(20, 15, 20, 15);
            panelOperaciones.Size = new Size(891, 130);
            panelOperaciones.TabIndex = 2;
            // 
            // buttonEliminar
            // 
            buttonEliminar.BackColor = Color.FromArgb(243, 139, 168);
            buttonEliminar.Cursor = Cursors.Hand;
            buttonEliminar.FlatAppearance.BorderSize = 0;
            buttonEliminar.FlatStyle = FlatStyle.Flat;
            buttonEliminar.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            buttonEliminar.ForeColor = Color.FromArgb(30, 30, 46);
            buttonEliminar.Location = new Point(545, 60);
            buttonEliminar.Name = "buttonEliminar";
            buttonEliminar.Size = new Size(100, 32);
            buttonEliminar.TabIndex = 0;
            buttonEliminar.Text = "Eliminar";
            buttonEliminar.UseVisualStyleBackColor = false;
            buttonEliminar.Click += ButtonEliminar_Click;
            // 
            // buttonMostrarRuta
            // 
            buttonMostrarRuta.BackColor = Color.FromArgb(69, 71, 90);
            buttonMostrarRuta.Cursor = Cursors.Hand;
            buttonMostrarRuta.FlatAppearance.BorderSize = 0;
            buttonMostrarRuta.FlatStyle = FlatStyle.Flat;
            buttonMostrarRuta.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            buttonMostrarRuta.ForeColor = Color.FromArgb(205, 214, 244);
            buttonMostrarRuta.Location = new Point(400, 60);
            buttonMostrarRuta.Name = "buttonMostrarRuta";
            buttonMostrarRuta.Size = new Size(130, 32);
            buttonMostrarRuta.TabIndex = 1;
            buttonMostrarRuta.Text = "Ver Detalles";
            buttonMostrarRuta.UseVisualStyleBackColor = false;
            buttonMostrarRuta.Click += ButtonMostrarRuta_Click;
            // 
            // buttonBuscar
            // 
            buttonBuscar.BackColor = Color.FromArgb(137, 180, 250);
            buttonBuscar.Cursor = Cursors.Hand;
            buttonBuscar.FlatAppearance.BorderSize = 0;
            buttonBuscar.FlatStyle = FlatStyle.Flat;
            buttonBuscar.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            buttonBuscar.ForeColor = Color.FromArgb(30, 30, 46);
            buttonBuscar.Location = new Point(285, 60);
            buttonBuscar.Name = "buttonBuscar";
            buttonBuscar.Size = new Size(100, 32);
            buttonBuscar.TabIndex = 2;
            buttonBuscar.Text = "Buscar";
            buttonBuscar.UseVisualStyleBackColor = false;
            buttonBuscar.Click += ButtonBuscar_Click;
            // 
            // textBoxBuscar
            // 
            textBoxBuscar.BackColor = Color.FromArgb(36, 39, 58);
            textBoxBuscar.BorderStyle = BorderStyle.FixedSingle;
            textBoxBuscar.Font = new Font("Segoe UI", 11F);
            textBoxBuscar.ForeColor = Color.FromArgb(205, 214, 244);
            textBoxBuscar.Location = new Point(95, 62);
            textBoxBuscar.Name = "textBoxBuscar";
            textBoxBuscar.PlaceholderText = "Buscar nodo...";
            textBoxBuscar.Size = new Size(180, 27);
            textBoxBuscar.TabIndex = 3;
            // 
            // labelBuscar
            // 
            labelBuscar.AutoSize = true;
            labelBuscar.Font = new Font("Segoe UI", 10F);
            labelBuscar.ForeColor = Color.FromArgb(166, 173, 200);
            labelBuscar.Location = new Point(20, 65);
            labelBuscar.Name = "labelBuscar";
            labelBuscar.Size = new Size(52, 19);
            labelBuscar.TabIndex = 4;
            labelBuscar.Text = "Buscar:";
            // 
            // buttonAgregarNodo
            // 
            buttonAgregarNodo.BackColor = Color.FromArgb(166, 227, 161);
            buttonAgregarNodo.Cursor = Cursors.Hand;
            buttonAgregarNodo.FlatAppearance.BorderSize = 0;
            buttonAgregarNodo.FlatStyle = FlatStyle.Flat;
            buttonAgregarNodo.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            buttonAgregarNodo.ForeColor = Color.FromArgb(30, 30, 46);
            buttonAgregarNodo.Location = new Point(420, 13);
            buttonAgregarNodo.Name = "buttonAgregarNodo";
            buttonAgregarNodo.Size = new Size(110, 32);
            buttonAgregarNodo.TabIndex = 5;
            buttonAgregarNodo.Text = "+ Agregar";
            buttonAgregarNodo.UseVisualStyleBackColor = false;
            buttonAgregarNodo.Click += ButtonAgregarNodo_Click;
            // 
            // comboBoxTipo
            // 
            comboBoxTipo.BackColor = Color.FromArgb(36, 39, 58);
            comboBoxTipo.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxTipo.FlatStyle = FlatStyle.Flat;
            comboBoxTipo.Font = new Font("Segoe UI", 11F);
            comboBoxTipo.ForeColor = Color.FromArgb(205, 214, 244);
            comboBoxTipo.Items.AddRange(new object[] { "Carpeta", "Archivo" });
            comboBoxTipo.Location = new Point(285, 15);
            comboBoxTipo.Name = "comboBoxTipo";
            comboBoxTipo.Size = new Size(120, 28);
            comboBoxTipo.TabIndex = 6;
            // 
            // textBoxNombreNodo
            // 
            textBoxNombreNodo.BackColor = Color.FromArgb(36, 39, 58);
            textBoxNombreNodo.BorderStyle = BorderStyle.FixedSingle;
            textBoxNombreNodo.Font = new Font("Segoe UI", 11F);
            textBoxNombreNodo.ForeColor = Color.FromArgb(205, 214, 244);
            textBoxNombreNodo.Location = new Point(95, 15);
            textBoxNombreNodo.Name = "textBoxNombreNodo";
            textBoxNombreNodo.PlaceholderText = "Nombre del nodo...";
            textBoxNombreNodo.Size = new Size(180, 27);
            textBoxNombreNodo.TabIndex = 7;
            // 
            // labelNombreNodo
            // 
            labelNombreNodo.AutoSize = true;
            labelNombreNodo.Font = new Font("Segoe UI", 10F);
            labelNombreNodo.ForeColor = Color.FromArgb(166, 173, 200);
            labelNombreNodo.Location = new Point(20, 18);
            labelNombreNodo.Name = "labelNombreNodo";
            labelNombreNodo.Size = new Size(62, 19);
            labelNombreNodo.TabIndex = 8;
            labelNombreNodo.Text = "Nombre:";
            // 
            // panelResultados
            // 
            panelResultados.BackColor = Color.FromArgb(30, 30, 46);
            panelResultados.Controls.Add(buttonLimpiarResultados);
            panelResultados.Controls.Add(textBoxResultados);
            panelResultados.Controls.Add(labelResultados);
            panelResultados.Dock = DockStyle.Fill;
            panelResultados.Location = new Point(320, 200);
            panelResultados.Name = "panelResultados";
            panelResultados.Padding = new Padding(20);
            panelResultados.Size = new Size(891, 504);
            panelResultados.TabIndex = 0;
            // 
            // buttonLimpiarResultados
            // 
            buttonLimpiarResultados.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonLimpiarResultados.BackColor = Color.FromArgb(69, 71, 90);
            buttonLimpiarResultados.Cursor = Cursors.Hand;
            buttonLimpiarResultados.FlatAppearance.BorderSize = 0;
            buttonLimpiarResultados.FlatStyle = FlatStyle.Flat;
            buttonLimpiarResultados.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            buttonLimpiarResultados.ForeColor = Color.FromArgb(205, 214, 244);
            buttonLimpiarResultados.Location = new Point(768, 466);
            buttonLimpiarResultados.Name = "buttonLimpiarResultados";
            buttonLimpiarResultados.Size = new Size(100, 32);
            buttonLimpiarResultados.TabIndex = 0;
            buttonLimpiarResultados.Text = "Limpiar";
            buttonLimpiarResultados.UseVisualStyleBackColor = false;
            buttonLimpiarResultados.Click += ButtonLimpiarResultados_Click;
            // 
            // textBoxResultados
            // 
            textBoxResultados.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBoxResultados.BackColor = Color.FromArgb(36, 39, 58);
            textBoxResultados.BorderStyle = BorderStyle.None;
            textBoxResultados.Font = new Font("Cascadia Code", 10F);
            textBoxResultados.ForeColor = Color.FromArgb(205, 214, 244);
            textBoxResultados.Location = new Point(20, 50);
            textBoxResultados.Multiline = true;
            textBoxResultados.Name = "textBoxResultados";
            textBoxResultados.ReadOnly = true;
            textBoxResultados.ScrollBars = ScrollBars.Both;
            textBoxResultados.Size = new Size(859, 410);
            textBoxResultados.TabIndex = 1;
            textBoxResultados.WordWrap = false;
            // 
            // labelResultados
            // 
            labelResultados.AutoSize = true;
            labelResultados.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold);
            labelResultados.ForeColor = Color.FromArgb(137, 180, 250);
            labelResultados.Location = new Point(20, 15);
            labelResultados.Name = "labelResultados";
            labelResultados.Size = new Size(103, 25);
            labelResultados.TabIndex = 2;
            labelResultados.Text = "Resultados";
            // 
            // panelRecorridos
            // 
            panelRecorridos.BackColor = Color.FromArgb(50, 52, 70);
            panelRecorridos.Controls.Add(buttonEstadisticas);
            panelRecorridos.Controls.Add(buttonRecorridoPorNiveles);
            panelRecorridos.Controls.Add(buttonRecorridoPostorden);
            panelRecorridos.Controls.Add(buttonRecorridoPreorden);
            panelRecorridos.Controls.Add(buttonCrearEstructuraEjemplo);
            panelRecorridos.Dock = DockStyle.Bottom;
            panelRecorridos.Location = new Point(320, 704);
            panelRecorridos.Name = "panelRecorridos";
            panelRecorridos.Padding = new Padding(20, 15, 20, 15);
            panelRecorridos.Size = new Size(891, 70);
            panelRecorridos.TabIndex = 1;
            // 
            // buttonEstadisticas
            // 
            buttonEstadisticas.BackColor = Color.FromArgb(116, 199, 236);
            buttonEstadisticas.Cursor = Cursors.Hand;
            buttonEstadisticas.FlatAppearance.BorderSize = 0;
            buttonEstadisticas.FlatStyle = FlatStyle.Flat;
            buttonEstadisticas.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            buttonEstadisticas.ForeColor = Color.FromArgb(30, 30, 46);
            buttonEstadisticas.Location = new Point(655, 15);
            buttonEstadisticas.Name = "buttonEstadisticas";
            buttonEstadisticas.Size = new Size(130, 40);
            buttonEstadisticas.TabIndex = 0;
            buttonEstadisticas.Text = "Estadisticas";
            buttonEstadisticas.UseVisualStyleBackColor = false;
            buttonEstadisticas.Click += ButtonEstadisticas_Click;
            // 
            // buttonRecorridoPorNiveles
            // 
            buttonRecorridoPorNiveles.BackColor = Color.FromArgb(137, 180, 250);
            buttonRecorridoPorNiveles.Cursor = Cursors.Hand;
            buttonRecorridoPorNiveles.FlatAppearance.BorderSize = 0;
            buttonRecorridoPorNiveles.FlatStyle = FlatStyle.Flat;
            buttonRecorridoPorNiveles.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            buttonRecorridoPorNiveles.ForeColor = Color.FromArgb(30, 30, 46);
            buttonRecorridoPorNiveles.Location = new Point(510, 15);
            buttonRecorridoPorNiveles.Name = "buttonRecorridoPorNiveles";
            buttonRecorridoPorNiveles.Size = new Size(130, 40);
            buttonRecorridoPorNiveles.TabIndex = 1;
            buttonRecorridoPorNiveles.Text = "Por Niveles";
            buttonRecorridoPorNiveles.UseVisualStyleBackColor = false;
            buttonRecorridoPorNiveles.Click += ButtonRecorridoPorNiveles_Click;
            // 
            // buttonRecorridoPostorden
            // 
            buttonRecorridoPostorden.BackColor = Color.FromArgb(137, 180, 250);
            buttonRecorridoPostorden.Cursor = Cursors.Hand;
            buttonRecorridoPostorden.FlatAppearance.BorderSize = 0;
            buttonRecorridoPostorden.FlatStyle = FlatStyle.Flat;
            buttonRecorridoPostorden.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            buttonRecorridoPostorden.ForeColor = Color.FromArgb(30, 30, 46);
            buttonRecorridoPostorden.Location = new Point(365, 15);
            buttonRecorridoPostorden.Name = "buttonRecorridoPostorden";
            buttonRecorridoPostorden.Size = new Size(130, 40);
            buttonRecorridoPostorden.TabIndex = 2;
            buttonRecorridoPostorden.Text = "Postorden";
            buttonRecorridoPostorden.UseVisualStyleBackColor = false;
            buttonRecorridoPostorden.Click += ButtonRecorridoPostorden_Click;
            // 
            // buttonRecorridoPreorden
            // 
            buttonRecorridoPreorden.BackColor = Color.FromArgb(137, 180, 250);
            buttonRecorridoPreorden.Cursor = Cursors.Hand;
            buttonRecorridoPreorden.FlatAppearance.BorderSize = 0;
            buttonRecorridoPreorden.FlatStyle = FlatStyle.Flat;
            buttonRecorridoPreorden.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            buttonRecorridoPreorden.ForeColor = Color.FromArgb(30, 30, 46);
            buttonRecorridoPreorden.Location = new Point(220, 15);
            buttonRecorridoPreorden.Name = "buttonRecorridoPreorden";
            buttonRecorridoPreorden.Size = new Size(130, 40);
            buttonRecorridoPreorden.TabIndex = 3;
            buttonRecorridoPreorden.Text = "Preorden";
            buttonRecorridoPreorden.UseVisualStyleBackColor = false;
            buttonRecorridoPreorden.Click += ButtonRecorridoPreorden_Click;
            // 
            // buttonCrearEstructuraEjemplo
            // 
            buttonCrearEstructuraEjemplo.BackColor = Color.FromArgb(166, 227, 161);
            buttonCrearEstructuraEjemplo.Cursor = Cursors.Hand;
            buttonCrearEstructuraEjemplo.FlatAppearance.BorderSize = 0;
            buttonCrearEstructuraEjemplo.FlatStyle = FlatStyle.Flat;
            buttonCrearEstructuraEjemplo.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            buttonCrearEstructuraEjemplo.ForeColor = Color.FromArgb(30, 30, 46);
            buttonCrearEstructuraEjemplo.Location = new Point(20, 15);
            buttonCrearEstructuraEjemplo.Name = "buttonCrearEstructuraEjemplo";
            buttonCrearEstructuraEjemplo.Size = new Size(180, 40);
            buttonCrearEstructuraEjemplo.TabIndex = 4;
            buttonCrearEstructuraEjemplo.Text = "Crear Ejemplo";
            buttonCrearEstructuraEjemplo.UseVisualStyleBackColor = false;
            buttonCrearEstructuraEjemplo.Click += ButtonCrearEstructuraEjemplo_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 46);
            ClientSize = new Size(1211, 774);
            Controls.Add(panelResultados);
            Controls.Add(panelRecorridos);
            Controls.Add(panelOperaciones);
            Controls.Add(panelInfo);
            Controls.Add(panelArbol);
            MinimumSize = new Size(1000, 650);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sistema de Archivos Jerarquico";
            panelArbol.ResumeLayout(false);
            panelInfo.ResumeLayout(false);
            panelInfo.PerformLayout();
            panelOperaciones.ResumeLayout(false);
            panelOperaciones.PerformLayout();
            panelResultados.ResumeLayout(false);
            panelResultados.PerformLayout();
            panelRecorridos.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panelArbol;
        private System.Windows.Forms.TreeView treeViewArchivos;
        private System.Windows.Forms.Label labelArbol;
        private System.Windows.Forms.Panel panelInfo;
        private System.Windows.Forms.Label labelInfoRuta;
        private System.Windows.Forms.Label labelRutaInfo;
        private System.Windows.Forms.Panel panelOperaciones;
        private System.Windows.Forms.TextBox textBoxNombreNodo;
        private System.Windows.Forms.Label labelNombreNodo;
        private System.Windows.Forms.ComboBox comboBoxTipo;
        private System.Windows.Forms.Button buttonAgregarNodo;
        private System.Windows.Forms.Button buttonBuscar;
        private System.Windows.Forms.TextBox textBoxBuscar;
        private System.Windows.Forms.Label labelBuscar;
        private System.Windows.Forms.Button buttonEliminar;
        private System.Windows.Forms.Button buttonMostrarRuta;
        private System.Windows.Forms.Panel panelResultados;
        private System.Windows.Forms.TextBox textBoxResultados;
        private System.Windows.Forms.Label labelResultados;
        private System.Windows.Forms.Button buttonLimpiarResultados;
        private System.Windows.Forms.Panel panelRecorridos;
        private System.Windows.Forms.Button buttonRecorridoPreorden;
        private System.Windows.Forms.Button buttonRecorridoPostorden;
        private System.Windows.Forms.Button buttonRecorridoPorNiveles;
        private System.Windows.Forms.Button buttonEstadisticas;
        private System.Windows.Forms.Button buttonCrearEstructuraEjemplo;
        private System.Windows.Forms.TextBox textBoxRuta;
    }
}
