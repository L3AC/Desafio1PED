using System;
using System.Collections.Generic;

namespace Desafio1PED
{
    /// <summary>
    /// Representa un nodo en el árbol del sistema de archivos.
    /// Puede ser una carpeta o un archivo.
    /// </summary>
    public class NodoArchivo
    {
        public string Nombre { get; set; }
        public TipoNodo Tipo { get; set; }
        public NodoArchivo Padre { get; set; }
        public List<NodoArchivo> Hijos { get; set; }

        /// Constructor para crear un nuevo nodo.
        /// <param name="nombre">Nombre del nodo</param>
        /// <param name="tipo">Tipo: Carpeta o Archivo</param>
        public NodoArchivo(string nombre, TipoNodo tipo)
        {
            Nombre = nombre ?? "Sin nombre";
            Tipo = tipo;
            Padre = null;
            Hijos = tipo == TipoNodo.Carpeta ? new List<NodoArchivo>() : null;
        }
        /// Agrega un hijo a este nodo (solo si es carpeta).
        public bool AgregarHijo(NodoArchivo hijo)
        {
            if (Tipo != TipoNodo.Carpeta)
                return false;

            if (hijo == null || ExisteHijo(hijo.Nombre))
                return false;

            hijo.Padre = this;
            Hijos.Add(hijo);
            return true;
        }
        // Verifica si existe un hijo con el nombre especificado.
        public bool ExisteHijo(string nombre)
        {
            if (Tipo != TipoNodo.Carpeta)
                return false;

            return Hijos.Exists(h => h.Nombre.Equals(nombre, StringComparison.OrdinalIgnoreCase));
        }
        /// Obtiene la ruta absoluta del nodo.
        public string ObtenerRutaAbsoluta()
        {
            if (Padre == null)
                return "/" + Nombre;

            return Padre.ObtenerRutaAbsoluta() + "/" + Nombre;
        }

        /// Obtiene la cantidad total de nodos en el subárbol (incluyendo este nodo).
        public int ContarNodos()
        {
            int count = 1;
            if (Tipo == TipoNodo.Carpeta && Hijos != null)
            {
                foreach (var hijo in Hijos)
                {
                    count += hijo.ContarNodos();
                }
            }
            return count;
        }

        /// Obtiene la cantidad total de carpetas en el subárbol.
        public int ContarCarpetas()
        {
            int count = 0;
            if (Tipo == TipoNodo.Archivo)
            {
                count = 1;
            }
            if (Tipo == TipoNodo.Carpeta && Hijos != null)
            {
                foreach (var hijo in Hijos)
                {
                    count += hijo.ContarCarpetas();
                }
            }
            return count;
        }

        /// Obtiene la cantidad total de archivos en el subárbol.
        public int ContarArchivos()
        {
            int count = 0;
            if (Tipo == TipoNodo.Archivo)
            {
                count = 1;
            }
            if (Tipo == TipoNodo.Carpeta && Hijos != null)
            {
                foreach (var hijo in Hijos)
                {
                    count += hijo.ContarArchivos();
                }
            }
            return count;
        }

        /// <summary>
        /// Obtiene el nivel de profundidad del nodo en el árbol.
        /// </summary>
        public int ObtenerProfundidad()
        {
            if (Padre == null)
                return 0;
            return 1 + Padre.ObtenerProfundidad();
        }
    }

    /// <summary>
    /// Enumeración para los tipos de nodos.
    /// </summary>
    public enum TipoNodo
    {
        Carpeta,
        Archivo
    }
}
