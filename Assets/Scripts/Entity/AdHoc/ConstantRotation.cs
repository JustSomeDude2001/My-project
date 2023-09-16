using System;
using UnityEngine;

namespace Entity
{
    public class ConstantRotation : MonoBehaviour
    {
        public Vector3 rotationRate;
        
        private void Update()
        {
            var deltaRotation = rotationRate * Time.deltaTime;
            transform.Rotate(deltaRotation.x, deltaRotation.y, deltaRotation.z);
        }
    }
}