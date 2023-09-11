using System;
using UnityEngine;

namespace Entity.Energy
{
    
    public class EnergyChanger : MonoBehaviour
    {
        public float rechargeRate;
        
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