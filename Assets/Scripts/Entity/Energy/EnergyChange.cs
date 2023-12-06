using System;
using UnityEngine;
using UnityEngine.Serialization;

namespace Entity.Energy
{
    public class EnergyChange : MonoBehaviour
    {
        public Energy energy;
        [FormerlySerializedAs("change")] [SerializeField] private float deltaEnergy;

        private void Update()
        {
            energy.AddEnergy(deltaEnergy * Time.deltaTime);
        }

        public float GetDeltaEnergy()
        {
            return deltaEnergy;
        }

        public void SetDeltaEnergy(float newDeltaEnergy)
        {
            deltaEnergy = newDeltaEnergy;
        }
    }
}