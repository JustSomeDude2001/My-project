using System;
using UnityEngine;
using Random = System.Random;

namespace Entity.Energy
{
    public class EnergyDiesWhileCharging : MonoBehaviour
    {
        private static Random _random;
        
        public EnergyChanger energyChanger;
        public GrantsMoneyOnDestroy moneyDistributor;
        
        public float cooldown = 0.5f;
        public float destructionChance = 0.1f;
        
        private float _lastProc;
        
        
        private void Start()
        {
            _random ??= new Random();
            _lastProc = Time.time;
        }

        private void Update()
        {
            if (energyChanger.chargersCount == 0)
            {
                return;
            }
            if (Time.time - _lastProc > cooldown)
            {
                if (_random.NextDouble() < destructionChance)
                {
                    moneyDistributor.destroyedByPlayer = true;
                    Destroy(gameObject);
                }

                _lastProc = Time.time;
            }
        }
    }
}