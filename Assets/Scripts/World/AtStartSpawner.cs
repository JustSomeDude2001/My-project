using System;
using Unity.VisualScripting;
using UnityEngine;
using Random = System.Random;

namespace World
{
    public class AtStartSpawner : GenericSpawner
    {
        [InspectorRange(0, 1)]public float chanceToSpawn;

        private void Start()
        {
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