using System.Collections;
using UnityEngine;
using TMPro;  // Nécessaire pour utiliser TextMeshPro

public class TriggerLight : MonoBehaviour
{
    public Light[] sceneLights;        // Tableau de lumières
    public Color newLightColor;        // Nouvelle couleur pour toutes les lumières

    [SerializeField] TextMeshProUGUI textMeshPro1;
    [SerializeField] TextMeshProUGUI textMeshPro2;
    [SerializeField] TextMeshProUGUI textMeshPro3;
    [SerializeField] TextMeshProUGUI textMeshPro4;

    public Color textColor = Color.white; // Couleur du texte (facultatif)

    private bool hasTriggered = false; // Pour vérifier si le trigger a déjà été activé

    public AudioSource audioSource;
    public AudioClip clip1;
    public AudioClip clip2;

    // Quand un objet entre dans le trigger
    private void OnTriggerEnter(Collider other)
    {
        // Si l'objet qui entre dans le trigger a le tag "Player" (assure-toi que ton joueur est bien tagué)
        if (other.CompareTag("Player") && !hasTriggered)
        {
            hasTriggered = true;  // Empêche le trigger de se réactiver

            // Changer la couleur de toutes les lumières
            ChangeLightsColor();

            // Afficher le texte TextMeshPro
            ShowTextMeshPro();

            audioSource.clip = clip2;
            audioSource.Play();
        }
    }

    // Fonction pour changer la couleur de toutes les lumières
    private void ChangeLightsColor()
    {
        foreach (Light light in sceneLights)
        {
            if (light != null)  // Assure-toi que la lumière n'est pas nulle
            {
                light.color = newLightColor;  // Changer la couleur de chaque lumière
            }
        }
    }

    // Coroutine pour afficher les textes avec un léger délai
    private void ShowTextMeshPro()
    {

            if (textMeshPro1 != null)  // Assure-toi que la lumière n'est pas nulle
            {
                 textMeshPro1.gameObject.SetActive(true);
                 textMeshPro1.color = textColor;
            }

        if (textMeshPro2!= null)  // Assure-toi que la lumière n'est pas nulle
        {
            textMeshPro2.gameObject.SetActive(true);
            textMeshPro2.color = textColor;
        }

        if (textMeshPro3 != null)  // Assure-toi que la lumière n'est pas nulle
        {
            textMeshPro3.gameObject.SetActive(true);
            textMeshPro3.color = textColor;
        }

        if (textMeshPro4 != null)  // Assure-toi que la lumière n'est pas nulle
        {
            textMeshPro4.gameObject.SetActive(true);
            textMeshPro4.color = textColor;
        }

    }

    
}
