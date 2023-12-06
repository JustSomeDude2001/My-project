using System;
using Game;
using UnityEngine;

namespace Entity
{
    public class GrantsMoneyOnDestroy : MonoBehaviour
    {
        public int value = 1;
        public bool destroyedByPlayer = false;

        private void OnDestroy()
        {
            if (destroyedByPlayer)
                GameController.currentGameController.money += value;
        }
    }
}