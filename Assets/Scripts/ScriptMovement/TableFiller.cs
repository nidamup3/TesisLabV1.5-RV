using JetBrains.Annotations;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class TableFiller : MonoBehaviour
{
    //[SerializeField] private WeightTriggerChanger weightTrigger;
    [SerializeField] private Text[] dataFillColumn;
    private float[] floatValuesToPut = new float[5];
    int i = 0;

    public void SetFloatArray(float value)
    {
        int filesInt = 5;        
        
        if (i < filesInt)
        {
            floatValuesToPut[i] = value;
            dataFillColumn[i].text = value.ToString("F3");            
            Debug.Log($"Data To Fill {dataFillColumn[i].text} {floatValuesToPut[i]}");
            i++;
        }

        if (i >= filesInt)
        {
            dataFillColumn[5].text = floatValuesToPut.Average().ToString("F3");
        }
    }

    internal void SetFloatArray(float time, float min, float max)
    {
        throw new NotImplementedException();
    }
}
