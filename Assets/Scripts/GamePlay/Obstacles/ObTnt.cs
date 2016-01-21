using UnityEngine;
using System.Collections;
using TrainWreck.GamePlay.Obstacles;
namespace TrainWreck.GamePlay{
public class ObTnt : BaseObstacle {
        public GameObject deadParticleEffect;
        
        void OnCollisionEnter(Collision obj)
        {
            if (obj.gameObject.tag == "Player") {
                Explode();
            }
        }

         public void Explode() {
            Instantiate(deadParticleEffect, this.transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
    }
}