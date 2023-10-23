using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using XCharts.Runtime;

public class ChartFlecher : MonoBehaviour
{
    [SerializeField] private TimeSecondsCar timeSecondsCar;
    private int yDataPosition;
    private LineChart linechart;

    private void Start()
    {
        linechart = GetComponent<LineChart>();
        linechart.AddXAxisData("x" + (1));
        linechart.AddData(0, Random.Range(10, 100));
        linechart.AddData(1, Random.Range(30, 100));
        linechart.AddData("Test", 2);
    }

    private void ConvertYValues()
    {
        if (timeSecondsCar.GetDistanciaGrafica() == 10)
            yDataPosition = 1;
        if (timeSecondsCar.GetDistanciaGrafica() == 20)
            yDataPosition = 2;
        if (timeSecondsCar.GetDistanciaGrafica() == 30)
            yDataPosition = 3;
        if (timeSecondsCar.GetDistanciaGrafica() == 40)
            yDataPosition = 4;
        if (timeSecondsCar.GetDistanciaGrafica() == 50)
            yDataPosition = 5;
    }

    private void AddChartValuesValues()
    {
        linechart = GetComponent<LineChart>();
        linechart.AddYAxisData("Test", 1);
    }
}
