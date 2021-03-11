using UnityEngine;

/***
 *@des:warp下Element对应标记
 */

[DisallowMultipleComponent]
public class UIWarpContentItem : MonoBehaviour
{
    private int index;
    private UIWarpContent warpContent;

    //记录item的位置
    private Vector3 initPosition;
    //移动的向量
    private Vector3 movePostion = new Vector3(-10000, -10000, 0);

    public int Index
    {
        set
        {
            index = value;
            transform.localPosition = warpContent.getLocalPositionByIndex(index);
            initPosition = transform.localPosition;
            gameObject.name = (index < 10) ? ("0" + index) : ("" + index);
            if (warpContent.onInitializeItem != null && index >= 0)
            {
                warpContent.onInitializeItem(gameObject, index);
            }
        }
        get
        {
            return index;
        }
    }

    public UIWarpContent WarpContent
    {
        set
        {
            warpContent = value;
        }
    }

    private void OnDestroy()
    {
        warpContent = null;
    }

    public void OnShow(bool show, bool isMove)
    {
        if (isMove)
        {
            if (show)
                transform.localPosition = initPosition;
            else
                transform.localPosition += movePostion;
        }
        else
        {
            transform.gameObject.SetActive(show);
        }
    }
}