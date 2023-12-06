using UnityEngine;
using UnityEngine.Serialization;

namespace Entity.Player
{
    [CreateAssetMenu(fileName = "upgradeData", menuName = "ScriptableObjects/PlayerUpgrade")]
    public class PlayerUpgrade : ScriptableObject
    {
        public string upgradeTitle;
        public string description;

        public int cost;
        
        public float movementSpeedOffset;
        public float movementSpeedMult;

        public float maxEnergyOffset;
        public float maxEnergyMult;

        public float deltaEnergyOffset;
        public float deltaEnergyMult;

        public string unlockedSpawn;
    }
}