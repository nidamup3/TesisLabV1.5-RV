using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using XCharts.Runtime;

public class ChartFlecher : MonoBehaviour
{
    [SerializeField] private TimeSecondsCar timeSeconds;
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



    private void AddChartValuesValues()
    {
        linechart = GetComponent<LineChart>();
        linechart.AddYAxisData("Test", 1);
    }
}