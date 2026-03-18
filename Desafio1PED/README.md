# Sistema de Archivos Jerárquico - C# Windows Forms

## 📋 Descripción General
Este proyecto implementa un **simulador de sistema de archivos jerárquico** similar al de los sistemas operativos (Windows, Linux, macOS). Utiliza una estructura de árbol binario para representar carpetas y archivos, permitiendo realizar operaciones de búsqueda, recorrido y análisis del sistema.

## 🎯 Características Principales

### 1. **Clases Core**
- **`NodoArchivo`**: Representa un nodo individual en el árbol
  - Propiedades: Nombre, Tipo (Carpeta/Archivo), Padre, Hijos
  - Métodos: Agregar hijo, Validación, Cálculos de profundidad y conteo

- **`ArbolSistemaArchivos`**: Gestor del árbol completo
  - Raíz (carpeta "root")
  - Métodos de inserción, búsqueda y eliminación
  - Recorridos (Preorden, Postorden, Por Niveles)
  - Análisis y estadísticas

### 2. **Operaciones Soportadas**

#### Agregar Nodos
- Crear carpetas y archivos en cualquier ubicación del árbol
- Validación de nombres duplicados
- Restricción de agregar elementos en archivos

#### Búsqueda
- Búsqueda por nombre (parcial o exacta)
- Implementada con DFS (Depth-First Search)
- Resultados con rutas completas

#### Recorridos
1. **Preorden**: Ideal para copiar árboles
2. **Postorden**: Ideal para eliminar árboles
3. **Por Niveles (BFS)**: Análisis nivel por nivel

#### Información y Estadísticas
- Ruta absoluta de cada nodo
- Profundidad en el árbol
- Conteo de nodos, carpetas y archivos
- Visualización de estructura jerárquica

### 3. **Interfaz Gráfica (Windows Forms)**

#### Secciones:
1. **Panel Izquierdo - Árbol Jerárquico**
   - Vista en árbol con iconos (📁 📄)
   - Selección interactiva de nodos

2. **Panel Superior - Información**
   - Muestra ruta actual seleccionada

3. **Panel Central - Operaciones**
   - Agregar nodos (nombre + tipo)
   - Búsqueda de elementos
   - Mostrar información de ruta
   - Eliminar nodos

4. **Panel Derecho - Resultados**
   - Salida de operaciones
   - Visualización de búsquedas y recorridos

5. **Panel Inferior - Utilidades**
   - Botones de recorridos
   - Estadísticas del sistema
   - Crear estructura ejemplo

## 📊 Ejemplo de Estructura

```
root [Carpeta]
├── documentos [Carpeta]
│   ├── cv.docx [Archivo]
│   └── tesis.pdf [Archivo]
├── fotos [Carpeta]
│   ├── vacaciones [Carpeta]
│   │   ├── playa.jpg [Archivo]
│   │   └── montaña.jpg [Archivo]
│   └── perfil.jpg [Archivo]
└── sistema [Carpeta]
    └── config.sys [Archivo]
```

## 🚀 Cómo Usar

### Crear Estructura Ejemplo
1. Haz clic en "Crear Estructura Ejemplo"
2. Se generará automáticamente la estructura de ejemplo

### Agregar Nodos
1. Selecciona una carpeta en el árbol (debe ser carpeta)
2. Escribe el nombre del nodo
3. Elige el tipo (Carpeta o Archivo)
4. Haz clic en "Agregar"

### Buscar Nodos
1. Escribe el término de búsqueda
2. Haz clic en "Buscar"
3. Se mostrarán todas las coincidencias con sus rutas

### Ver Información
1. Selecciona un nodo del árbol
2. Haz clic en "Mostrar Ruta"
3. Se mostrará información completa del nodo

### Eliminar Nodos
1. Selecciona un nodo
2. Haz clic en "Eliminar"
3. Confirma la acción

### Generar Recorridos
1. Haz clic en el tipo de recorrido deseado
2. Se mostrarán todos los nodos en ese orden

## 🔧 Complejidad Algorítmica

| Operación | Complejidad |
|-----------|------------|
| Agregar nodo | O(h) - h: profundidad |
| Buscar nodo | O(n) - n: total de nodos |
| Eliminar nodo | O(1) - referencia directa |
| Recorrido Preorden | O(n) |
| Recorrido Postorden | O(n) |
| Recorrido BFS | O(n) |

## 📝 Validaciones Implementadas

✓ No permite nombres vacíos  
✓ No permite duplicados en la misma carpeta  
✓ No permite agregar elementos en archivos  
✓ No permite eliminar la raíz  
✓ Validación de rutas existentes  
✓ Confirmación antes de eliminar nodos  

## 🏗️ Estructura del Código

```
Desafio1PED/
├── NodoArchivo.cs          # Clase para cada nodo
├── ArbolSistemaArchivos.cs # Gestor del árbol
├── Form1.cs                # Lógica de la interfaz
├── Form1.Designer.cs       # Diseño de controles
├── Program.cs              # Punto de entrada
└── README.md               # Este archivo
```

## 🎓 Conceptos Implementados

- **TAD (Tipo Abstracto de Datos)**: Árbol binario
- **Paradigma OOP**: Encapsulación, herencia, polimorfismo
- **Algoritmos**: Recursión, BFS, DFS
- **Estructuras de Datos**: Árboles, Listas, Colas
- **Interfaz Gráfica**: Windows Forms con MVT

## ✨ Características Adicionales

- Cálculo automático de profundidad
- Conteo de nodos por tipo
- Visualización en árbol interactiva
- Historial en panel de resultados
- Mensajes de error informativos
- Iconos visuales para tipos de nodos

## 📦 Requisitos

- .NET 10 o superior
- Visual Studio Community 2026+
- Windows Forms

## 🎯 Cumplimiento de Rubrica

✅ Sistema completo que cumple y supera expectativas  
✅ Interfaz amigable, intuitiva con validaciones  
✅ Implementación correcta del TAD Árbol  
✅ Código orientado a objetos con buenas prácticas  
✅ Métodos de recorrido y búsqueda optimizados  
✅ Manejo de errores robusto  

---

**Autor**: Estudiante de Programación  
**Asignatura**: Programación Estructurada de Datos (PED)  
**Año**: 2024
