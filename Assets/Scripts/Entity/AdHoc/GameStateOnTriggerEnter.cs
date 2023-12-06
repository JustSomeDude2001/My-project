using System;
using Game;
using UnityEngine;

namespace Entity
{
    public class GameStateOnTriggerEnter : MonoBehaviour
    {
        public GameState nextState;

        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Player"))
            {
                GameController.currentGameController.nextState = nextState;
            }
        }
    }
}