using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SafeAreaTest : MonoBehaviour {
    // Start is called before the first frame update
    RectTransform rectTransform;
    Rect safeArea;

    void Start() {
        rectTransform = this.GetComponent<RectTransform>();
        safeArea = Screen.safeArea;
        Debug.Log(string.Format("safeArea:{0}", safeArea));
        Debug.Log(string.Format("scene:w:{0} h:{1}", Screen.width, Screen.height));
        Debug.Log(string.Format("Old anchorMin:{0}", rectTransform.anchorMin));
        Debug.Log(string.Format("Old anchorMax:{0}", rectTransform.anchorMax));



        Vector2 anchorMin = safeArea.position;
        Vector2 anchorMax = safeArea.position + safeArea.size;
        //anchorMin(左上角)、anchorMax(右下角)表示在屏幕上的百分比位置,在屏幕内的取值范围是[0,1]
        anchorMin.x /= Screen.width;
        anchorMin.y /= Screen.height;
        anchorMax.x /= Screen.width;
        anchorMax.y /= Screen.height;
        rectTransform.anchorMin = anchorMin;
        rectTransform.anchorMax = anchorMax;

        Debug.Log(string.Format("New anchorMin:{0}", rectTransform.anchorMin));
        Debug.Log(string.Format("New anchorMax:{0}", rectTransform.anchorMax));

    }

    // Update is called once per frame
    void Update() {

    }
}
