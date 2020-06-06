using System.Collections;
using System.Collections.Generic;
//using UnityEditor.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(PolygonCollider2D))]
public class UIPolygon : Image {


    private PolygonCollider2D polygon;

    public PolygonCollider2D Polygon {
        get {
            if (polygon == null) {
                polygon = GetComponent<PolygonCollider2D>();
            }
            return polygon;
        }
    }
    public override bool IsRaycastLocationValid(Vector2 screenPoint, Camera eventCamera) {
        //该点是否与碰撞器重合
        return Polygon.OverlapPoint(eventCamera.ScreenToWorldPoint(screenPoint));

    }

}

