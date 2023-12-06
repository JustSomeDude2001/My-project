using System;
using Game;
using UnityEngine;

namespace Entity
{
    public class SpawnOnDestroy : MonoBehaviour
    {
        public GameObject newObject;
        public GameState allowedGameState;
        
        private void OnDestroy()
        {
            if(!gameObject.scene.isLoaded) return;
            if (GameController.currentGameController.currentState != allowedGameState) return;
            Instantiate(newObject, transform.position, Quaternion.identity);
        }
    }
}