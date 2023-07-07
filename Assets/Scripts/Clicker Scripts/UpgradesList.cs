using System.Collections.Generic;
using UnityEngine;

public class UpgradesList : MonoBehaviour
{
    [SerializeField] ClickIncome onClickResourceCount;
    [SerializeField] PassiveIncome passiveIncome;

    List<float> clickUpgrades = new List<float>();
    List<float> passiveUpgrades = new List<float>();

    public void Start()
    {
        clickUpgrades.Add(1);
        passiveUpgrades.Add(0.5f);
    }

    public float GetUpgradeValue(int upgradeID, bool isPassive)
    {
        if (isPassive == false)
        {
            return clickUpgrades[upgradeID-1];
        }
        else
        {
            return passiveUpgrades[upgradeID-1];
        }
    }
}
