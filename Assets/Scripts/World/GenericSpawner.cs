using System;
using Unity.VisualScripting;
using UnityEngine;
using Random = System.Random;

namespace World
{
    public abstract class GenericSpawner : MonoBehaviour
    {
        public GameObject gameObject;
        public bool isChunkBound = true;
        
        protected static Random _random = new Random();
    }
}
