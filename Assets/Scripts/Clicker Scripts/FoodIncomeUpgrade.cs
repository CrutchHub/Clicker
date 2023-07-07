using TMPro;
using UnityEngine;

public class FoodIncomeUpgrade : MonoBehaviour
{
    [SerializeField] PlayerStats playerStats;
    [SerializeField] ClickIncome onClickResourceCount;
    [SerializeField] UpgradesList upgradesList;
    [SerializeField] UpgradeIDAndType upgradeIDAndType;
    [SerializeField] PassiveIncome passiveIncome;
    [SerializeField] public int passiveUpgradesCount = 0;
    [SerializeField] public int clickUpgradesCount = 0;
    [SerializeField] TextMeshProUGUI Price;

    private void Awake()
    {
        clickUpgradesCount = PlayerPrefs.GetInt("foodClickUpgradesCount");
        passiveUpgradesCount = PlayerPrefs.GetInt("foodPassiveUpgradesCount");
        if (upgradeIDAndType.isPassive == false) Price.text = "-" + Mathf.FloorToInt((clickUpgradesCount + 1) * 100).ToString();
        else Price.text = "-" + Mathf.FloorToInt((passiveUpgradesCount + 1) * 100).ToString();
    }

    public void UpgradeFoodIncome()
    {
        if (upgradeIDAndType.isPassive == false)
        {
            if (playerStats.foodCount >= (clickUpgradesCount + 1) * 100)
            {
                playerStats.foodCount -= (clickUpgradesCount + 1) * 100;
                onClickResourceCount.UpgradeFoodOnClick(upgradesList.GetUpgradeValue(upgradeIDAndType.upgradeID, upgradeIDAndType.isPassive));
                clickUpgradesCount++;
                Price.text = "-" + Mathf.FloorToInt((clickUpgradesCount + 1) * 100).ToString();
                PlayerPrefs.SetInt("foodClickUpgradesCount", clickUpgradesCount);
            }
        }
        else
        {
            if (playerStats.foodCount >= (passiveUpgradesCount + 1) * 100)
            {
                playerStats.foodCount -= (passiveUpgradesCount + 1) * 100;
                passiveIncome.UpgradeFoodPassive(upgradesList.GetUpgradeValue(upgradeIDAndType.upgradeID, upgradeIDAndType.isPassive));
                passiveUpgradesCount++;
                Price.text = "-" + Mathf.FloorToInt((passiveUpgradesCount + 1) * 100).ToString();
                PlayerPrefs.SetInt("foodPassiveUpgradesCount", passiveUpgradesCount);
            }
        }    
    }
}


