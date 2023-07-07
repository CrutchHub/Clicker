using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class FarmFood : MonoBehaviour
{
    [SerializeField] PlayerStats resourcesStat;
    [SerializeField] ClickIncome onClickResourceCount;

    
    public void AddFoodOnClick()
    {
        resourcesStat.AddFood(onClickResourceCount.foodOnClick);
    }
}
