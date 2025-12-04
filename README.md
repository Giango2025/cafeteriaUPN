🍽️ Sistema de Reservas - Cafetería UPN
📋 Descripción del Proyecto
Sistema de gestión de reservas para la cafetería universitaria que permite a los estudiantes hacer reservas diarias de combos de comida organizadas por turnos (mañana y tarde). El sistema cuenta con validación de cupos, gestión completa de reservas y reportes de ingresos.

✨ Características Principales

✅ Gestión de Menú: 3 combos predefinidos con nombre y precio
✅ Sistema de Turnos: Mañana y Tarde (2 turnos)
✅ Control de Cupos: Máximo 20 reservas por turno
✅ Operaciones CRUD: Crear, leer, actualizar y eliminar reservas
✅ Búsqueda: Localizar reservas por nombre del estudiante
✅ Reportes: Cálculo de ingresos por turno y totales
✅ Validaciones: Control de datos de entrada y disponibilidad


🛠️ Requisitos Técnicos
Tecnologías Utilizadas

Lenguaje: C# (.NET)
Versión recomendada: .NET 6.0 o superior
IDE recomendado: Visual Studio 2022 / Visual Studio Code / Rider

Estructuras de Datos

Arreglos unidimensionales para menú de combos
Matrices bidimensionales (2D) para gestión de reservas

Filas: Turnos (Mañana/Tarde)
Columnas: Reservas (hasta 20 por turno)




🚀 Instalación y Ejecución
Opción 1: Desde la Terminal
bash# 1. Clonar el repositorio
git clone https://github.com/TU-USUARIO/CafeteriaUPN-Sistema-Reservas.git

# 2. Navegar al directorio del proyecto
cd CafeteriaUPN-Sistema-Reservas/CafeteriaUPN_
## 📖 Manual de Uso

### Menú Principal

Al ejecutar el programa, verás las siguientes opciones:
```
=== Sistema de Reservas UPN ===
1. Mostrar Menú de Combos
2. Registrar Reserva
3. Cancelar Reserva
4. Listar Reservas por Turno
5. Reporte de Ingresos (Totales)
6. Buscar Reserva por Nombre
0. Salir
```

### Ejemplo de Uso Completo

#### 1️⃣ **Ver el Menú de Combos**
```
Opción seleccionada: 1

--- MENÚ DE COMBOS ---
[1] Café + Pan (S/. 5.50)
[2] Jugo + Sándwich (S/. 7.00)
[3] Menú Saludable (S/. 10.00)
```

#### 2️⃣ **Registrar una Reserva**
```
Opción seleccionada: 2

Nombre del Estudiante: Juan Perez
Turno (1: Mañana | 2: Tarde): 1
Combo a reservar [1, 2, 3...]: 2

✅ Reserva registrada para JUAN PEREZ en turno Mañana.
```

#### 3️⃣ **Listar Reservas por Turno**
```
Opción seleccionada: 4

--- LISTADO DE RESERVAS POR TURNO ---

== TURNO MAÑANA ==
- Estudiante: JUAN PEREZ | Combo: Jugo + Sándwich (S/. 7.00)
- Estudiante: MARIA LOPEZ | Combo: Café + Pan (S/. 5.50)
Total de reservas activas: 2 / 20

== TURNO TARDE ==
Total de reservas activas: 0 / 20
```

#### 4️⃣ **Buscar Reserva por Nombre**
```
Opción seleccionada: 6

Nombre del Estudiante a Buscar: Juan Perez

✅ RESERVA ENCONTRADA:
- Turno: Mañana
- Combo: Jugo + Sándwich
- Precio: S/. 7.00
```

#### 5️⃣ **Reporte de Ingresos**
```
Opción seleccionada: 5

--- REPORTE DE INGRESOS ---
Ingreso Turno Mañana: S/. 12.50
Ingreso Turno Tarde: S/. 0.00
-----------------------------
INGRESOS TOTALES: S/. 12.50
```

#### 6️⃣ **Cancelar una Reserva**
```
Opción seleccionada: 3

Nombre del Estudiante a Cancelar: Juan Perez

✅ Reserva de JUAN PEREZ (Combo: Jugo + Sándwich) en Turno Mañana ha sido cancelada.
```

---

## 🎯 Funcionalidades Implementadas

### Requisitos Funcionales Cumplidos ✅

| Requisito | Estado | Descripción |
|-----------|--------|-------------|
| Menú de combos | ✅ | 3 combos con nombre y precio |
| Matriz 2D | ✅ | Filas=Turnos, Columnas=Reservas (hasta 20) |
| Registrar reserva | ✅ | Con validación de cupo por turno |
| Cancelar reserva | ✅ | Busca y elimina por nombre |
| Listar reservas | ✅ | Muestra reservas organizadas por turno |
| Calcular ingresos | ✅ | Por turno y total general |
| Buscar por nombre | ✅ | Localiza reserva del estudiante |
| Manejo de cadenas | ✅ | Nombres estandarizados (ToUpper, Trim) |

### Estructuras de Programación Utilizadas

- ✅ **Estructuras Repetitivas**: `for`, `do-while`
- ✅ **Estructuras Condicionales**: `if-else`, `switch`
- ✅ **Funciones propias**: `void` y con parámetros
- ✅ **Tipos de retorno**: `void`, `double`
- ✅ **Arreglos**: Unidimensionales y Matrices 2D
- ✅ **Manejo de cadenas**: `.ToUpper()`, `.Trim()`