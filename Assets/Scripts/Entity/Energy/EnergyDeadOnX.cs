using System;
using Game;
using UnityEngine;

namespace Entity.Energy
{
    public class EnergyDeadOnX : MonoBehaviour
    {
        public Energy energy;
        public float deathThreshold = 0.1f;

        private void Update()
        {
            if (energy.GetCurrentEnergy() < deathThreshold)
            {
                GameController.currentGameController.nextState = GameState.Dead;
            }
        }
    }
}