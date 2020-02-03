using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

using UnityEngine.SceneManagement;
public class GameManager: MonoBehaviour {
    [SerializeField]
    private Image m_progressBar;
    private float m_progressPercent = 0.3f;
    public Text PercentProgres;

    bool entrou = false;
    bool saiu = false;

    void Start() {
        m_progressBar.fillAmount = m_progressPercent;
        entrou = false;
        saiu = false;
    }


    void Update() {

        m_progressBar.fillAmount = m_progressPercent;
        m_progressPercent -= Time.deltaTime / 30;
        PercentProgres.text = (m_progressPercent * 100).ToString("00") + "%";

        //VITORIA

        if (m_progressPercent * 100 >= 110) {
            SceneManager.LoadScene(4);
        }



        if (Input.touchCount > 0 && !entrou) {
            entrou = true;
        }
        else if (Input.touchCount == 0 && entrou && !saiu) {
            //entrou = false;
            saiu = true;
        }
        else if (entrou && saiu) {
            m_progressPercent += 0.02f;

            var rand = Random.Range(0, 100);

            if (rand > 0 && rand <= 2) {
                Debug.Log("CRASHPU");
                SceneManager.LoadScene(2);
            }
            entrou = false;
            saiu = false;

        }
        
        

    }
}
