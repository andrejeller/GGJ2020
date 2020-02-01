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
        if (Input.anyKeyDown) {
            if (Random.Range(0.0f, 100.0f) <= 100.0f) {
                audioSource.clip = crashSound;
                audioSource.Play();
                StartCoroutine(ChangeScene(2));
            }
            else {
                audioSource.clip = crashSound;
                audioSource.Play();
                StartCoroutine(ChangeScene(0));
            }
        }
        
    }

    IEnumerator ChangeScene(int scene) {
        yield return new WaitForSeconds(0.0f);
        SceneManager.LoadScene(scene);
    }
     
}
