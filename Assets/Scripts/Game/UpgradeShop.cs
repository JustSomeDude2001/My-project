using Entity.Player;
using UnityEngine;

namespace Game
{
    public class UpgradeShop : MonoBehaviour
    {
        public PlayerUpgrade upgrade;
        public AudioSource source;
        public AudioClip failSound;
        public AudioClip successSound;
        
        public void TryBuyUpgrade()
        {
            if (GameController.currentGameController.money >= upgrade.cost)
            {
                GameController.currentGameController.money -= upgrade.cost;
                GameController.currentGameController.activeUpgrades.Add(upgrade);
                
                Debug.Log("Bought Upgrade");
                source.Stop();
                source.clip = successSound;
                source.Play();
            }
            else
            {
                Debug.Log("Failed to buy");
                source.Stop();
                source.clip = failSound;
                source.Play();
            }
        }
    }
}