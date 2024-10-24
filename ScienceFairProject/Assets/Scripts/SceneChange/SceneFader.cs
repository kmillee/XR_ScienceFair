using UnityEngine;
using UnityEngine.UI; 
using UnityEngine.SceneManagement;
using System.Collections; 


//this function should apply a fading image when changing scene but it currently not working correctly
//we left it as it is linked to the actual teleportation function
public class SceneFader : MonoBehaviour
{
    public Image fadeImage;

    private void Start()
    {
        fadeImage.color = new Color(0, 0, 0, 0);
    }

    public void FadeToScene(string sceneName)
    {
        StartCoroutine(FadeOut(sceneName));
    }

    private IEnumerator FadeOut(string sceneName)
    {
        float fadeTime = 1.0f; 
        for (float t = 0; t < fadeTime; t += Time.deltaTime)
        {
            float alpha = t / fadeTime; 
            fadeImage.color = new Color(0, 0, 0, alpha); 
            yield return null; 
        }

        //charge new scene
        SceneManager.LoadScene(sceneName);
    }
}
