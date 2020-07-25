using System.Collections;
using System.Collections.Generic;

using UnityEngine.UI;
using UnityEngine;

public class ScrollViewTest : MonoBehaviour {
    // Start is called before the first frame update
    
    UIWarpContent uIWarpContent;
    void Awake() {
        uIWarpContent = this.GetComponent<UIWarpContent>();
        uIWarpContent.onInitializeItem += onInitializeItem;
        //uIWarpContent.PerCreatItem(100, false);
        //uIWarpContent.viewCount = 5;
        ////uIWarpContent.Init(10);
        //uIWarpContent.cellHeight = 100;
        //uIWarpContent.cellWidth = 100;
        //uIWarpContent.EndInterval = 40;
        //uIWarpContent.onInitializeItem = onInitializeItem;
        //uIWarpContent.viewCount = 10;
        //uIWarpContent.maxPerLine = 2;

    }

    // Update is called once per frame
    void Update() {

    }

    private void OnGUI() {
        if (GUILayout.Button("dwadwadad")) {
            uIWarpContent.Init(100);
        }
    }


    public void onInitializeItem(GameObject go, int idx) {
        Debug.LogError(idx);
        
        var t = go.transform.Find("Value").GetComponent<Text>();

        t.text = idx.ToString();
    }
}
