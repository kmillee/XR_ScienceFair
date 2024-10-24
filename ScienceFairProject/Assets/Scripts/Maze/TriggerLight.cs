using System.Collections;
using UnityEngine;
using TMPro;

//when triggered, this function change lights' color and scene music,
//it also activates some textMesh so they only appear from this moment
public class TriggerLight : MonoBehaviour
{
    public Light[] sceneLights;
    public Color newLightColor;

    //could be changed into an array to add as many texts as we like
    [SerializeField] TextMeshProUGUI textMeshPro1;
    [SerializeField] TextMeshProUGUI textMeshPro2;
    [SerializeField] TextMeshProUGUI textMeshPro3;
    [SerializeField] TextMeshProUGUI textMeshPro4;

    public Color textColor = Color.white;

    private bool hasTriggered = false; //get if trigger is already activated

    public AudioSource audioSource;
    public AudioClip clip1;
    public AudioClip clip2;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && !hasTriggered)
        {
            hasTriggered = true;  

            ChangeLightsColor();

            ShowTextMeshPro();

            //change music
            audioSource.clip = clip2;
            audioSource.Play();
        }
    }

    private void ChangeLightsColor()
    {
        foreach (Light light in sceneLights)
        {
            if (light != null)  
            {
                light.color = newLightColor; 
            }
        }
    }

    private void ShowTextMeshPro()
    {

            if (textMeshPro1 != null) 
            {
                 textMeshPro1.gameObject.SetActive(true);
                 textMeshPro1.color = textColor;
            }

        if (textMeshPro2!= null)  {
            textMeshPro2.gameObject.SetActive(true);
            textMeshPro2.color = textColor;
        }

        if (textMeshPro3 != null) 
        {
            textMeshPro3.gameObject.SetActive(true);
            textMeshPro3.color = textColor;
        }

        if (textMeshPro4 != null)  
        {
            textMeshPro4.gameObject.SetActive(true);
            textMeshPro4.color = textColor;
        }

    }

    
}
