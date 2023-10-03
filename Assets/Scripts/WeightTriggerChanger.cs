using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeightTriggerChanger : MonoBehaviour
{
    private string weightString;
    private const string WEIGHT50 = "Weight50";
    private const string WEIGHT100 = "Weight100";
    private const string WEIGHT150 = "Weight150";

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == WEIGHT50)
            weightString = WEIGHT50;
        if (other.gameObject.tag == WEIGHT100)
            weightString = WEIGHT100;
        if (other.gameObject.tag == WEIGHT150)
            weightString = WEIGHT150;
    }

    public string GetWeight() => weightString;
}
