using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    // Rigidbody del jugador.
    private Rigidbody rb; 

    // Movimiento a lo largo de los ejes X e Y.
    private float movementX;
    private float movementY;

    // Velocidad a la que se mueve el jugador.
    public float speed = 0; 

    // Start se llama antes de la primera actualización del frame.
    void Start()
    {
        // Obtiene y almacena el componente Rigidbody adjunto al jugador.
        rb = GetComponent<Rigidbody>();
    }
 
    // Esta función se llama cuando se detecta una entrada de movimiento.
    void OnMove(InputValue movementValue)
    {
        // Convierte el valor de entrada en un Vector2 para el movimiento.
        Vector2 movementVector = movementValue.Get<Vector2>();

        // Almacena los componentes X e Y del movimiento.
        movementX = movementVector.x; 
        movementY = movementVector.y; 
    }

    // FixedUpdate se llama una vez por frame de tasa fija.
    private void FixedUpdate() 
    {
        // Crea un vector de movimiento en 3D utilizando las entradas X e Y.
        Vector3 movement = new Vector3(movementX, 0.0f, movementY);

        // Aplica una fuerza al Rigidbody para mover al jugador.
        rb.AddForce(movement * speed); 
    }

    // Se llama cuando el jugador entra en contacto con otro Collider.
    void OnTriggerEnter(Collider other)
    {
        // Si el objeto en contacto tiene la etiqueta "PickUp".
        if (other.gameObject.CompareTag("PickUp"))
        {
            // Desactiva el objeto al que se ha hecho contacto.
            other.gameObject.SetActive(false);
        }
    }
}
