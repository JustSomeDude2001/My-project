using System;
using UnityEngine;

namespace Entity
{
    public class FadingLight : MonoBehaviour
    {
        public Light light;
        public float fadingRate = 1;

        private void Update()
        {
            if (light.intensity > 0)
            {
                light.intensity -= fadingRate * Time.deltaTime;
            }
        }
    }
}