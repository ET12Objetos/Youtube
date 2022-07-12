## Comandos dotnet

Desde el visual studio code abrir la terminal y escribir los siguientes comandos

Crear proyecto de consola
```
dotnet new console -o NOMBRE_PROYECTO
```

Acceder a la carpeta del proyecto NOMBRE_PROYECTO
```
cd NOMBRE_PROYECTO
```

Ver version de dotnet instalada
```
dotnet --version
```

Ejecutar proyecto
```
dotnet run 
```

Posicionarse en directorio nivel superior
```
cd ..
```

Crear proyecto de biblioteca
```
dotnet new classlib -o NOMBRE_PROYECTO.Biblioteca
```

Referencia de **proyecto consola** a **proyecto biblioteca**
```
dotnet add NOMBRE_PROYECTO/NOMBRE_PROYECTO.csproj reference NOMBRE_PROYECTO.Biblioteca/NOMBRE_PROYECTO.Biblioteca.csproj
```