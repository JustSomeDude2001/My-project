using System;
using Unity.VisualScripting;
using UnityEngine;

namespace Entity
{
    public class FadesIn : MonoBehaviour
    {
        public CanvasGroup canvas;

        public float rate = 0.5f;
        
        private void Start()
        {
            canvas.alpha = 0;
        }

        private void Update()
        {
            canvas.alpha += rate * Time.deltaTime;
            if (canvas.alpha > 1f)
            {
                canvas.alpha = 1f;
                this.enabled = false;
            }
        }
    }
}