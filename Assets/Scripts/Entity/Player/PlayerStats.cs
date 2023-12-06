using Entity.Energy;
using UnityEngine;

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

        public void ResetStats()
        {
            _movementSpeed = 0;
            _movementSpeedMult = 1;

            _maxEnergy = 0;
            _maxEnergyMult = 1;

            _deltaEnergy = 0;
            _deltaEnergyMult = 1;
        }
        
        public void ApplyUpgrade(PlayerUpgrade upgrade)
        {
            _movementSpeed += upgrade.movementSpeedOffset;
            _movementSpeedMult += upgrade.movementSpeedMult;

            _maxEnergy += upgrade.maxEnergyOffset;
            _maxEnergyMult += upgrade.maxEnergyMult;

            _deltaEnergy += upgrade.deltaEnergyOffset;
            _deltaEnergyMult += upgrade.deltaEnergyMult;
        }

        public void ApplyStats()
        {
            movement.SetMaxVelocity(_movementSpeed * _movementSpeedMult);
            
            energy.SetMaxEnergy(_maxEnergy * _maxEnergyMult);
            energy.SetCurrentEnergy(_maxEnergy * _maxEnergyMult);
            
            energyChange.SetDeltaEnergy(_deltaEnergy * _deltaEnergyMult);
        }
    }
}