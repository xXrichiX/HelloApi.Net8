# HolaMundoAPI

## Descripción del proyecto

HolaMundoAPI es un proyecto de ejemplo desarrollado con ASP.NET Core Web API en C#.

Su propósito es demostrar una arquitectura en capas que retorna un mensaje sencillo a través de un servicio, aplicando buenas prácticas como la inyección de dependencias para un código desacoplado y mantenible.

## Características principales

- API simple y funcional
- Arquitectura en capas: Controller, Service, Interface, Model
- Implementación de inyección de dependencias para desacoplar componentes
- Endpoint /api/Mensaje que devuelve un mensaje en formato JSON

## Cómo ejecutar el proyecto

1. Clona el repositorio

   git clone https://github.com/xXrichiX/HelloApi.Net8.git
  

2. Ejecuta la aplicación

   dotnet run

3. Prueba el endpoint

   - Swagger UI: abre en tu navegador la URL http://localhost:5197/swagger para explorar y probar la API de forma interactiva
   - Postman: envía una petición GET a http://localhost:5197/api/Mensaje para obtener el mensaje en formato JSON
