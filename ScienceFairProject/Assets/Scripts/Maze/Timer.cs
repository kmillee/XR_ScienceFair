using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement; // Pour g�rer le changement de sc�ne

public class Timer : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI timerText;
    float elapsedTime;
    bool timerActive = true;
    private bool hasTriggered = false; // Pour v�rifier si le trigger a d�j� �t� activ�



    // Update is called once per frame
    void Update()
    {
        if (timerActive)
        {
            elapsedTime += Time.deltaTime;
            int minutes = Mathf.FloorToInt(elapsedTime / 60);
            int seconds = Mathf.FloorToInt(elapsedTime % 60);
            timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
        }
    }


    private void OnTriggerEnter(Collider other)
    {
        // Si l'objet qui entre dans le trigger a le tag "Player" (assure-toi que ton joueur est bien tagu�)
        if (other.CompareTag("Player") && !hasTriggered)
        {
            hasTriggered = true;  // Emp�che le trigger de se r�activer
            timerActive = false;
            int minutes = Mathf.FloorToInt(elapsedTime / 60);
            int seconds = Mathf.FloorToInt(elapsedTime % 60);
            timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);

        }
    }
}
