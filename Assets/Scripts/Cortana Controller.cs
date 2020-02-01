using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CortanaController : MonoBehaviour
{

    private Text m_cortanaMessage;
    
    void Start()
    {
        m_cortanaMessage.DOText("hi", 0.8f, true, ScrambleMode.All);
    }

   
}
