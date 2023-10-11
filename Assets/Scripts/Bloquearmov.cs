using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bloquearmov : MonoBehaviour
{
    private Vector3 initialPosition;
    public float speed = 5.0f; // Velocidad de movimiento en el eje X

    void Start()
    {
        initialPosition = transform.position;
    }

    void Update()
    {
        // Calcular el movimiento en el eje Z, utilizando la velocidad definida.
        float moveInput = Input.GetAxis("Vertical");
        float moveX = moveInput * speed * Time.deltaTime;

        // Crear un vector de movimiento solo en el eje Z
        Vector3 move = new Vector3(moveX, 0, 0);

        // Aplicar el movimiento al objeto
        transform.Translate(move);

        // Restringir el movimiento en los ejes X e Y a la posición inicial
        Vector3 currentPosition = transform.position;
        currentPosition.y = initialPosition.y;
        currentPosition.z = initialPosition.z;
        transform.position = currentPosition;
    }
}
