using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CortanaController : MonoBehaviour {

    [SerializeField]
    private Text m_cortanaMessage;
    private float errorTime = 0;

    
    public GameObject _404;
    public GameObject bluePanel;

    private IEnumerator Start() {
        m_cortanaMessage.text = "...";
        bluePanel.SetActive(false);
        yield return new WaitForSeconds(2.0f);

        m_cortanaMessage.DOText("Hi, I'm Cortin@", 2.3f, true, ScrambleMode.Lowercase)
            .OnComplete(() => {
                errorTime = Random.Range(0, 4);
            });

        yield return new WaitForSeconds(4.8f);

        if (errorTime < 2) {
            Tween errorTween  = m_cortanaMessage.DOText("Erros found, time to reboot....", 2.8f, true, ScrambleMode.All);
            yield return errorTween.WaitForCompletion();

            bluePanel.SetActive(true);

            Tween myTween = _404.transform.DOScaleX(-40.0f, 2.5f);
            yield return myTween.WaitForCompletion();
            

            bluePanel.SetActive(false);
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);  /* RELOAD */
            Debug.Log("REBOOT");


        } else {
            m_cortanaMessage.DOText("Everithing is okay.. \n Game Time \n Go and Fiix your Uindows®", 2.8f, true, ScrambleMode.Lowercase)
                .OnComplete(() =>
                {
                    SceneManager.LoadScene(1); /* NEXT */
                    new WaitForSeconds(4.0f);
                    Debug.Log("NEXT");
                });
        }




        yield return null;
    }


}
