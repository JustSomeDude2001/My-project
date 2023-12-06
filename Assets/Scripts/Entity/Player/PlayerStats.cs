using System;
using Entity.Energy;
using Game;
using UnityEngine;
using World;

namespace Entity.Player
{
    public class PlayerStats : MonoBehaviour
    {
        private float _movementSpeed;
        private float _movementSpeedMult;
        
        private float _maxEnergy;
        private float _maxEnergyMult;
        
        private float _deltaEnergy;
        private float _deltaEnergyMult;
        
        public Energy.Energy energy;
        public Movement movement;
        public EnergyChange energyChange;

        private void Start()
        {
            ResetStats();
            for (int i = 0; i < GameController.currentGameController.activeUpgrades.Count; i++)
            {
                ApplyUpgrade(GameController.currentGameController.activeUpgrades[i]);
            }
            ApplyStats();
        }

        private void ResetStats()
        {
            _movementSpeed = 0;
            _movementSpeedMult = 1;

            _maxEnergy = 0;
            _maxEnergyMult = 1;

            _deltaEnergy = 0;
            _deltaEnergyMult = 1;
        }
        
        private void ApplyUpgrade(PlayerUpgrade upgrade)
        {
            _movementSpeed += upgrade.movementSpeedOffset;
            _movementSpeedMult += upgrade.movementSpeedMult;

            _maxEnergy += upgrade.maxEnergyOffset;
            _maxEnergyMult += upgrade.maxEnergyMult;

            _deltaEnergy += upgrade.deltaEnergyOffset;
            _deltaEnergyMult += upgrade.deltaEnergyMult;

            if (upgrade.unlockedSpawn != "")
            {
                UpgradeBoundSpawner.isAllowed[upgrade.unlockedSpawn] = true;
            }
        }

        private void ApplyStats()
        {
            movement.SetMaxVelocity(_movementSpeed * _movementSpeedMult);
            
            energy.SetMaxEnergy(_maxEnergy * _maxEnergyMult);
            energy.SetCurrentEnergy(_maxEnergy * _maxEnergyMult);
            
            energyChange.SetDeltaEnergy(_deltaEnergy * _deltaEnergyMult);
        }
    }
}