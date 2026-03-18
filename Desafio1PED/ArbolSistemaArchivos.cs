using System;
using System.Collections.Generic;
using System.Text;

namespace Desafio1PED
{
    /// <summary>
    /// Árbol que representa el sistema jerárquico de archivos.
    /// </summary>
    public class ArbolSistemaArchivos
    {
        public NodoArchivo Raiz { get; private set; }

        /// <summary>
        /// Constructor que crea el árbol con una carpeta raíz.
        /// </summary>
        public ArbolSistemaArchivos()
        {
            Raiz = new NodoArchivo("root", TipoNodo.Carpeta);
        }

        /// <summary>
        /// Agrega un nodo en una ruta especificada.
        /// </summary>
        /// <param name="rutaDestino">Ruta donde agregar el nodo (ej: "/root/documentos")</param>
        /// <param name="nombreNodo">Nombre del nodo a crear</param>
        /// <param name="tipo">Tipo del nodo (Carpeta o Archivo)</param>
        /// <returns>true si se agregó exitosamente</returns>
        public bool AgregarNodo(string rutaDestino, string nombreNodo, TipoNodo tipo)
        {
            if (string.IsNullOrWhiteSpace(nombreNodo))
                return false;

            NodoArchivo padre = BuscarPorRuta(rutaDestino);
            if (padre == null || padre.Tipo != TipoNodo.Carpeta)
                return false;

            var nuevoNodo = new NodoArchivo(nombreNodo, tipo);
            return padre.AgregarHijo(nuevoNodo);
        }

        /// <summary>
        /// Busca un nodo por su ruta absoluta.
        /// </summary>
        public NodoArchivo BuscarPorRuta(string ruta)
        {
            if (string.IsNullOrWhiteSpace(ruta) || ruta == "/root")
                return Raiz;

            // Normalizar la ruta
            ruta = ruta.Trim('/');
            if (ruta.StartsWith("root"))
                ruta = ruta.Substring(4).Trim('/');

            if (string.IsNullOrWhiteSpace(ruta))
                return Raiz;

            string[] partes = ruta.Split(new[] { '/' }, System.StringSplitOptions.RemoveEmptyEntries);
            NodoArchivo actual = Raiz;

            foreach (var parte in partes)
            {
                if (actual.Tipo != TipoNodo.Carpeta)
                    return null;

                actual = actual.Hijos.Find(h => h.Nombre.Equals(parte, StringComparison.OrdinalIgnoreCase));
                if (actual == null)
                    return null;
            }

            return actual;
        }

        /// <summary>
        /// Busca nodos por nombre usando DFS (búsqueda en profundidad).
        /// </summary>
        public List<NodoArchivo> BuscarPorNombre(string nombre, bool esExacto = false)
        {
            var resultados = new List<NodoArchivo>();
            BuscarPorNombreDFS(Raiz, nombre, esExacto, resultados);
            return resultados;
        }

        private void BuscarPorNombreDFS(NodoArchivo nodo, string nombre, bool esExacto, List<NodoArchivo> resultados)
        {
            bool coincide = esExacto
                ? nodo.Nombre.Equals(nombre, StringComparison.OrdinalIgnoreCase)
                : nodo.Nombre.Contains(nombre, StringComparison.OrdinalIgnoreCase);

            if (coincide)
                resultados.Add(nodo);

            if (nodo.Tipo == TipoNodo.Carpeta && nodo.Hijos != null)
            {
                foreach (var hijo in nodo.Hijos)
                {
                    BuscarPorNombreDFS(hijo, nombre, esExacto, resultados);
                }
            }
        }

        /// <summary>
        /// Recorrido en preorden (raíz, izquierda, derecha).
        /// Útil para copiar árboles.
        /// </summary>
        public List<string> RecorridoPreorden()
        {
            var resultado = new List<string>();
            RecorridoPreordenRec(Raiz, resultado);
            return resultado;
        }

        private void RecorridoPreordenRec(NodoArchivo nodo, List<string> resultado)
        {
            resultado.Add(nodo.ObtenerRutaAbsoluta());

            if (nodo.Tipo == TipoNodo.Carpeta && nodo.Hijos != null)
            {
                foreach (var hijo in nodo.Hijos)
                {
                    RecorridoPreordenRec(hijo, resultado);
                }
            }
        }

        /// <summary>
        /// Recorrido en postorden (izquierda, derecha, raíz).
        /// Útil para eliminar árboles.
        /// </summary>
        public List<string> RecorridoPostorden()
        {
            var resultado = new List<string>();
            RecorridoPostordenRec(Raiz, resultado);
            return resultado;
        }

        private void RecorridoPostordenRec(NodoArchivo nodo, List<string> resultado)
        {
            if (nodo.Tipo == TipoNodo.Carpeta && nodo.Hijos != null)
            {
                foreach (var hijo in nodo.Hijos)
                {
                    RecorridoPostordenRec(hijo, resultado);
                }
            }

            resultado.Add(nodo.ObtenerRutaAbsoluta());
        }

        /// <summary>
        /// Recorrido por niveles (BFS - Breadth First Search).
        /// </summary>
        public List<string> RecorridoPorNiveles()
        {
            var resultado = new List<string>();
            var cola = new Queue<NodoArchivo>();
            cola.Enqueue(Raiz);

            while (cola.Count > 0)
            {
                var nodo = cola.Dequeue();
                resultado.Add(nodo.ObtenerRutaAbsoluta());

                if (nodo.Tipo == TipoNodo.Carpeta && nodo.Hijos != null)
                {
                    foreach (var hijo in nodo.Hijos)
                    {
                        cola.Enqueue(hijo);
                    }
                }
            }

            return resultado;
        }

        /// <summary>
        /// Obtiene la estructura del árbol como un texto jerárquico.
        /// </summary>
        public string ObtenerEstructuraArbol()
        {
            var sb = new StringBuilder();
            ObtenerEstructuraArbolRec(Raiz, "", sb, true);
            return sb.ToString();
        }

        private void ObtenerEstructuraArbolRec(NodoArchivo nodo, string prefijo, StringBuilder sb, bool esUltimo)
        {
            // Determinar el símbolo a usar (├── o └──)
            string conector = esUltimo ? "└── " : "├── ";

            // No mostrar conector para la raíz
            if (nodo.Padre != null)
                sb.Append(prefijo + conector);

            sb.AppendLine(nodo.Nombre + (nodo.Tipo == TipoNodo.Carpeta ? " [Carpeta]" : " [Archivo]"));

            if (nodo.Tipo == TipoNodo.Carpeta && nodo.Hijos != null && nodo.Hijos.Count > 0)
            {
                string nuevoPrefi = prefijo + (nodo.Padre == null ? "" : (esUltimo ? "    " : "│   "));

                for (int i = 0; i < nodo.Hijos.Count; i++)
                {
                    bool esUltimoHijo = i == nodo.Hijos.Count - 1;
                    ObtenerEstructuraArbolRec(nodo.Hijos[i], nuevoPrefi, sb, esUltimoHijo);
                }
            }
        }

        /// <summary>
        /// Elimina un nodo especificado por su ruta.
        /// </summary>
        public bool EliminarNodo(string ruta)
        {
            NodoArchivo nodo = BuscarPorRuta(ruta);
            if (nodo == null || nodo.Padre == null) // No se puede eliminar la raíz
                return false;

            return nodo.Padre.Hijos.Remove(nodo);
        }

        /// <summary>
        /// Obtiene estadísticas del árbol.
        /// </summary>
        public string ObtenerEstadisticas()
        {
            int totalNodos = Raiz.ContarNodos();
            int totalCarpetas = Raiz.ContarCarpetas();
            int totalArchivos = Raiz.ContarArchivos();
            int profundidadMaxima = ObtenerProfundidadMaxima(Raiz);

            var sb = new StringBuilder();
            sb.AppendLine("=== ESTADÍSTICAS DEL SISTEMA DE ARCHIVOS ===");
            sb.AppendLine($"Total de nodos: {totalNodos}");
            sb.AppendLine($"Total de carpetas: {totalCarpetas}");
            sb.AppendLine($"Total de archivos: {totalArchivos}");
            sb.AppendLine($"Profundidad máxima: {profundidadMaxima}");

            return sb.ToString();
        }

        private int ObtenerProfundidadMaxima(NodoArchivo nodo)
        {
            if (nodo.Tipo != TipoNodo.Carpeta || nodo.Hijos == null || nodo.Hijos.Count == 0)
                return 0;

            int maxProfundidad = 0;
            foreach (var hijo in nodo.Hijos)
            {
                int profundidad = 1 + ObtenerProfundidadMaxima(hijo);
                maxProfundidad = Math.Max(maxProfundidad, profundidad);
            }

            return maxProfundidad;
        }
    }
}
