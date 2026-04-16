# Proyecto Unity 2D con Firebase Cloud Firestore

## Descripción

Este proyecto consiste en un videojuego desarrollado en Unity 2D con conexión a Firebase Cloud Firestore para guardar el progreso del jugador en la nube.

El sistema permite almacenar:

- Total de monedas recolectadas.
- Progreso completado del Nivel 1.
- Progreso completado del Nivel 2.

---

## Tecnologías utilizadas

- Unity 2D
- C#
- Firebase
- Cloud Firestore

---

## Funcionalidades

### Sistema de monedas
El jugador puede recolectar monedas durante los niveles.

### Guardado automático
Al completar cada nivel se guarda automáticamente:

- Cantidad de monedas obtenidas.
- Estado del Nivel 1.
- Estado del Nivel 2.

### Carga de datos
Al iniciar el juego se pueden recuperar los datos almacenados desde Firebase.

---

## Estructura del proyecto
Configuración de Firebase
Crear proyecto en Firebase Console.
Activar Cloud Firestore.
Descargar archivo:
Para Android:

google-services.json

Para Windows/Web:

google-services-desktop.json

Importar Firebase SDK en Unity.
```bash
Assets/
├── Scripts/
│   ├── FirebaseManager.cs
│   ├── GameManager.cs
│   ├── Moneda.cs
│   ├── FinalNivel1.cs
│   └── FinalNivel2.cs


Base de datos utilizada

Colección:

jugadores

Documento:

jugador1

Campos:

{
  "monedas": 20,
  "nivel1Completado": true,
  "nivel2Completado": false
}
Cómo ejecutar
Abrir proyecto en Unity Hub.
Verificar conexión Firebase.
Ejecutar escena principal.
Recolectar monedas.
Completar niveles.
Autor

Brayan Salas
