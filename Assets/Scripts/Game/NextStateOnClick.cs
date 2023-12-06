using UnityEngine;

namespace Game
{
    public class NextStateOnClick : MonoBehaviour
    {
        public GameState nextState;

        public void Click()
        {
            GameController.currentGameController.nextState = nextState;
        }
    }
}