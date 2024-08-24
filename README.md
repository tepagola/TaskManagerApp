# Aplicación Gestor de Tareas

## Descripción

Esta es una aplicación simple de gestión de tareas construida utilizando WPF (Windows Presentation Foundation) siguiendo el patrón MVVM (Modelo-Vista-ViewModel). La aplicación permite a los usuarios crear, editar, eliminar y gestionar tareas. Las tareas se pueden categorizar, priorizar y marcar como completadas. La aplicación persiste los datos en un archivo JSON, asegurando que las tareas se guarden entre sesiones.

## Características

- **Agregar Tarea**: Los usuarios pueden agregar una nueva tarea especificando un título. La tarea se muestra inmediatamente en la lista de tareas.
- **Editar Tarea**: Los usuarios pueden editar el título de una tarea existente. Los cambios se guardan inmediatamente y se reflejan en la lista de tareas.
- **Eliminar Tarea**: Los usuarios pueden eliminar una tarea seleccionada de la lista.
- **Marcar Tarea como Completada**: Cada tarea tiene un checkbox que permite al usuario marcarla como completada. Este estado se guarda automáticamente.
- **Persistencia de Datos**: Las tareas se guardan en un archivo JSON, asegurando que los datos se retengan entre sesiones.

## Tecnologías Utilizadas

- **.NET Core**: La aplicación está construida usando .NET Core para compatibilidad multiplataforma.
- **WPF (Windows Presentation Foundation)**: Usado para crear la interfaz gráfica de usuario.
- **Patrón MVVM**: La aplicación sigue el patrón MVVM para separar responsabilidades y mantener un código limpio y testeable.
- **JSON**: Los datos de las tareas se almacenan en un archivo JSON para facilitar la serialización y deserialización.

## Comenzando

### Prerrequisitos

- **.NET Core SDK**: Asegúrate de tener el SDK de .NET Core instalado en tu máquina.

### Ejecutar la Aplicación

1. **Clonar el Repositorio**:
```bash
git clone https://github.com/tu-usuario/task-manager-app.git
cd task-manager-app
```
2. **Compilar la Solución**: Abre el proyecto en Visual Studio y compila la solución. Esto restaurará los paquetes NuGet necesarios y compilará la aplicación.
3. **Ejecutar la Aplicación**: Presiona F5 en Visual Studio para ejecutar la aplicación. Alternativamente, puedes usar el terminal:
```bash
dotnet run
```
4. **Usar la Aplicación**:
  - Agrega una tarea escribiendo el título de la tarea y haciendo clic en el botón "Agregar Tarea".
  - Edita una tarea seleccionándola de la lista, modificando el título, y haciendo clic en "Editar Tarea".
  - Elimina una tarea seleccionándola y haciendo clic en "Eliminar Tarea".
  - Marca una tarea como completada marcando el checkbox junto a ella.

### Persistencia de Datos

- La aplicación guarda las tareas en un archivo tasks.json ubicado en el mismo directorio que el ejecutable de la aplicación. Esto asegura que las tareas se guarden entre sesiones.

## Licencia

Este proyecto está licenciado bajo la Licencia MIT. Consulta el archivo LICENSE para más detalles.
