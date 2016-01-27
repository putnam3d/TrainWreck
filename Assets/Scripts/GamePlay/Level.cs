using UnityEngine;
using System.Collections;

public class Level : MonoBehaviour {

    float progress = 0f;
    bool bFinished = false;

    public void Start(){ 
    
    }

    public void Pause() { 
    
    }

    public void Quit() { 
    
    }

	// Update is called once per frame
	void Update () {
        CheckForFinish();
	}

    void CheckForFinish() {
        if (bFinished) { 
            //Run Win State
        }
    }
}
