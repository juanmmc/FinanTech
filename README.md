# FinanTech
Proyecto final del módulo 1 del diplomado en microservicios

## Justificación de la elección de patrones
***
### 1. Builder:
Permite construir reportes complejos paso a paso, soportando múltiples formatos (PDF, Excel, CSV) y niveles de procesamiento (básico, detallado, encriptado) sin acoplar la lógica de construcción a la lógica de uso.

### 2. Strategy:
Permite intercambiar dinámicamente la forma de entregar el reporte (correo, carpeta compartida, API) sin modificar la lógica principal.

### 3. Decorator:
Permite agregar funcionalidades opcionales (encabezados, marcas de agua, cifrado, compresión) de manera flexible y combinable, sin modificar la clase base del reporte.
