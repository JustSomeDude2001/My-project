using System;
using Game;
using TMPro;
using UnityEngine;

namespace Entity
{
    public class DisplaysMoney : MonoBehaviour
    {
        public TextMeshProUGUI textMeshPro;

        private void Update()
        {
            textMeshPro.SetText(GameController.currentGameController.money.ToString());
        }
    }
}