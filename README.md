# Microsoft Azure for Dummies
Seminario de introducción a la plataforma cloud de Microsoft Azure

![Microsoft Azure](https://ktconnections.com/images/easyblog_articles/658/microsoft-azure-500x500.png)

# Para empezar
Azure es un conjunto completo y en expansión constante de servicios de informática en la nube que nos ayuda a afrontar proyectos y desafíos. Con Azure podemos crear, administrar e implementar aplicaciones en una red mundial enorme utilizando nuestras herramientas favoritas.

## Características
- Productivo
- Hibrido
- Inteligente
- De confianza

Azure, es global. Actualmente es la plataforma en la nube que más está presente en distintas partes del mundo permitiéndonos reducir costes y tiempo.

![Azure es global](https://www.thomasmaurer.ch/wp-content/uploads/2019/08/Microsoft-Azure-Regions-Map-with-Swiss-Azure-Regions-Switzerland.jpg)

## Servicios
Azure tiene una gran cantidad de servicios a usar en el que destacan las siguientes categorías:

- Aplicaciones web y móvil
- Redes
- Administración y seguridad
- Computación
- Datos y almacenaje
- IOT


# App Service
Azure App Service nos permite crear y hospedar aplicaciones web, back-ends móviles y APIs RESTful en el lenguaje de programación que queramos sin tener que administrar la infraestructura.

<img src="https://slideplayer.com/slide/12341982/73/images/2/Azure+App+Service+Family.jpg" alt="azureAppService" width="530" height="300"></img>

## Características
- Escalado automático
- Alta disponibilidad
- Compatible con Windows y Linux
- Implementaciones automatizadas desde repositorios Git.

## Plataformas compatibles
- .NET
- Python (solo en Linux)
- Node.js
- PHP
- Java
- HTML
- Contenedor Docker

## Implementaciones compatibles
- ZIP / WAR
- FTP
- Git Local
- Azure DevOps
- Jenkins (mediante plugin)
- GitHub
- Bitbucket
- Dropbox

## Implementar en un AppService
Lo que vamos hacer ahora, es una pequeña demo de como subir una aplicación web SPA desarrollada con Angular 8 y ASP.NET Core 2.2 en un nuevo AppService. Para ello vamos a usar Visual Studio Code y la extensión [Azure App Service](vscode:extension/ms-azuretools.vscode-azureappservice).

1. Abrimos el proyecto con vscode y iniciamos sesión en nuestra cuenta de Microsoft dentro del IDE.

![Inicio de sesión](https://i.ibb.co/h9zLx0g/1.png)
![Reedirección al navegador](https://i.ibb.co/J5P6QdM/2.png)

2. Ahora, en el explorado de Azure App Service, le damos a la flecha azul para indicar una subida. Y luego le damos a "Create new web app".

![Upload](https://i.ibb.co/1Xk5dwC/4.png)
![Crear nuevo app service](https://i.ibb.co/rQwmk1b/3-5.png)

3. Le ponemos un nombre a nuestro nuevo app service

![App service name](https://i.ibb.co/z7cSKYR/5.png)

4. Creamos un nuevo recurso si no tenemos uno previo creado

![Group resource](https://i.ibb.co/c6trq4X/6.png)

5. Seleccionamos el sistema operativo para el App Service, en mi caso quiero que corra en Linux.

![Seleccion sistema operativo](https://i.ibb.co/w0YLhPY/7.png)

6. Seleccionamos el ejecutable con el que se ejecutará nuestra aplicación, en mi caso .NET Core 2.2

![Escoger runtime](https://i.ibb.co/cvJJRSf/8.png)

7. Si no tenemos un plan de app service creamos uno nuevo y le damos un nombre, luego seleccionamos el plan de app service, podemos usar el F1 que es gratis o el B1 que es el básico.

![Crear plan servicio](https://i.ibb.co/nP9DFg5/9.png)
![Plan básico](https://i.ibb.co/D7tw7pm/10.png)

8. Nos preguntará si queremos crear un recurso Insights, omitimos esto.

![Ignorar insights](https://i.ibb.co/w0pTDm1/11.png)

9. Por último seleccionamos la región dónde queremos implementar nuestro app service.

![Seleccionar región de despliegue](https://i.ibb.co/vc9DZWq/12.png)

10. Esperamos a que acabe la implementación, es un proceso automático, relajate y espera unos minutos.

11. Listo, verás que el app service esta en el explorador de app service, podrás navegar a la web para visualizarla.

# Azure Functions
Azure Functions es un servicio de proceso sin servidor que nos permite ejecutar código a petición sin necesidad de aprovisionar ni administrar explicitamente una infraestructura. Normalmente se usa para ejecutar scripts o fragmentos de código en respuesta a diversos eventos.

## Eventos compatibles
- HTTP
- Temporizadores
- Azure Cosmos DB
- Blob
- Cola

