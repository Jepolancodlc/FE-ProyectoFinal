# :octocat: FE-ProyectoFinal
Repositorio del proyecto final para el curso de .Net Framework de la Fundación Esplai.

## ✒️ Autores: 
  - Jhon E. Polanco de la Cruz - [@John Polanco](https://github.com/Jepolancodlc)
  - Arnau Diez Sans - [@ArnauDiezSans](https://github.com/ArnauDiezSans)
  - Víctor Alfonso Martí - [@Victor Alfonso Marti](https://github.com/VictorAlfonsoMarti)

## :octocat: Proyecto:
    - El proyecto ha sido desplegado online y es accesible a través de la siguiete url: http://trabajadoresnet.somee.com/

### :shipit: Proyecto para localhost:
    - Puede descargar el proyecto preparado para localhost en: https://github.com/Jepolancodlc/FE-ProyectoFinal/tree/Master_para_uso_en_local
    - Para poder acceder en el host, tendrá que realizar los siguientes cambios:
           - DB:
		```
		1. Descargar las dos Bases de Datos localizadas en: https://github.com/Jepolancodlc/FE-ProyectoFinal/tree/Master_para_uso_en_local/DB
		2. Cargar las dos Bases de Datos en local o en una máquina virtual usando Microsoft SQL Server.
                ```
           - API:
                ```
		1. Descargar la API localizada en: https://github.com/Jepolancodlc/FE-ProyectoFinal/tree/Master_para_uso_en_local/API_Proyecto_Team1_AJV
		2. Modificar el archivo appsettings.json localizado en la carpeta raiz :
		3. Sustituir el servidor, el usuario y la contraseña por las correspondientes en local. Database=TrabajadoresNet;
                  "AllowedHosts": "*",
                    "ConnectionStrings": {
                      "TrabajadoresNetDatabase": "Server=SERVER;Database=TrabajadoresNet;User ID=USER;Password=PASSWORD;MultipleActiveResultSets=true"
                    },
                ```

           - FRONT:
                ```
		1. Descargar el FRONT localizado en: https://github.com/Jepolancodlc/FE-ProyectoFinal/tree/Master_para_uso_en_local/FRONT_Proyecto_Team1_AJV
		2. Modificar el archivo appsettings.json localizado en la carpeta raiz :
		3. Sustituir el servidor, el usuario y la contraseña por las correspondientes en local. Database=UsersTrabajadoresNet;
                  "ConnectionStrings": {
                     "DefaultConnection": "Server=SERVER;Database=UsersTrabajadoresNet;User ID=USER;Password=PASSWORD"
                   },
		4. Revisar que las conexiones a los ENDPOINT de la API tengan el puerto correcto, cambiar el puerto si no coincidiera con el de la api en ejecución:
		4.1 Archivo token.js localizado en wwwroot/js:
			línea 9 --> url: "https://localhost:44304/api/TokenUsers",
		4.2 Archivo tabla.js localizado en wwwroot/js:
                        línea 17 --> url: "https://localhost:44304/api/Trabajadores",
			línea 106 --> url: "https://localhost:44304/api/Trabajadores/" + encodeURIComponent(niv_org),
                4.3 Archivo graph.js localizado en wwwroot/js:
			línea 685 --> url: "https://localhost:44304/api/Trabajadores/Poblacion",
			línea 708 --> url: "https://localhost:44304/api/Trabajadores/Genero",
			línea 731 --> url: "https://localhost:44304/api/Trabajadores/Poblacion/" + encodeURIComponent(filtro),
			línea 754 --> url: "https://localhost:44304/api/Trabajadores/Genero/" + encodeURIComponent(filtro),			
                ```


## 🏭 API:
#### ℹ️ Información de Desarrollo
```
IDE               Visual Studio 2019 Community Version
Core              C#
Framework         NET Core 3.1
DataBase          Microsoft Sql Server 
```
#### 🔐 Seguridad:
	- Se requiere autentificación por Token, esta autentificación se lanza en el header del FRONT
#### 📦 Paquetes Nuguet
```
Microsoft.VisualStudio.Web.CodeGeneration.Design  - Version 3.1.5
Microsoft.EntityFrameworkCore.Tools               - Version 3.1.12
Microsoft.EntityFrameworkCore.SqlServer           - Version 3.1.12
Microsoft.EntityFrameworkCore.Sqlite              - Version 3.1.12
System.IdentityModel.Tokens.Jwt                   - Version 5.6.0
Microsoft.AspNetCore.Authentication.JwtBearer     - Version 3.1.8
Swashbuckle.AspNetCore                            - Version 6.0.1
```
### 🏁 Swagger:
![swagger](https://user-images.githubusercontent.com/9554810/110242460-9776ea80-7f56-11eb-87ef-da3e9fc36989.png)

## 💻 FRONT: 
#### ℹ️ Información de Desarrollo
```
IDE               Visual Studio 2019 Community Version
Core              HTML, CSS, JavaScript, AJAX, JQUERY, Boostrapt, Kendo UI
Framework         NET Core 3.1
DataBase          Microsoft Sql Server 
```
#### 🔐 Seguridad:
	- Se requiere autentificación de usuario.
#### 📦 Paguetes NuGet
```
Microsoft.AspNetCore.Diagnostics.EntityFrameworkCore  - Version 3.1.10
Microsoft.AspNetCore.Identity.EntityFrameworkCore     - Version 3.1.12
Microsoft.AspNetCore.Identity.UI                      - Version 3.1.12
Microsoft.EntityFrameworkCore.SqlServer               - Version 3.1.12
Microsoft.EntityFrameworkCore.Tools                   - Version 3.1.12
Microsoft.VisualStudio.Web.CodeGeneration.Design      - Version 3.1.5
```
#### 🔑 Página de Login:
![TrabajadoresNet_Loguin](https://user-images.githubusercontent.com/9554810/110242623-271c9900-7f57-11eb-95a2-4090955f53c6.png)

#### 📅 Página Principal - Tabla
![TrabajadoresNet_Tabla](https://user-images.githubusercontent.com/9554810/110242648-474c5800-7f57-11eb-8e37-7477758889e5.png)

#### 📈 Página Principal - Gráficos
![TrabajadoresNet_Graficos](https://user-images.githubusercontent.com/9554810/110242669-664aea00-7f57-11eb-87e3-dc080a3c6aaa.png)

#### ✏️ Página Principal - Control de Usuario
![TrabajadoresNet_ControlUsuario](https://user-images.githubusercontent.com/9554810/110242705-8f6b7a80-7f57-11eb-9092-10c179d2b84c.png)


## 📚 Base de Datos   
  ### :newspaper: DataBases TrabajadoresNet y UsersTrabajadoresNet
  Hemos subido la DB propuesta para el proyecto en un server preparado para MSSQL2019 que nos ofrece gratuitamente la web www.somee.com, con el nombre TrabajadoresNet.
  Además, hemos creado otra base de datos para controlar el logueo. UsersTrabajadoresNet.
  
  #### TrabajadoresNet - Datos Trabajadores y Token
  ![DB_TrabajadoresNet](https://user-images.githubusercontent.com/9554810/110242526-ca20e300-7f56-11eb-9b74-b0299ba8228d.png)

  #### UsersTrabajadoresNet - Loguin
  ![DB_UsersTrabajadoresNet](https://user-images.githubusercontent.com/9554810/110242500-b70e1300-7f56-11eb-8c49-7de5be6188b7.png)

## 🔧 DESARROLLO: 
  ### 📋 URL de desarrollo:
  - [Kanban](https://trello.com/b/cyLtvxC1/trabajadoresnet)

  #### 📺 Esquema del HTML 
  ![TrabajadoresNet_EsquemaHTML](https://user-images.githubusercontent.com/9554810/110242573-fb011800-7f56-11eb-99cc-d96a3c9ee03e.png)

  #### 🌈 Paleta de Colores 
  ![TrabajadoresNet_PaletaColores](https://user-images.githubusercontent.com/9554810/110242545-dc9b1c80-7f56-11eb-8bee-3157363cc64a.png)

