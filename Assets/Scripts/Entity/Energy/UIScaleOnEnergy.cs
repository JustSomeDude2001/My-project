using System;
using UnityEngine;
using UnityEngine.Serialization;

namespace Entity.Energy
{
    public class UIScaleOnEnergy : MonoBehaviour
    {
        public RectTransform uiObject;
        public Energy energy;
        
        private void Update()
        {
            float scale = energy.GetCurrentEnergy() / energy.GetMaxEnergy();
            uiObject.localScale = Vector3.one * scale;
        }
    }
}