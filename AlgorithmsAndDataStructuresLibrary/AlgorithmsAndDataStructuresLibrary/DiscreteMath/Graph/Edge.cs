﻿namespace AlgorithmsAndDataStructuresLibrary.DiscreteMath.Graph
{
    public class Edge
    {
        private int m_Value;
        private float m_Weight;

        public Edge(int value, float weight = 1)
        {
            m_Value = value;
            m_Weight = weight;
        }

        public int GetValue()
        {
            return m_Value;
        }

        public void SetValue(int value)
        {
            m_Value = value;
        }

        public float GetWeight()
        {
            return m_Weight;
        }

        public void SetWeight(float weight)
        {
            m_Weight = weight;
        }
    }
}