using System.Collections;
using UnityEngine;
using XCharts.Runtime;

namespace XCharts.Example
{
    [DisallowMultipleComponent]
    public class Example10_LineChart : MonoBehaviour
    {
        private LineChart chart;
        private Serie serie;
        private int m_DataNum = 8;

        private void Start()
        {
            CreateSimpleLineChart();
        }

        private void CreateSimpleLineChart()
        {
            chart = gameObject.GetComponent<LineChart>();
            if (chart == null) chart = gameObject.AddComponent<LineChart>();
            chart.GetChartComponent<Title>().text = "Carril de Fletcher";

            chart.RemoveData();
            serie = chart.AddSerie<Line>("Line");

            for (int i = 0; i < m_DataNum; i++)
            {
                chart.AddXAxisData("x" + (i + 1));
                chart.AddData(0, Random.Range(30, 90));
            }
        }
    }
}