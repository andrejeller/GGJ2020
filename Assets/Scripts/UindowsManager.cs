using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UindowsManager : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip welcomeSound,crashSound;
    
    // Start is called before the first frame update
    void Start()
    {
        audioSource.clip = welcomeSound;
        audioSource.Play();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.anyKey)
        {
            if ((Random.Range(0.0f, 100.0f)%2) == 0)
            {
                audioSource.clip = crashSound;
                audioSource.Play();
                SceneManager.LoadScene("GameScene");
            }
            else
            {
                audioSource.clip = crashSound;
                audioSource.Play();
                SceneManager.LoadScene("WelcomeScreen");
            }
        }
        
    }
    
     
}
