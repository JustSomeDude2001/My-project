using Entity.Player;
using TMPro;
using UnityEngine;

namespace Entity
{
    public class DisplaysUpgradeCost : MonoBehaviour
    {
        public TextMeshProUGUI textMeshPro;
        public PlayerUpgrade upgrade;
        
        private void Update()
        {
            textMeshPro.SetText(upgrade.cost.ToString());
        }
    }
}