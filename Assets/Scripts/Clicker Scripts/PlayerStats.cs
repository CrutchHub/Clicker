using TMPro;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    [SerializeField] public float coinsCount;
    [SerializeField] private TextMeshProUGUI coinsInfo;

    [SerializeField] public float foodCount;
    [SerializeField] private TextMeshProUGUI foodInfo;

    [SerializeField] public float woodCount;
    [SerializeField] private TextMeshProUGUI woodInfo;


    private void Awake()
    {
        coinsCount = PlayerPrefs.GetFloat("coinsCount");
        foodCount = PlayerPrefs.GetFloat("foodCount");
        woodCount = PlayerPrefs.GetFloat("woodCount");
    }

    public void AddFood(float count)
    {
        foodCount += count;
        UpdateUI();
    }

    public void AddCoins(float count)
    {
        coinsCount += count;
        UpdateUI();
    }

    public void AddWood(float count)
    {
        woodCount += count;
        UpdateUI();
    }

    private void UpdateUI()
    {
        coinsInfo.text = Mathf.FloorToInt(coinsCount).ToString();
        foodInfo.text = Mathf.FloorToInt(foodCount).ToString();
        woodInfo.text = Mathf.FloorToInt(woodCount).ToString();
        PlayerPrefs.SetFloat("coinsCount", coinsCount);
        PlayerPrefs.SetFloat("woodCount", woodCount);
        PlayerPrefs.SetFloat("foodCount", foodCount);
    }
    
}
