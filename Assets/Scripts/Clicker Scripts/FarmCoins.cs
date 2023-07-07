using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FarmCoins : MonoBehaviour
{
    [SerializeField] PlayerStats resourcesStat;
    [SerializeField] ClickIncome onClickResourceCount;


    public void AddCoinsOnClick()
    {
        resourcesStat.AddCoins(onClickResourceCount.coinsOnClick);
    }
}
