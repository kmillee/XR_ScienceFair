using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement; // Pour gérer le changement de scène

public class Timer : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI timerText;
    float elapsedTime;
    bool timerActive = true;
    private bool hasTriggered = false; // Pour vérifier si le trigger a déjà été activé



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
        // Si l'objet qui entre dans le trigger a le tag "Player" (assure-toi que ton joueur est bien tagué)
        if (other.CompareTag("Player") && !hasTriggered)
        {
            hasTriggered = true;  // Empêche le trigger de se réactiver
            timerActive = false;
            int minutes = Mathf.FloorToInt(elapsedTime / 60);
            int seconds = Mathf.FloorToInt(elapsedTime % 60);
            timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);

        }
    }
}
