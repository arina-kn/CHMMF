using System;
using System.Collections.Generic;

namespace course_work_2
{
    public class Decider
    {
        protected double c, k, alpha, L, T, u0;
        protected int I;
        protected int K;

        protected double a;

        protected double ht, hx;

        List<Task> horizontalLayers, verticalLayers;

        protected double[] firstLayer;
        protected double[] secondLayer;

        public virtual void Init(double c, double k, double alpha, double u0, double L, double T, int I, int K)
        {
            this.c = c;
            this.k = k;
            this.alpha = alpha;
            this.L = L;
            this.T = T;
            this.I = I;
            this.K = K;

            hx = L / I;
            ht = T / K;

            a = k * ht / c / hx / hx;

            firstLayer = new double[I + 1];
            secondLayer = new double[I + 1];
            setFirstLayer();
        }
        public void SetCollectors(List<Task> horLayers, List<Task> vertLayers)
        {
            this.horizontalLayers = horLayers;
            this.verticalLayers = vertLayers;
        }

        public List<Task> getHorizontalLayers()
        {
            return horizontalLayers;
        }
        public List<Task> getVerticalLayers()
        {
            return verticalLayers;
        }

        public event Action Finish;
        public event Action<double> Process;

        public void Start()
        {
            int index = 0;
            int numHorColl = 0;

            while(index <= K)
            {
                CollectVertData(index);
                Step();
                if(numHorColl < horizontalLayers.Count && index == horizontalLayers[numHorColl].Index)
                    firstLayer = horizontalLayers[numHorColl++].swapArray(firstLayer);
                swapLayers();
                Process?.Invoke(index * 1.0 / K);
                index++;
            }
            Finish?.Invoke();
        }
        protected void Step()
        {
            for (int i = 1; i < I; i++)
                secondLayer[i] = firstLayer[i] + a * (firstLayer[i + 1] - 2 * firstLayer[i] + firstLayer[i - 1]);
            secondLayer[0] = u0;
            secondLayer[I] = (secondLayer[I - 1] + alpha * hx * u0 / k) / (1 + alpha * hx / k);
        }
        protected void CollectVertData(int index)
        {
            foreach(var x in verticalLayers)
                x.Array[index] = firstLayer[x.Index];
        }
        protected void swapLayers()
        {
            double[] t = firstLayer;
            firstLayer = secondLayer;
            secondLayer = t;
        }
        protected void setFirstLayer()
        {
            for (int i = 0; i <= I; i++) {
                double x = 2 * Math.PI * hx * i / L;
                firstLayer[i] = 5*(1 - Math.Cos(x));
            }
        }
    }
}
