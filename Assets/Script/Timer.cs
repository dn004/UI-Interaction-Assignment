using System.Collections;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    public TMP_Text timerText;
    public TMP_Text eventText;
    
    private float elapsedTime = 0f;
    private bool isRunning = false;
    
    private void Start()
    {
        eventText.gameObject.SetActive(false);
        isRunning = true;
        StartCoroutine(UpdateTimer());
    }

    private IEnumerator UpdateTimer()
    {
        while (isRunning)
        {
            elapsedTime += Time.deltaTime;

            int hours = Mathf.FloorToInt(elapsedTime / 3600);
            int minutes = Mathf.FloorToInt((elapsedTime % 3600) / 60);
            int seconds = Mathf.FloorToInt(elapsedTime % 60);

            timerText.text = string.Format("{0:00}:{1:00}:{2:00}", hours, minutes, seconds);

            if (elapsedTime >= 90f)
            {
                eventText.gameObject.SetActive(true);
                isRunning = false;
            }

            yield return null;
        }
    }
}
