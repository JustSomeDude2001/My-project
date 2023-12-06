using System;
using UnityEngine;

namespace Entity
{
    public class SpawnOnDestroy : MonoBehaviour
    {
        public GameObject newObject;

        private void OnDestroy()
        {
            if(!gameObject.scene.isLoaded) return;
            Instantiate(newObject, transform.position, Quaternion.identity);
        }
    }
}