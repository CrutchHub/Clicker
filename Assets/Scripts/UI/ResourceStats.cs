using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ResourceStats : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI resourceCountText;

    private float _resourceCount;

    private void Update()
    {
        _resourceCount++;
        resourceCountText.text = _resourceCount.ToString();
    }
}
