using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WeightTriggerChanger : MonoBehaviour
{
    private string weightString;
    [SerializeField] private Text WeightText;
    [SerializeField] private string weightPesaUno;
    [SerializeField] private string weightPesaDos;
    [SerializeField] private string weightPesaTres;
    private const string WEIGHT50 = "Weight50G";
    private const string WEIGHT100 = "Weight100G";
    private const string WEIGHT150 = "Weight150G";

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == WEIGHT50)
        {
            weightString = WEIGHT50;
            WeightText.text = $"Peso: {weightPesaUno} Gramos";
            Debug.Log("50 Enter!!");
        }
            

        if (other.gameObject.tag == WEIGHT100)
        {
            weightString = WEIGHT100;
            WeightText.text = $"Peso: {weightPesaDos} Gramos";
            Debug.Log("100 Enter!!");
        }

        if (other.gameObject.tag == WEIGHT150)
        {
            weightString = WEIGHT150;
            WeightText.text = $"Peso: {weightPesaTres} Gramos";
            Debug.Log("150 Enter!!");

        }
    }

    public string GetWeight() => weightString;
}
