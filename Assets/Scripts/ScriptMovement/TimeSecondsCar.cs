using System.Collections;
using System.Collections.Generic;
using System.Timers;
using UnityEngine;
using UnityEngine.UI;

public class TimeSecondsCar : MonoBehaviour
{
    [SerializeField] private StartCarTrigger startCarTrigger;
    [SerializeField] private Text TimeString;
    [SerializeField] private TableFiller tableFiller10;
    [SerializeField] private TableFiller tableFiller20;
    [SerializeField] private TableFiller tableFiller30;
    [SerializeField] private WeightTriggerChanger weightTriggerChanger;
    private const string WEIGHT50 = "Weight50G";
    private const string WEIGHT100 = "Weight100G";
    private const string WEIGHT150 = "Weight150G";
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
            PutTime(tiempoFinal);
        }
    }

    private void PutTime(float time)
    {
        if (weightTriggerChanger.GetWeight() == WEIGHT50)
            tableFiller10.SetFloatArray(time);
        if (weightTriggerChanger.GetWeight() == WEIGHT100)
            tableFiller20.SetFloatArray(time);
        if (weightTriggerChanger.GetWeight() == WEIGHT150)
            tableFiller30.SetFloatArray(time);
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
