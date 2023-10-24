using UnityEngine;
#if INPUT_SYSTEM_ENABLED
using Input = XCharts.Runtime.InputHelper;
#endif
using XCharts.Runtime;

namespace XCharts.Example
{
    [DisallowMultipleComponent]
    [ExecuteInEditMode]
    public class Example13_LineSimple : MonoBehaviour
    {
        void Awake()
        {
            AddData();
        }

        void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                AddData();
            }
        }

        void AddData()
        {
            var chart = gameObject.GetComponent<SimplifiedLineChart>();
            if (chart == null)
            {
                chart = gameObject.AddComponent<SimplifiedLineChart>();
                chart.Init();
                chart.SetSize(580, 300);
            }
            chart.EnsureChartComponent<Title>().show = true;
            chart.EnsureChartComponent<Title>().text = "Line Simple";

            chart.EnsureChartComponent<Tooltip>().show = true;
            chart.EnsureChartComponent<Legend>().show = false;

            var xAxis = chart.EnsureChartComponent<XAxis>();
            var yAxis = chart.EnsureChartComponent<YAxis>();
            xAxis.show = true;
            yAxis.show = true;
            xAxis.type = Axis.AxisType.Value; // Cambiamos de 'Category' a 'Value'
            yAxis.type = Axis.AxisType.Value;

            xAxis.splitNumber = 4; // Reducimos el número de divisiones
            xAxis.boundaryGap = true;

            chart.RemoveData();
            chart.AddSerie<SimplifiedLine>();
            chart.AddSerie<SimplifiedLine>();

            // Agregamos los valores requeridos al eje X y Y
            chart.AddXAxisData("10");
            chart.AddXAxisData("20");
            chart.AddXAxisData("30");
            chart.AddXAxisData("40");
            chart.AddXAxisData("50");

            chart.AddData(0, 0.131);
            chart.AddData(1, 0.131);
            chart.AddData(0, 0.207);
            chart.AddData(1, 0.207);
            chart.AddData(0, 0.261);
            chart.AddData(1, 0.261);
            chart.AddData(0, 0.291);
            chart.AddData(1, 0.291);
            chart.AddData(0, 0.323);
            chart.AddData(1, 0.323);
        }
    }
}
