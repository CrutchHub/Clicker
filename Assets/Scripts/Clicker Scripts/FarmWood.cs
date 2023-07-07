using UnityEngine;

public class FarmWood : MonoBehaviour
{
    [SerializeField] PlayerStats resourcesStat;
    [SerializeField] ClickIncome onClickResourceCount;


    public void AddWoodOnClick()
    {
        resourcesStat.AddWood(onClickResourceCount.woodOnClick);
    }
}
