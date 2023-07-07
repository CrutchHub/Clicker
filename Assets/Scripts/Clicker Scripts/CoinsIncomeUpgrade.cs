
using TMPro;
using UnityEngine;

public class CoinsIncomeUpgrade : MonoBehaviour
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
        clickUpgradesCount = PlayerPrefs.GetInt("coinsClickUpgradesCount");
        passiveUpgradesCount = PlayerPrefs.GetInt("coinsPassiveUpgradesCount");
        if (upgradeIDAndType.isPassive == false) Price.text = "-" + Mathf.FloorToInt((clickUpgradesCount + 1) * 100).ToString();
        else Price.text = "-" + Mathf.FloorToInt((passiveUpgradesCount + 1) * 100).ToString();
    }

    public void UpgradeCoinsIncome()
    {
        if (upgradeIDAndType.isPassive == false)
        {
            if (playerStats.coinsCount >= (clickUpgradesCount + 1) * 100)
            {
                playerStats.coinsCount -= (clickUpgradesCount + 1) * 100;
                onClickResourceCount.UpgradeCoinsOnClick(upgradesList.GetUpgradeValue(upgradeIDAndType.upgradeID, upgradeIDAndType.isPassive));
                clickUpgradesCount++;
                Price.text = "-" + Mathf.FloorToInt((clickUpgradesCount + 1) * 100).ToString();
                PlayerPrefs.SetInt("coinsClickUpgradesCount", clickUpgradesCount);
            }
        }
        else
        {
            if (playerStats.coinsCount >= (passiveUpgradesCount + 1) * 100)
            {
                playerStats.coinsCount -= (passiveUpgradesCount + 1) * 100;
                passiveIncome.UpgradeCoinsPassive(upgradesList.GetUpgradeValue(upgradeIDAndType.upgradeID, upgradeIDAndType.isPassive));
                passiveUpgradesCount++;
                Price.text = "-" + Mathf.FloorToInt((passiveUpgradesCount + 1) * 100).ToString();
                PlayerPrefs.SetInt("coinsPassiveUpgradesCount", passiveUpgradesCount);
            }
        }
    }
}
