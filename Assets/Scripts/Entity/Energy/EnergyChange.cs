using System;
using UnityEngine;

namespace Entity.Energy
{
    public class EnergyChange : MonoBehaviour
    {
        public Energy energy;
        public float change;

        private void Update()
        {
            energy.AddEnergy(change * Time.deltaTime);
        }
    }
}