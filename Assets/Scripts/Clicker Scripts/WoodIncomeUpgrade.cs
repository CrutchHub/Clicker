using TMPro;
using UnityEngine;

public class WoodIncomeUpgrade : MonoBehaviour
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
        clickUpgradesCount = PlayerPrefs.GetInt("woodClickUpgradesCount");
        passiveUpgradesCount = PlayerPrefs.GetInt("woodPassiveUpgradesCount");
        if (upgradeIDAndType.isPassive == false) Price.text = "-" + Mathf.FloorToInt((clickUpgradesCount + 1) * 100).ToString();
        else Price.text = "-" + Mathf.FloorToInt((passiveUpgradesCount + 1) * 100).ToString();
    }
    public void UpgradeWoodIncome()
    {
        if (upgradeIDAndType.isPassive == false)
        {
            if (playerStats.woodCount >= (clickUpgradesCount + 1) * 100)
            {
                playerStats.woodCount -= (clickUpgradesCount + 1) * 100;
                onClickResourceCount.UpgradeWoodOnClick(upgradesList.GetUpgradeValue(upgradeIDAndType.upgradeID, upgradeIDAndType.isPassive));
                clickUpgradesCount++;
                Price.text = "-" + Mathf.FloorToInt((clickUpgradesCount + 1) * 100).ToString();
                PlayerPrefs.SetInt("woodClickUpgradesCount", clickUpgradesCount);
            }
        }
        else
        {
            if (playerStats.woodCount >= (passiveUpgradesCount + 1) * 100)
            {
                playerStats.woodCount -= (passiveUpgradesCount + 1) * 100;
                passiveIncome.UpgradeWoodPassive(upgradesList.GetUpgradeValue(upgradeIDAndType.upgradeID, upgradeIDAndType.isPassive));
                passiveUpgradesCount++;
                Price.text = "-" + Mathf.FloorToInt((passiveUpgradesCount + 1) * 100).ToString();
                PlayerPrefs.SetInt("woodPassiveUpgradesCount", passiveUpgradesCount);
            }
        }
    }
}
