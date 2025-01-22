# Proyecto Roll a Ball en Unity

Este proyecto es una implementación del clásico juego "Roll a Ball" en Unity, donde el jugador controla una bola que debe recoger objetos distribuidos en un entorno 3D. Los tres scripts proporcionados gestionan la cámara, el movimiento del jugador y la rotación de los objetos recogibles.

## Scripts incluidos

### 1. `CameraController.cs`

Este script maneja el comportamiento de la cámara en el juego, permitiendo alternar entre vista en primera y tercera persona.

#### Funcionalidades:
- **Vista en tercera persona:** La cámara sigue al jugador desde una distancia fija.
- **Vista en primera persona:** La cámara se posiciona sobre el jugador y permite rotar con el ratón.
- **Alternancia entre vistas:** Se puede cambiar entre las dos vistas presionando la tecla `F`.
- **Movimiento del jugador:** En la vista de primera persona, la cámara sigue el movimiento del jugador.

#### Variables importantes:
- `public GameObject player`: Referencia al GameObject del jugador.
- `public float firstPersonHeight`: Ajuste de la altura de la cámara en primera persona.
- `public float mouseSensitivity`: Sensibilidad del ratón para la rotación en primera persona.
- `public float movementSpeed`: Velocidad de movimiento del jugador.

#### Método clave:
- `HandleFirstPersonMovement()`: Controla el movimiento del jugador en vista de primera persona.

---

### 2. `PlayerController.cs`

Este script maneja el movimiento del jugador en un espacio 3D utilizando el sistema de entrada de Unity (`InputSystem`).

#### Funcionalidades:
- **Movimiento del jugador:** Permite mover al jugador a lo largo de los ejes X y Y.
- **Recogida de objetos:** Desactiva los objetos con la etiqueta `PickUp` al entrar en contacto con ellos.

#### Variables importantes:
- `public float speed`: Velocidad a la que se mueve el jugador.
- `private Rigidbody rb`: Componente `Rigidbody` del jugador para aplicar la física de movimiento.

#### Método clave:
- `OnMove(InputValue movementValue)`: Obtiene la entrada de movimiento del jugador.
- `OnTriggerEnter(Collider other)`: Detecta la colisión con objetos etiquetados como `PickUp`.

---

### 3. `Rotator.cs`

Este script rota los objetos con la etiqueta `PickUp` para hacerlos más atractivos o dinámicos en el juego.

#### Funcionalidades:
- **Rotación constante:** Los objetos etiquetados como `PickUp` rotan continuamente en los ejes X, Y y Z.

#### Método clave:
- `Update()`: Aplica una rotación continua sobre el objeto usando `transform.Rotate()`.

---

## Requisitos

- **Unity 2020.3 o superior**.
- **Sistema de entrada de Unity (InputSystem)** para el manejo de controles de movimiento en `PlayerController.cs`.

## Cómo usar

1. **Cámara y Jugador:**
   - Asocia el script `CameraController` al objeto de la cámara principal.
   - En el Inspector de Unity, asigna el `GameObject` del jugador al campo `player` en el script `CameraController`.

2. **Movimiento del jugador:**
   - Asocia el script `PlayerController` al objeto del jugador.
   - Asegúrate de que el jugador tenga un `Rigidbody` adjunto para aplicar la física.

3. **Rotación de objetos:**
   - Asocia el script `Rotator` a los objetos que deseas que roten (por ejemplo, las esferas recogibles).
   - Etiqueta esos objetos como `PickUp` en el Inspector para que el `Rotator` los identifique y les aplique la rotación.

---

¡Listo! Ahora tienes un README actualizado para tu juego "Roll a Ball". Si necesitas más detalles o ajustes, solo dímelo. 😊
