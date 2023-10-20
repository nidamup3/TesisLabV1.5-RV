using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TiimeSecondBall : MonoBehaviour
{
    [SerializeField] private StartBall startCarTrigger;
    [SerializeField] private Text TimeString;
    [SerializeField] private TableFiller tableFiller10;
    [SerializeField] private TableFiller tableFiller20;
    [SerializeField] private TableFiller tableFiller30;
    [SerializeField] private TableFiller tableFiller40;
    [SerializeField] private TableFiller tableFiller50;
    [SerializeField] private CheckWhereCensorIs checkWhereCensorIs10;
    [SerializeField] private CheckWhereCensorIs checkWhereCensorIs20;
    [SerializeField] private CheckWhereCensorIs checkWhereCensorIs30;
    [SerializeField] private CheckWhereCensorIs checkWhereCensorIs40;
    [SerializeField] private CheckWhereCensorIs checkWhereCensorIs50;
    [SerializeField] private Transform censorPosition;
    private const string CARTAG = "Car";
    private bool accionIniciada = false;
    private float tiempoInicio;
    private float tiempoTranscurrido;
    private bool triggerAlcanzado = false;
    private float TiempoFinalGraphic;
    private string DistanciaGrafica;

    void Update()
    {
        IniciarAccion();
        // Verifica si la acci�n ha sido iniciada
        if (accionIniciada && !triggerAlcanzado)
        {
            // Calcula el tiempo transcurrido desde el inicio de la acci�n
            tiempoTranscurrido = Time.time - tiempoInicio;

            // Muestra el tiempo en la consola
            Debug.Log("Tiempo transcurrido: " + tiempoTranscurrido.ToString("F2") + " segundos");
        }
    }

    // M�todo que inicia la acci�n
    public void IniciarAccion()
    {
        if (!startCarTrigger.GetIsStarted())
        {
            accionIniciada = true;
            tiempoInicio = Time.time;
        }
    }

    // M�todo que se llama cuando se alcanza el trigger
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == CARTAG)
        {
            // Registra que el trigger ha sido alcanzado
            triggerAlcanzado = true;

            // Detiene la acci�n y muestra el tiempo final
            float tiempoFinal = Time.time - tiempoInicio;
            Debug.Log("Tiempo total: " + tiempoFinal.ToString("F2") + " segundos");
            TimeString.text = $"Tiempo: {tiempoFinal.ToString("F2")} Segundos";
            TiempoFinalGraphic = tiempoFinal;
            PutTime(tiempoFinal);
        }
    }

    private void PutTime(float time)
    {
        if (checkWhereCensorIs10.GetIsHere())
        {
            DistanciaGrafica = "10";
            tableFiller10.SetFloatArray(time);
        }
        if (checkWhereCensorIs20.GetIsHere())
        {
            DistanciaGrafica = "20";
            tableFiller20.SetFloatArray(time);
        }
        if (checkWhereCensorIs30.GetIsHere())
        {
            DistanciaGrafica = "30";
            tableFiller30.SetFloatArray(time);
        }
        if (checkWhereCensorIs40.GetIsHere())
        {
            DistanciaGrafica = "40";
            tableFiller40.SetFloatArray(time);
        }
        if (checkWhereCensorIs50.GetIsHere())
        {
            DistanciaGrafica = "50";
            tableFiller50.SetFloatArray(time);
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

    public float GetTiempoFinalGraphic() => TiempoFinalGraphic;

    public string GetDistanciaGrafica() => DistanciaGrafica;
}