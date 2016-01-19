using UnityEngine;
using System.Collections;
using TrainWreck.GamePlay.Obstacles;
namespace TrainWreck.GamePlay{
public class ObTnt : BaseObstacle {

	    // Use this for initialization
	    void Start () {
	    
	    }
	
	    // Update is called once per frame
	    void Update () {
	    
	    }
        
        void OnCollisionEnter(Collision obj)
        {
            if (obj.gameObject.tag == "Player") {
                Explode();
            }

        }

        void Explode() {
            //play explosion particle system
            Destroy(gameObject);
        }
    }
}