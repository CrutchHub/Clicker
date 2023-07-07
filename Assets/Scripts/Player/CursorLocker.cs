using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursorLocker : MonoBehaviour
{
    private void Start()
    {
        SetCursorLockerState(CursorLockMode.Locked);
    }
    public void SetCursorLockerState(CursorLockMode lockState)
    {
        Cursor.lockState = CursorLockMode.Locked;
    }
}
