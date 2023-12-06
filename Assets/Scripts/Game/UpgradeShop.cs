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
            if (GameController.currentGameController.money < upgrade.cost || (!upgrade.repeatable && GameController.currentGameController.upgradeTitles.Contains(upgrade.upgradeTitle)))
            {
                Debug.Log("Failed to buy");
                source.Stop();
                source.clip = failSound;
                source.Play();
            } else {
                GameController.currentGameController.money -= upgrade.cost;
                GameController.currentGameController.activeUpgrades.Add(upgrade);
                if (!GameController.currentGameController.upgradeTitles.Contains(upgrade.upgradeTitle))
                {
                    GameController.currentGameController.upgradeTitles.Add(upgrade.upgradeTitle);
                }
                
                Debug.Log("Bought Upgrade");
                source.Stop();
                source.clip = successSound;
                source.Play();
            }
        }
    }
}