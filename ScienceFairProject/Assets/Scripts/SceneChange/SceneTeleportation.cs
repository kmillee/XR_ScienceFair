using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTeleportation : MonoBehaviour
{
    public string sceneName;
    public SceneFader sceneFader;

    public void TeleportToScene()
    {
        //SceneManager.LoadScene(sceneName);
        sceneFader.FadeToScene(sceneName);

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            sceneFader.FadeToScene(sceneName);
        }
    }
}
