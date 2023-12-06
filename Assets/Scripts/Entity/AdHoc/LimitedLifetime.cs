using System;
using UnityEngine;

namespace Entity
{
    public class LimitedLifetime : MonoBehaviour
    {
        public float remainingTime = 1;

        private void Update()
        {
            remainingTime -= Time.deltaTime;
            if (remainingTime < 0)
            {
                Destroy(gameObject);
            }
        }
    }
}