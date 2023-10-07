using System.Collections;
using System.Collections.Generic;
using System.Timers;
using UnityEngine;
using UnityEngine.UI;

public class TimeSecondsCar : MonoBehaviour
{
    [SerializeField] private StartCarTrigger startCarTrigger;
    [SerializeField] private Text TimeString;
    private const string CARTAG = "Car";
    private bool accionIniciada = false;
    private float tiempoInicio;
    private float tiempoTranscurrido;
    private bool triggerAlcanzado = false;

    void Update()
    {
        IniciarAccion();
        // Verifica si la acción ha sido iniciada
        if (accionIniciada && !triggerAlcanzado)
        {
            // Calcula el tiempo transcurrido desde el inicio de la acción
            tiempoTranscurrido = Time.time - tiempoInicio;

            // Muestra el tiempo en la consola
            Debug.Log("Tiempo transcurrido: " + tiempoTranscurrido.ToString("F2") + " segundos");
        }
    }

    // Método que inicia la acción
    public void IniciarAccion()
    {
        if (!startCarTrigger.GetIsEnterStartCollider())
        {
            accionIniciada = true;
            tiempoInicio = Time.time;
        }
    }

    // Método que se llama cuando se alcanza el trigger
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == CARTAG)
        {
            // Registra que el trigger ha sido alcanzado
            triggerAlcanzado = true;

            // Detiene la acción y muestra el tiempo final
            float tiempoFinal = Time.time - tiempoInicio;
            Debug.Log("Tiempo total: " + tiempoFinal.ToString("F2") + " segundos");
            TimeString.text = $"Tiempo: {tiempoFinal.ToString("F2")} Segundos";
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == CARTAG)
        {
            accionIniciada = false;
            triggerAlcanzado = false;
        }
    }
}
