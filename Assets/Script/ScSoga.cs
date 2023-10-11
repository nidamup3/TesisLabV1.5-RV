using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BloquearMovimiento : MonoBehaviour
{
    // Velocidad de movimiento en el eje X
    public float velocidadMovimiento = 5f;

    void Update()
    {
        // Obtener la posición actual del objeto
        Vector3 posicionActual = transform.position;

        // Bloquear el movimiento en los ejes Y y Z
        posicionActual.y = 0f;
        posicionActual.z = 0f;

        // Mover el objeto solo en el eje X
        float movimientoX = Input.GetAxis("Horizontal");
        posicionActual.x += movimientoX * velocidadMovimiento * Time.deltaTime;

        // Aplicar la nueva posición al objeto
        transform.position = posicionActual;
    }
}

