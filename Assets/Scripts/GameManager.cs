using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField] private Image m_progressBar;
    private float m_progressPercent = 0.3f;
    public Text PercentProgres;
    
    
    void Start() {
        m_progressBar.fillAmount = m_progressPercent;
    }

    
    void Update()
    {

        m_progressBar.fillAmount = m_progressPercent;
        m_progressPercent -= Time.deltaTime / 30;
        PercentProgres.text = (m_progressPercent*100).ToString("00");
        
        if (Input.GetKeyUp(KeyCode.Space)) {
            
            m_progressPercent += 0.02f;

            var rand = Random.Range(0, 100);
            
            if (rand > 0 && rand <= 1)
            {
                Debug.Log("CRASHPU");
            }
        }
    }
}
