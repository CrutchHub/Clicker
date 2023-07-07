using UnityEngine;

public class ClickIncome : MonoBehaviour
{
    [SerializeField] public float foodOnClick = 2;
    [SerializeField] public float woodOnClick = 2;
    [SerializeField] public float coinsOnClick = 2;

    private void Awake()
    {
        print(foodOnClick);
        foodOnClick = PlayerPrefs.GetFloat("foodOnClick");
        woodOnClick = PlayerPrefs.GetFloat("woodOnClick");
        coinsOnClick = PlayerPrefs.GetFloat("coinsOnClick");
        if (foodOnClick == 0) foodOnClick = 1;
        if (woodOnClick == 0) woodOnClick = 1;
        if (coinsOnClick == 0) coinsOnClick = 1;
    }

    public void UpgradeFoodOnClick(float upgradeCount)
    {
        foodOnClick += upgradeCount;
        PlayerPrefs.SetFloat("foodOnClick", foodOnClick);
    }
    public void UpgradeWoodOnClick(float upgradeCount)
    {
        woodOnClick += upgradeCount;
        PlayerPrefs.SetFloat("woodOnClick", woodOnClick);
    }
    public void UpgradeCoinsOnClick(float upgradeCount)
    {
        coinsOnClick += upgradeCount;
        PlayerPrefs.SetFloat("coinsOnClick", coinsOnClick);
    }
}
