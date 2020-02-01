using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class TelaAzul: MonoBehaviour {

    public GameObject toScrroolll;
    
    // Start is called before the first frame update
    void Start() {
        toScrroolll.transform.position = new Vector2(toScrroolll.transform.position.x, -660.0f);
        toScrroolll.transform.DOLocalMoveY(1700.0f, 20.6f, false);
    }


}
