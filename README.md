# FinanTech
Proyecto final del módulo 1 del diplomado en microservicios

## Justificación de patrones de diseño utilizados

### 1. Builder:
Se utilizó el patrón Builder para separar la construcción de los reportes de su representación, permitiendo crear reportes en diferentes formatos (PDF, Excel, CSV) y con distintos niveles de procesamiento.

### 2. Strategy:
El patrón Strategy se aplicó en dos contextos:

- Para el procesamiento del contenido según el tipo de usuario (Ejecutivo, Auditor, Analista), permitiendo intercambiar la lógica de procesamiento de manera flexible.
- Para la entrega de reportes (correo, carpeta compartida, API), haciendo que el mecanismo de entrega sea intercambiable y extensible sin modificar el código cliente.

### 3. Decorator:
El patrón Decorator permite agregar funcionalidades opcionales a los reportes (encabezados, marcas de agua, compresión) de forma dinámica y combinable, sin modificar la clase base del reporte.

## Repositorio del proyecto

El código fuente de este proyecto está disponible en GitHub: [https://github.com/juanmmc/FinanTech](https://github.com/juanmmc/FinanTech)