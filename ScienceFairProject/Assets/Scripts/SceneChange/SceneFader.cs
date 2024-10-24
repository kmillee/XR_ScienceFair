using UnityEngine;
using UnityEngine.UI; // N�cessaire pour utiliser les �l�ments UI
using UnityEngine.SceneManagement; // N�cessaire pour g�rer les sc�nes
using System.Collections; // N�cessaire pour utiliser les coroutines

public class SceneFader : MonoBehaviour
{
    public Image fadeImage; // L'image noire que nous avons cr��e

    private void Start()
    {
        // Assurez-vous que l'image est invisible au d�but
        fadeImage.color = new Color(0, 0, 0, 0);
    }

    public void FadeToScene(string sceneName)
    {
        StartCoroutine(FadeOut(sceneName)); // D�marre la coroutine pour le fondu
    }

    private IEnumerator FadeOut(string sceneName)
    {
        // Fait appara�tre l'image
        float fadeTime = 1.0f; // Temps pour le fondu
        for (float t = 0; t < fadeTime; t += Time.deltaTime)
        {
            float alpha = t / fadeTime; // Calcule l'alpha bas� sur le temps
            fadeImage.color = new Color(0, 0, 0, alpha); // Change la couleur de l'image
            yield return null; // Attend la prochaine frame
        }

        // Charge la nouvelle sc�ne
        SceneManager.LoadScene(sceneName);
    }
}
