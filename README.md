# Proyecto-Blazor-Desarrollo-web  
Grupo:  
Jose CentenoS  
Kaeel Martinez  
Sebastian Lopez  
Camilo Canedo  
Jaider Ardila  

## Links del proyecto  
- Archivo de proyecto: *https://www.mediafire.com/file/mlfp35l69fsfn77/ProyectoBlazor.rar/file*  
- Videos: *https://drive.google.com/drive/folders/1iDqVw7_ffaOCZmgo9ER7spunwYVlBOw-?usp=drive_link*  

# Informe del Proyecto – Sistema de Notas en Blazor

## 1. Introducción
Este informe describe la estructura, funcionamiento y organización del proyecto desarrollado en **Blazor WebAssembly**, cuyo objetivo es simular un sistema académico donde un estudiante inicia sesión y visualiza sus cursos y notas.

El proyecto sirve como base para una futura integración con una base de datos real y una API. Se aplican principios de separación de responsabilidades, uso de servicios, modelos de datos y componentes UI propios de la arquitectura Blazor.

---

## 2. Estructura General del Proyecto
El proyecto está organizado en carpetas y archivos según su función, permitiendo claridad, escalabilidad y fácil mantenimiento.

---

## 3. Carpetas y Contenido

### 3.1 **Carpeta wwwroot**
Contiene los recursos estáticos del proyecto.

**Archivos importantes:**
- **index.html** – Punto de entrada de la aplicación Blazor.
- **css/site.css** – Estilos globales del sistema.

**Función:** almacenar archivos accesibles por el navegador (imágenes, íconos, estilos).

---

### 3.2 **Carpeta Models**
Define la estructura de datos.

**Archivos:**
- **Course.cs** – Representa un curso.
- **Grade.cs** – Representa una nota asociada a un curso.

**Objetivo:** manejo tipado de datos e integración futura con APIs.

---

### 3.3 **Carpeta Services**
Contiene la lógica del sistema.

**Archivo:**
- **StudentState.cs** – Maneja el estado del estudiante, inicio de sesión, cursos y notas.

**Función:** centralizar lógica de negocio.

---

### 3.4 **Carpeta Pages**
Contiene las páginas visibles al usuario.

**Archivos:**
- **Login.razor** – Página de inicio de sesión.
- **Notas.razor** – Muestra cursos, notas y promedios.

**Función:** interfaz principal del sistema.

---

### 3.5 **Carpeta Shared**
Componentes reutilizables.

**Archivo:**
- **MainLayout.razor** – Cabecera, estructura y contenedor de páginas.

---

## 4. Archivos Raíz Importantes

### 4.1 **Program.cs**
Configura la aplicación y registra servicios como `StudentState`.

### 4.2 **App.razor**
Define el sistema de rutas y navegación.

### 4.3 **_Imports.razor**
Agrupa `using` comunes para todas las páginas.

---

## 5. Funcionamiento del Sistema
1. El usuario inicia en la página **Login**.  
2. Ingresa su nombre o identificador.  
3. `StudentState` almacena los datos.  
4. El usuario es dirigido a **Notas**, donde se cargan cursos, notas y promedios asociados.  

---

## 6. Conclusiones
El proyecto está estructurado con buenas prácticas, listo para conectarse a una API real y funciona como un ejemplo completo de manejo de estado, navegación y componentes en Blazor.

