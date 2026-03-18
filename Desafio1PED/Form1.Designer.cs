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
            this.components = new System.ComponentModel.Container();

            // Panel izquierdo - Árbol
            this.panelArbol = new System.Windows.Forms.Panel();
            this.treeViewArchivos = new System.Windows.Forms.TreeView();
            this.labelArbol = new System.Windows.Forms.Label();

            // Panel central superior - Información
            this.panelInfo = new System.Windows.Forms.Panel();
            this.labelInfoRuta = new System.Windows.Forms.Label();
            this.textBoxRuta = new System.Windows.Forms.TextBox();
            this.labelRutaInfo = new System.Windows.Forms.Label();

            // Panel central inferior - Operaciones
            this.panelOperaciones = new System.Windows.Forms.Panel();
            this.labelNombreNodo = new System.Windows.Forms.Label();
            this.textBoxNombreNodo = new System.Windows.Forms.TextBox();
            this.comboBoxTipo = new System.Windows.Forms.ComboBox();
            this.buttonAgregarNodo = new System.Windows.Forms.Button();
            this.buttonBuscar = new System.Windows.Forms.Button();
            this.textBoxBuscar = new System.Windows.Forms.TextBox();
            this.labelBuscar = new System.Windows.Forms.Label();
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.buttonMostrarRuta = new System.Windows.Forms.Button();

            // Panel derecho - Resultados/Salida
            this.panelResultados = new System.Windows.Forms.Panel();
            this.textBoxResultados = new System.Windows.Forms.TextBox();
            this.labelResultados = new System.Windows.Forms.Label();
            this.buttonLimpiarResultados = new System.Windows.Forms.Button();

            // Panel inferior - Recorridos y Estadísticas
            this.panelRecorridos = new System.Windows.Forms.Panel();
            this.buttonRecorridoPreorden = new System.Windows.Forms.Button();
            this.buttonRecorridoPostorden = new System.Windows.Forms.Button();
            this.buttonRecorridoPorNiveles = new System.Windows.Forms.Button();
            this.buttonEstadisticas = new System.Windows.Forms.Button();
            this.buttonCrearEstructuraEjemplo = new System.Windows.Forms.Button();

            // Panel Árbol
            this.panelArbol.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelArbol.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelArbol.Width = 300;

            this.labelArbol.AutoSize = true;
            this.labelArbol.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.labelArbol.Location = new System.Drawing.Point(10, 10);
            this.labelArbol.Text = "Estructura del Árbol";

            this.treeViewArchivos.Location = new System.Drawing.Point(10, 35);
            this.treeViewArchivos.Size = new System.Drawing.Size(270, 420);
            this.treeViewArchivos.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Bottom;

            this.panelArbol.Controls.Add(this.treeViewArchivos);
            this.panelArbol.Controls.Add(this.labelArbol);

            // Panel Info
            this.panelInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelInfo.Height = 70;

            this.labelRutaInfo.AutoSize = true;
            this.labelRutaInfo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.labelRutaInfo.Location = new System.Drawing.Point(10, 10);
            this.labelRutaInfo.Text = "Ruta Actual:";

            this.labelInfoRuta.AutoSize = true;
            this.labelInfoRuta.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.labelInfoRuta.ForeColor = System.Drawing.Color.Blue;
            this.labelInfoRuta.Location = new System.Drawing.Point(10, 35);
            this.labelInfoRuta.Text = "/root";
            this.labelInfoRuta.Size = new System.Drawing.Size(260, 20);

            this.panelInfo.Controls.Add(this.labelInfoRuta);
            this.panelInfo.Controls.Add(this.labelRutaInfo);

            // Panel Operaciones
            this.panelOperaciones.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelOperaciones.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelOperaciones.Height = 110;

            this.labelNombreNodo.AutoSize = true;
            this.labelNombreNodo.Location = new System.Drawing.Point(10, 10);
            this.labelNombreNodo.Text = "Nombre:";

            this.textBoxNombreNodo.Location = new System.Drawing.Point(70, 10);
            this.textBoxNombreNodo.Size = new System.Drawing.Size(120, 25);

            this.comboBoxTipo.Items.AddRange(new object[] { "Carpeta", "Archivo" });
            this.comboBoxTipo.SelectedIndex = 0;
            this.comboBoxTipo.Location = new System.Drawing.Point(200, 10);
            this.comboBoxTipo.Size = new System.Drawing.Size(100, 25);

            this.buttonAgregarNodo.Text = "Agregar";
            this.buttonAgregarNodo.Location = new System.Drawing.Point(310, 10);
            this.buttonAgregarNodo.Size = new System.Drawing.Size(80, 25);
            this.buttonAgregarNodo.Click += ButtonAgregarNodo_Click;

            this.labelBuscar.AutoSize = true;
            this.labelBuscar.Location = new System.Drawing.Point(10, 45);
            this.labelBuscar.Text = "Buscar:";

            this.textBoxBuscar.Location = new System.Drawing.Point(70, 45);
            this.textBoxBuscar.Size = new System.Drawing.Size(120, 25);

            this.buttonBuscar.Text = "Buscar";
            this.buttonBuscar.Location = new System.Drawing.Point(200, 45);
            this.buttonBuscar.Size = new System.Drawing.Size(80, 25);
            this.buttonBuscar.Click += ButtonBuscar_Click;

            this.buttonMostrarRuta.Text = "Mostrar Ruta";
            this.buttonMostrarRuta.Location = new System.Drawing.Point(290, 45);
            this.buttonMostrarRuta.Size = new System.Drawing.Size(100, 25);
            this.buttonMostrarRuta.Click += ButtonMostrarRuta_Click;

            this.buttonEliminar.Text = "Eliminar";
            this.buttonEliminar.Location = new System.Drawing.Point(400, 45);
            this.buttonEliminar.Size = new System.Drawing.Size(80, 25);
            this.buttonEliminar.Click += ButtonEliminar_Click;

            this.panelOperaciones.Controls.Add(this.buttonEliminar);
            this.panelOperaciones.Controls.Add(this.buttonMostrarRuta);
            this.panelOperaciones.Controls.Add(this.buttonBuscar);
            this.panelOperaciones.Controls.Add(this.textBoxBuscar);
            this.panelOperaciones.Controls.Add(this.labelBuscar);
            this.panelOperaciones.Controls.Add(this.buttonAgregarNodo);
            this.panelOperaciones.Controls.Add(this.comboBoxTipo);
            this.panelOperaciones.Controls.Add(this.textBoxNombreNodo);
            this.panelOperaciones.Controls.Add(this.labelNombreNodo);

            // Panel Recorridos
            this.panelRecorridos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelRecorridos.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelRecorridos.Height = 60;

            this.buttonCrearEstructuraEjemplo.Text = "Crear Estructura Ejemplo";
            this.buttonCrearEstructuraEjemplo.Location = new System.Drawing.Point(10, 10);
            this.buttonCrearEstructuraEjemplo.Size = new System.Drawing.Size(140, 35);
            this.buttonCrearEstructuraEjemplo.Click += ButtonCrearEstructuraEjemplo_Click;

            this.buttonRecorridoPreorden.Text = "Preorden";
            this.buttonRecorridoPreorden.Location = new System.Drawing.Point(160, 10);
            this.buttonRecorridoPreorden.Size = new System.Drawing.Size(100, 35);
            this.buttonRecorridoPreorden.Click += ButtonRecorridoPreorden_Click;

            this.buttonRecorridoPostorden.Text = "Postorden";
            this.buttonRecorridoPostorden.Location = new System.Drawing.Point(270, 10);
            this.buttonRecorridoPostorden.Size = new System.Drawing.Size(100, 35);
            this.buttonRecorridoPostorden.Click += ButtonRecorridoPostorden_Click;

            this.buttonRecorridoPorNiveles.Text = "Por Niveles";
            this.buttonRecorridoPorNiveles.Location = new System.Drawing.Point(380, 10);
            this.buttonRecorridoPorNiveles.Size = new System.Drawing.Size(100, 35);
            this.buttonRecorridoPorNiveles.Click += ButtonRecorridoPorNiveles_Click;

            this.buttonEstadisticas.Text = "Estadísticas";
            this.buttonEstadisticas.Location = new System.Drawing.Point(490, 10);
            this.buttonEstadisticas.Size = new System.Drawing.Size(100, 35);
            this.buttonEstadisticas.Click += ButtonEstadisticas_Click;

            this.panelRecorridos.Controls.Add(this.buttonEstadisticas);
            this.panelRecorridos.Controls.Add(this.buttonRecorridoPorNiveles);
            this.panelRecorridos.Controls.Add(this.buttonRecorridoPostorden);
            this.panelRecorridos.Controls.Add(this.buttonRecorridoPreorden);
            this.panelRecorridos.Controls.Add(this.buttonCrearEstructuraEjemplo);

            // Panel Resultados
            this.panelResultados.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelResultados.Dock = System.Windows.Forms.DockStyle.Fill;

            this.labelResultados.AutoSize = true;
            this.labelResultados.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.labelResultados.Location = new System.Drawing.Point(10, 10);
            this.labelResultados.Text = "Resultados:";

            this.textBoxResultados.Location = new System.Drawing.Point(10, 35);
            this.textBoxResultados.Size = new System.Drawing.Size(480, 250);
            this.textBoxResultados.Multiline = true;
            this.textBoxResultados.ReadOnly = true;
            this.textBoxResultados.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxResultados.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right | System.Windows.Forms.AnchorStyles.Bottom;

            this.buttonLimpiarResultados.Text = "Limpiar";
            this.buttonLimpiarResultados.Location = new System.Drawing.Point(10, 295);
            this.buttonLimpiarResultados.Size = new System.Drawing.Size(80, 25);
            this.buttonLimpiarResultados.Click += ButtonLimpiarResultados_Click;
            this.buttonLimpiarResultados.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;

            this.panelResultados.Controls.Add(this.buttonLimpiarResultados);
            this.panelResultados.Controls.Add(this.textBoxResultados);
            this.panelResultados.Controls.Add(this.labelResultados);

            // Form1
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 700);
            this.Name = "Form1";
            this.Text = "Sistema de Archivos Jerárquico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;

            this.Controls.Add(this.panelResultados);
            this.Controls.Add(this.panelRecorridos);
            this.Controls.Add(this.panelOperaciones);
            this.Controls.Add(this.panelInfo);
            this.Controls.Add(this.panelArbol);

            this.ResumeLayout(false);
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
