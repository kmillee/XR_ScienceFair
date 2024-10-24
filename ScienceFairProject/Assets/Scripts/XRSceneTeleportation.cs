using UnityEngine;
using UnityEngine.SceneManagement;

public class XRSceneTeleportation : MonoBehaviour
{
    public string sceneName;
    public SceneFader sceneFader;


    //to cover grab and activation
    public void OnSelectEntered()
    {
        TeleportToScene();
    }

    public void OnActivate()
    {
        TeleportToScene();
    }

    //to charge new scene
    private void TeleportToScene()
    {
        SceneManager.LoadScene(sceneName);
    }
}
