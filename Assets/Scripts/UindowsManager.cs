using System;
using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;
using UnityEngine.SceneManagement;
using Random = UnityEngine.Random;

public class UindowsManager : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip welcomeSound,crashSound;


    void Start() {
        audioSource.clip = welcomeSound;
        audioSource.Play();
    }

    
    void Update() {
        if (Input.anyKey) {
            if ((Random.Range(0.0f, 100.0f)%2) == 0) {
                audioSource.clip = crashSound;
                audioSource.Play();
                StartCoroutine(ChangeScene("GameScene"));
            }
            else {
                audioSource.clip = crashSound;
                audioSource.Play();
                StartCoroutine(ChangeScene("WelcomeScreen"));
            }
        }
        
    }

    IEnumerator ChangeScene(String sceneName) {
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene(sceneName);
    }
     
}
