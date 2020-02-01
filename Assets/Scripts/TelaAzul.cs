using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.SceneManagement;

public class TelaAzul: MonoBehaviour {

    public GameObject toScrroolll;
    
    // Start is called before the first frame update
    private IEnumerator Start() {
        toScrroolll.transform.position = new Vector2(toScrroolll.transform.position.x, -600.0f);
        toScrroolll.transform.DOLocalMoveY(1700.0f, 20.6f, false);
        yield return new WaitForSeconds(22.0f);
        SceneManager.LoadScene(3);
    }


}
