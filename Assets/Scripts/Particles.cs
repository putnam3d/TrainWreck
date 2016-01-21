using UnityEngine;
using System.Collections;

public class Particles : MonoBehaviour {
    public float secondsAlive = 0f;

    void Start() {
        StartCoroutine(Run(secondsAlive));
    }

    IEnumerator Run(float secondsAlive) {
        yield return new WaitForSeconds(secondsAlive);
        Destroy(gameObject);
    }
}
