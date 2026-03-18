using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Desafio1PED
{
    public partial class Form1 : Form
    {
        private ArbolSistemaArchivos arbol;
        private string rutaActual = "/root";

        public Form1()
        {
            InitializeComponent();
            arbol = new ArbolSistemaArchivos();
            ActualizarArbol();
        }

        private void ActualizarArbol()
        {
            treeViewArchivos.Nodes.Clear();
            agregarNodoAlArbol(arbol.Raiz, null);
            labelInfoRuta.Text = rutaActual;
        }

        private void agregarNodoAlArbol(NodoArchivo nodo, TreeNode nodoPadre)
        {
            string icono = nodo.Tipo == TipoNodo.Carpeta ? "📁 " : "📄 ";
            TreeNode nuevoNodo = new TreeNode(icono + nodo.Nombre);
            nuevoNodo.Tag = nodo;

            if (nodoPadre == null)
                treeViewArchivos.Nodes.Add(nuevoNodo);
            else
                nodoPadre.Nodes.Add(nuevoNodo);

            if (nodo.Tipo == TipoNodo.Carpeta && nodo.Hijos != null)
            {
                foreach (var hijo in nodo.Hijos)
                {
                    agregarNodoAlArbol(hijo, nuevoNodo);
                }
            }
        }

        private NodoArchivo ObtenerNodoSeleccionado()
        {
            if (treeViewArchivos.SelectedNode != null)
                return treeViewArchivos.SelectedNode.Tag as NodoArchivo;
            return null;
        }

        private void ButtonAgregarNodo_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxNombreNodo.Text))
            {
                MostrarMensaje("Por favor, ingrese un nombre para el nodo.", "Validación");
                return;
            }

            NodoArchivo nodoPadre = ObtenerNodoSeleccionado() ?? arbol.Raiz;

            if (nodoPadre.Tipo != TipoNodo.Carpeta)
            {
                MostrarMensaje("No puede agregar elementos a un archivo. Debe seleccionar una carpeta.", "Error");
                return;
            }

            TipoNodo tipo = comboBoxTipo.SelectedIndex == 0 ? TipoNodo.Carpeta : TipoNodo.Archivo;
            var nuevoNodo = new NodoArchivo(textBoxNombreNodo.Text, tipo);

            if (nodoPadre.AgregarHijo(nuevoNodo))
            {
                MostrarMensaje($"Nodo '{textBoxNombreNodo.Text}' agregado exitosamente.", "Éxito");
                textBoxNombreNodo.Clear();
                ActualizarArbol();
                AgregarAlResultados($"✓ Nodo agregado: {nuevoNodo.ObtenerRutaAbsoluta()}");
            }
            else
            {
                MostrarMensaje("El nombre ya existe en esta carpeta.", "Error");
            }
        }

        private void ButtonBuscar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxBuscar.Text))
            {
                MostrarMensaje("Por favor, ingrese un término de búsqueda.", "Validación");
                return;
            }

            var resultados = arbol.BuscarPorNombre(textBoxBuscar.Text);

            if (resultados.Count == 0)
            {
                MostrarMensaje($"No se encontraron coincidencias para '{textBoxBuscar.Text}'.", "Búsqueda");
                AgregarAlResultados("No se encontraron resultados.");
                return;
            }

            textBoxResultados.Clear();
            AgregarAlResultados($"Resultados de búsqueda para '{textBoxBuscar.Text}':");
            AgregarAlResultados("═══════════════════════════════════════");

            foreach (var nodo in resultados)
            {
                string tipo = nodo.Tipo == TipoNodo.Carpeta ? "[Carpeta]" : "[Archivo]";
                AgregarAlResultados($"• {nodo.ObtenerRutaAbsoluta()} {tipo}");
            }

            AgregarAlResultados("═══════════════════════════════════════");
            AgregarAlResultados($"Total: {resultados.Count} resultado(s)");
        }

        private void ButtonMostrarRuta_Click(object sender, EventArgs e)
        {
            NodoArchivo nodo = ObtenerNodoSeleccionado();

            if (nodo == null)
            {
                MostrarMensaje("Por favor, seleccione un nodo del árbol.", "Selección");
                return;
            }

            rutaActual = nodo.ObtenerRutaAbsoluta();
            labelInfoRuta.Text = rutaActual;

            textBoxResultados.Clear();
            AgregarAlResultados($"Información del Nodo Seleccionado:");
            AgregarAlResultados("═══════════════════════════════════════");
            AgregarAlResultados($"Nombre: {nodo.Nombre}");
            AgregarAlResultados($"Tipo: {(nodo.Tipo == TipoNodo.Carpeta ? "Carpeta" : "Archivo")}");
            AgregarAlResultados($"Ruta: {rutaActual}");
            AgregarAlResultados($"Profundidad: {nodo.ObtenerProfundidad()}");

            if (nodo.Tipo == TipoNodo.Carpeta && nodo.Hijos != null)
            {
                AgregarAlResultados($"Cantidad de hijos: {nodo.Hijos.Count}");
                AgregarAlResultados($"Total de nodos en el subárbol: {nodo.ContarNodos()}");
                AgregarAlResultados($"Carpetas: {nodo.ContarCarpetas()}");
                AgregarAlResultados($"Archivos: {nodo.ContarArchivos()}");
                AgregarAlResultados("───────────────────────────────────────");
                AgregarAlResultados("Contenido:");
                foreach (var hijo in nodo.Hijos)
                {
                    string tipoHijo = hijo.Tipo == TipoNodo.Carpeta ? "📁" : "📄";
                    AgregarAlResultados($"  {tipoHijo} {hijo.Nombre}");
                }
            }
            else
            {
                AgregarAlResultados("(Este es un archivo)");
            }

            AgregarAlResultados("═══════════════════════════════════════");
        }

        private void ButtonEliminar_Click(object sender, EventArgs e)
        {
            NodoArchivo nodo = ObtenerNodoSeleccionado();

            if (nodo == null)
            {
                MostrarMensaje("Por favor, seleccione un nodo del árbol.", "Selección");
                return;
            }

            if (nodo == arbol.Raiz)
            {
                MostrarMensaje("No puede eliminar la carpeta raíz.", "Error");
                return;
            }

            DialogResult resultado = MessageBox.Show(
                $"¿Desea eliminar '{nodo.Nombre}' y todo su contenido?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (resultado == DialogResult.Yes)
            {
                if (arbol.EliminarNodo(nodo.ObtenerRutaAbsoluta()))
                {
                    MostrarMensaje($"Nodo '{nodo.Nombre}' eliminado exitosamente.", "Éxito");
                    ActualizarArbol();
                    AgregarAlResultados($"✓ Nodo eliminado: {nodo.Nombre}");
                }
                else
                {
                    MostrarMensaje("Error al eliminar el nodo.", "Error");
                }
            }
        }

        private void ButtonRecorridoPreorden_Click(object sender, EventArgs e)
        {
            var recorrido = arbol.RecorridoPreorden();
            MostrarRecorrido("RECORRIDO EN PREORDEN (Raíz → Izquierda → Derecha)", recorrido);
        }

        private void ButtonRecorridoPostorden_Click(object sender, EventArgs e)
        {
            var recorrido = arbol.RecorridoPostorden();
            MostrarRecorrido("RECORRIDO EN POSTORDEN (Izquierda → Derecha → Raíz)", recorrido);
        }

        private void ButtonRecorridoPorNiveles_Click(object sender, EventArgs e)
        {
            var recorrido = arbol.RecorridoPorNiveles();
            MostrarRecorrido("RECORRIDO POR NIVELES (BFS - Breadth First Search)", recorrido);
        }

        private void MostrarRecorrido(string titulo, List<string> recorrido)
        {
            textBoxResultados.Clear();
            AgregarAlResultados(titulo);
            AgregarAlResultados("═══════════════════════════════════════");

            int contador = 1;
            foreach (var ruta in recorrido)
            {
                AgregarAlResultados($"{contador}. {ruta}");
                contador++;
            }

            AgregarAlResultados("═══════════════════════════════════════");
            AgregarAlResultados($"Total de nodos recorridos: {recorrido.Count}");
        }

        private void ButtonEstadisticas_Click(object sender, EventArgs e)
        {
            textBoxResultados.Clear();
            AgregarAlResultados(arbol.ObtenerEstadisticas());
            AgregarAlResultados("");
            AgregarAlResultados("ESTRUCTURA DEL ÁRBOL:");
            AgregarAlResultados("═══════════════════════════════════════");
            AgregarAlResultados(arbol.ObtenerEstructuraArbol());
        }

        private void ButtonCrearEstructuraEjemplo_Click(object sender, EventArgs e)
        {
            arbol = new ArbolSistemaArchivos();

            // Crear estructura de ejemplo
            arbol.AgregarNodo("/root", "documentos", TipoNodo.Carpeta);
            arbol.AgregarNodo("/root/documentos", "cv.docx", TipoNodo.Archivo);
            arbol.AgregarNodo("/root/documentos", "tesis.pdf", TipoNodo.Archivo);

            arbol.AgregarNodo("/root", "fotos", TipoNodo.Carpeta);
            arbol.AgregarNodo("/root/fotos", "vacaciones", TipoNodo.Carpeta);
            arbol.AgregarNodo("/root/fotos/vacaciones", "playa.jpg", TipoNodo.Archivo);
            arbol.AgregarNodo("/root/fotos/vacaciones", "montaña.jpg", TipoNodo.Archivo);
            arbol.AgregarNodo("/root/fotos", "perfil.jpg", TipoNodo.Archivo);

            arbol.AgregarNodo("/root", "sistema", TipoNodo.Carpeta);
            arbol.AgregarNodo("/root/sistema", "config.sys", TipoNodo.Archivo);

            ActualizarArbol();
            textBoxResultados.Clear();
            AgregarAlResultados("✓ Estructura de ejemplo creada exitosamente.");
            AgregarAlResultados("");
            AgregarAlResultados(arbol.ObtenerEstructuraArbol());
            MostrarMensaje("Estructura de ejemplo creada.", "Éxito");
        }

        private void ButtonLimpiarResultados_Click(object sender, EventArgs e)
        {
            textBoxResultados.Clear();
        }

        private void AgregarAlResultados(string texto)
        {
            if (textBoxResultados.Text.Length > 0)
                textBoxResultados.AppendText(Environment.NewLine);
            textBoxResultados.AppendText(texto);
        }

        private void MostrarMensaje(string mensaje, string titulo)
        {
            MessageBox.Show(mensaje, titulo, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
