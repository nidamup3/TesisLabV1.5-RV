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
    [SerializeField] private TableFiller tableFiller40;
    [SerializeField] private TableFiller tableFiller50;
    [SerializeField] private WeightTriggerChanger weightTriggerChanger;
    private const string WEIGHT50 = "Weight50G";
    private const string WEIGHT100 = "Weight100G";
    private const string WEIGHT150 = "Weight150G";
    [SerializeField] private Transform censorPosition;
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
        if ((censorPosition.position.z <= -10.7f && censorPosition.position.z >= -10.9f) || censorPosition.position.z == -10.8f)
            tableFiller10.SetFloatArray(time);
        if ((censorPosition.position.z <= -8.5f && censorPosition.position.z >= 8.7f) || censorPosition.position.z == -8.6f)
            tableFiller20.SetFloatArray(time);
        if ((censorPosition.position.z <= -6.3f && censorPosition.position.z >= -10.5f) || censorPosition.position.z == -6.4f)
            tableFiller30.SetFloatArray(time);
        if ((censorPosition.position.z <= -4.1f && censorPosition.position.z >= -4.3f) || censorPosition.position.z == -4.2f)
            tableFiller40.SetFloatArray(time);
        if ((censorPosition.position.z <= -1.9f && censorPosition.position.z >= -2.1f) || censorPosition.position.z == -2.0f)
            tableFiller50.SetFloatArray(time);
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
