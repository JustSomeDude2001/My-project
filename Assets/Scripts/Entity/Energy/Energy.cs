using System;
using UnityEngine;

namespace Entity.Energy
{
    public class Energy : MonoBehaviour
    {
        [SerializeField] private float maxEnergy = 100;
        [SerializeField] private float currentEnergy = 100;

        public bool logEnergy = false;

        private void Update()
        {
            if (logEnergy)
            {
                Debug.Log(transform + " current energy: " + currentEnergy);
            }
        }

        public void AddEnergy(float deltaEnergy)
        {
            if (currentEnergy + deltaEnergy > maxEnergy)
            {
                currentEnergy = maxEnergy;
            } else if (currentEnergy + deltaEnergy < 0)
            {
                currentEnergy = 0;
            }
            else
            {
                currentEnergy += deltaEnergy;
            }
        }

        public float GetCurrentEnergy()
        {
            return currentEnergy;
        }

        public float GetMaxEnergy()
        {
            return maxEnergy;
        }
    }
}
