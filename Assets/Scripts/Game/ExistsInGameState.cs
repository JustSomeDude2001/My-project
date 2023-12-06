using System;
using UnityEngine;

namespace Game
{
    public class ExistsInGameState : MonoBehaviour
    {
        public GameState allowedState;

        private void Update()
        {
            if (GameController.currentGameController && 
                GameController.currentGameController.currentState != allowedState)
            {
                Destroy(gameObject);
            }
        }
    }
}