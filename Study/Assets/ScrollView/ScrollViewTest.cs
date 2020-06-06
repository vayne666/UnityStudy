using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollViewTest : MonoBehaviour
{
    // Start is called before the first frame update
    UIWarpContent uIWarpContent;
    void Start()
    {
        uIWarpContent=this.GetComponent<UIWarpContent>();
        //uIWarpContent.PerCreatItem(100,false);
        uIWarpContent.Init(10);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
