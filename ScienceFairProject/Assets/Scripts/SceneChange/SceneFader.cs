using UnityEngine;
using UnityEngine.UI; // Nécessaire pour utiliser les éléments UI
using UnityEngine.SceneManagement; // Nécessaire pour gérer les scènes
using System.Collections; // Nécessaire pour utiliser les coroutines

public class SceneFader : MonoBehaviour
{
    public Image fadeImage; // L'image noire que nous avons créée

    private void Start()
    {
        // Assurez-vous que l'image est invisible au début
        fadeImage.color = new Color(0, 0, 0, 0);
    }

    public void FadeToScene(string sceneName)
    {
        StartCoroutine(FadeOut(sceneName)); // Démarre la coroutine pour le fondu
    }

    private IEnumerator FadeOut(string sceneName)
    {
        // Fait apparaître l'image
        float fadeTime = 1.0f; // Temps pour le fondu
        for (float t = 0; t < fadeTime; t += Time.deltaTime)
        {
            float alpha = t / fadeTime; // Calcule l'alpha basé sur le temps
            fadeImage.color = new Color(0, 0, 0, alpha); // Change la couleur de l'image
            yield return null; // Attend la prochaine frame
        }

        // Charge la nouvelle scène
        SceneManager.LoadScene(sceneName);
    }
}
