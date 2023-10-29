using System.Collections;
using UnityEngine;
using XCharts.Runtime;

namespace XCharts.Example
{
    [DisallowMultipleComponent]
    public class CarrildeFletcher : MonoBehaviour
    {
        private LineChart chart;
        private Serie serie;
        private int m_DataNum = 5;
        public float[] myFloatArrayX = new float[5];
        public float[] myFloatArrayY = new float[5];
        private void OnEnable()
        {
            StartCoroutine(PieDemo());
        }

        IEnumerator PieDemo()
        {
            while (true)
            {
                StartCoroutine(AddSimpleLine());
                yield return new WaitForSeconds(2);

            }
        }

        IEnumerator AddSimpleLine()
        {
            chart = gameObject.GetComponent<LineChart>();
            if (chart == null) chart = gameObject.AddComponent<LineChart>();
            chart.GetChartComponent<Title>().text = "Carril de Fletcher";
            chart.GetChartComponent<Title>().subText = "Datos";

            var yAxis = chart.GetChartComponent<YAxis>();
            yAxis.minMaxType = Axis.AxisMinMaxType.Custom;
            yAxis.min = 0;
            yAxis.max = 100;

            chart.RemoveData();
            serie = chart.AddSerie<Line>("Line");

            //for (int i = 0; i < m_DataNum; i++)
            //{
            //    chart.AddXAxisData("x" + (i + 1));
            //    chart.AddData(0, UnityEngine.Random.Range(30, 90));
            //}
            myFloatArrayX[0] = 0.136f;
            myFloatArrayX[1] = 0.207f;
            myFloatArrayX[2] = 0.261f;
            myFloatArrayX[3] = 0.288f;
            myFloatArrayX[4] = 0.327f;

            myFloatArrayY[0] = 10f;
            myFloatArrayY[1] = 20f;
            myFloatArrayY[2] = 30f;
            myFloatArrayY[3] = 40f;
            myFloatArrayY[4] = 50f;

            Debug.Log(myFloatArrayX.Length);
            for (int i = 0; i < myFloatArrayX.Length; i++)


            {
                chart.AddXAxisData( (i + 1) + "seg");
                Debug.Log(myFloatArrayX[i]);
                chart.AddData(0, myFloatArrayY[i]);
                Debug.Log(myFloatArrayY[i]);

            }
            yield return new WaitForSeconds(1);
        }




    }

}
