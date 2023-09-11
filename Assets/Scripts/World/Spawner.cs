using System;
using Unity.VisualScripting;
using UnityEngine;
using Random = System.Random;

namespace World
{
    public class Spawner : MonoBehaviour
    {
        public GameObject gameObject;
        [InspectorRange(0, 1)]public float chanceToSpawn;

        private static Random _random;
        
        private void Start()
        {
            _random ??= new Random();

            if (_random.NextDouble() < chanceToSpawn)
            {
                Instantiate(gameObject, transform.position, transform.rotation);
            }
        }
    }
}
