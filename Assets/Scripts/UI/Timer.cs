using System.Collections;
using TMPro;
using UnityEngine;

public class Timer : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI timeText;
    [SerializeField] bool isActive = true;

    private float _time = 5;
    private void Start()
    {
        StartCoroutine(DebugEveryTwoSecond());
    }
    private void Update()
    {
        if (isActive == false) return;

        _time -= Time.deltaTime;

        if (_time <= 0.001f)
        {
            isActive = false;
        }

        UpdateUI(_time);
    }

    private void UpdateUI(float time)
    {
        time += 1;

        float minutes = Mathf.FloorToInt(time / 60);
        float seconds = Mathf.FloorToInt(time % 60);

        timeText.text = $"{minutes:00}:{seconds:00}";
    }
    private IEnumerator DebugEveryTwoSecond()
    {
        while (true)
        {
            yield return new WaitForSeconds(2);
            Debug.Log("hello");
        }
    }
}
