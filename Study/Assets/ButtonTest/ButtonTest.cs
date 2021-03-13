using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonTest : MonoBehaviour {


    private void Start() {
        this.GetComponent<Button>().onClick.AddListener(() => {
            Debug.Log("click");
        });

       // this.GetComponent<Image>().alphaHitTestMinimumThreshold = 0.1f;
    }

}
