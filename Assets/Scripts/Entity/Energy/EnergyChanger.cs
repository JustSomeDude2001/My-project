using System;
using UnityEngine;

namespace Entity.Energy
{
    
    public class EnergyChanger : MonoBehaviour
    {
        public float rechargeRate;
        public int chargersCount = 0;

        private void OnTriggerEnter(Collider other)
        {
            if (other.GetComponent<Energy>())
            {
                chargersCount++;
            }
        }

        private void OnTriggerExit(Collider other)
        {
            if (other.GetComponent<Energy>())
            {
                chargersCount--;
            }
        }

        private void OnTriggerStay(Collider other)
        {
            Energy energy = other.GetComponent<Energy>();
            
            if (energy == null)
            {
                return;
            }
            
            energy.AddEnergy(rechargeRate * Time.fixedDeltaTime);
        }
    }
}