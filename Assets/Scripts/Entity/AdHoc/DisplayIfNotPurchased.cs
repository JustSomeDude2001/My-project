using System;
using Entity.Player;
using Game;
using UnityEngine;
using UnityEngine.UI;

namespace Entity
{
    public class DisplayIfNotPurchased : MonoBehaviour
    {
        public Sprite purchasedImage;
        public Image image;
        public PlayerUpgrade upgrade;
        
        private void Update()
        {
            if (!upgrade.repeatable && 
                GameController.currentGameController.upgradeTitles.Contains(upgrade.upgradeTitle))
            {
                image.sprite = purchasedImage;
            }
            
        }
    }
}