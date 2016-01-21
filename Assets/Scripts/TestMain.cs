using UnityEngine;
using System.Collections;
using TrainWreck.GamePlay;

public class TestMain : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        MouseInput();
	}

    void MouseInput() { 
        //left click
        if(Input.GetMouseButtonDown(0)){
            //raycast
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            float dist = 1000f;
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit, dist)) {
                if (hit.transform.tag == "Explosive") {
                    ObTnt tnt = (ObTnt)hit.transform.GetComponent<ObTnt>();
                    tnt.Explode();
                }
            }
        }
    }
}
