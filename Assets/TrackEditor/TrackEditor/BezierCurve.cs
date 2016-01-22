using UnityEngine;
using System.Collections;

public class BezierCurve : MonoBehaviour {
    public Vector3[] points;

    public void Reset(){
        points = new Vector3[]{
            new Vector3(1f, 0f, 0f),
            new Vector3(2f, 0f, 0f),
            new Vector3(3f, 0f, 0f)
        };
    }
}
