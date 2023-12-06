using System;
using System.Collections.Generic;
using Entity.Player;
using UnityEngine;

namespace Game
{
    public class GameController : MonoBehaviour
    {
        public static GameController currentGameController;
        
        public int money;
        public List<PlayerUpgrade> activeUpgrades;

        public GameState currentState = GameState.NewGame;
        public GameState nextState = GameState.Ongoing;

        public float gameStartTime;

        public GameObject gameInstance;
        public GameObject shopInstance;
        
        private void Start()
        {
            if (currentGameController == null)
            {
                currentGameController = this;
            }
        }

        private void Update()
        {
            if (currentState != nextState)
            {
                switch (nextState)
                {
                    case GameState.Ongoing:
                        Debug.Log("New game...");
                        Instantiate(gameInstance, Vector3.zero, Quaternion.identity);
                        break;
                    case GameState.Dead:
                        Debug.Log("Died. Loading shop");
                        Instantiate(shopInstance, Vector3.zero, Quaternion.identity);
                        break;
                    default:
                        break;
                }

                currentState = nextState;
            }
        }
    }
}