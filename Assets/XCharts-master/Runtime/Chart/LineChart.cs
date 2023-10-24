using System;
using UnityEngine;

namespace XCharts.Runtime
{
    [AddComponentMenu("XCharts/LineChart", 13)]
    [ExecuteInEditMode]
    [RequireComponent(typeof(RectTransform))]
    [DisallowMultipleComponent]
    [HelpURL("https://xcharts-team.github.io/docs/configuration")]
    public class LineChart : BaseChart
    {
        public object yAxis;

        protected override void DefaultChart()
        {
            EnsureChartComponent<GridCoord>();
            EnsureChartComponent<XAxis>();
            EnsureChartComponent<YAxis>();

            RemoveData();
            Line.AddDefaultSerie(this, GenerateDefaultSerieName());
            for (int i = 0; i < 5; i++)
            {
                AddXAxisData("x" + (i + 1));
            }
        }

        public void AddSerie(object line)
        {
            throw new NotImplementedException();
        }

        public void AddData(float v1, float v2)
        {
            throw new NotImplementedException();
        }
    }
}