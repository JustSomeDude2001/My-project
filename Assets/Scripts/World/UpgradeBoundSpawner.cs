using System.Collections.Generic;
using System.Linq;
using Unity.VisualScripting;

namespace World
{
    public class UpgradeBoundSpawner : GenericSpawner
    {
        [InspectorRange(0, 1)]public float chanceToSpawn;
        public static Dictionary<string, bool> isAllowed = new Dictionary<string, bool>();
        public string upgradeName = "";
        
        private void Start()
        {
            if (!isAllowed.Keys.Contains(upgradeName) || !isAllowed[upgradeName])
            {
                return;
            }
            if (_random.NextDouble() < chanceToSpawn)
            {
                var newObject = Instantiate(gameObject, transform.position, transform.rotation);
                if (isChunkBound)
                {
                    newObject.transform.SetParent(transform);
                }
            }
        }
    }
}