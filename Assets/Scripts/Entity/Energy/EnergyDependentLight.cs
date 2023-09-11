using System;
using UnityEngine;

namespace Entity.Energy
{
    public class EnergyDependentLight : MonoBehaviour
    {
        public Light light;
        public Energy energy;

        public float maxIntensity = 0.8f;
        
        private void Update()
        {
            light.intensity = maxIntensity * (energy.GetCurrentEnergy() / energy.GetMaxEnergy());
        }
    }
}