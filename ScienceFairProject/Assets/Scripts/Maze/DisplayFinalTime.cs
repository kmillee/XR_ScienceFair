using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DisplayFinalTime : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI finalTimeText;

    void Start()
    {
        float finalTime = TimerData.finalTime;
        int minutes = Mathf.FloorToInt(finalTime / 60);
        int seconds = Mathf.FloorToInt(finalTime % 60);
        finalTimeText.text = "Time spent : " + string.Format("{0:00}:{1:00}", minutes, seconds);
    }
}
