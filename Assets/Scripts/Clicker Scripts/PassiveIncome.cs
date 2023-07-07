using System.Collections;
using UnityEngine;

public class PassiveIncome : MonoBehaviour
{
    [SerializeField] PlayerStats resourcesCount;

    [SerializeField] public float foodPassiveIncome = 0;
    [SerializeField] public float woodPassiveIncome = 0;
    [SerializeField] public float coinsPassiveIncome = 0;

    private Coroutine _AddPassiveFood;
    private Coroutine _AddPassiveWood;
    private Coroutine _AddPassiveCoins;

    private void Awake()
    {
        foodPassiveIncome = PlayerPrefs.GetFloat("foodPassiveIncome");
        woodPassiveIncome = PlayerPrefs.GetFloat("woodPassiveIncome");
        coinsPassiveIncome = PlayerPrefs.GetFloat("coinsPassiveIncome");
    }

    private void Start()
    {
        _AddPassiveFood = StartCoroutine(AddPassiveFood());
        _AddPassiveCoins = StartCoroutine(AddPassiveCoins());
        _AddPassiveWood = StartCoroutine(AddPassiveWood());
    }


    public void UpgradeFoodPassive(float upgradeCount)
    {
        foodPassiveIncome += upgradeCount;
        PlayerPrefs.SetFloat("foodPassiveIncome", foodPassiveIncome);
    }
    public void UpgradeWoodPassive(float upgradeCount)
    {
        woodPassiveIncome += upgradeCount;
        PlayerPrefs.SetFloat("woodPassiveIncome", woodPassiveIncome);
    }
    public void UpgradeCoinsPassive(float upgradeCount)
    {
        coinsPassiveIncome += upgradeCount;
        PlayerPrefs.SetFloat("coinsPassiveIncome", coinsPassiveIncome);
    }

    private IEnumerator AddPassiveFood()
    {
        while (true)
        {
            yield return new WaitForSeconds(1.0f);
            resourcesCount.AddFood(foodPassiveIncome);
        }
    }
    private IEnumerator AddPassiveWood()
    {
        while (true)
        {
            yield return new WaitForSeconds(1.0f);
            resourcesCount.AddWood(woodPassiveIncome);
        }
    }
    private IEnumerator AddPassiveCoins()
    {
        while (true)
        {
            yield return new WaitForSeconds(1.0f);
            resourcesCount.AddCoins(coinsPassiveIncome);
        }
    }
}
