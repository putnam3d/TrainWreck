using UnityEngine;
using System.Collections;

namespace TrainWreck.GamePlay
{
    public class Player : MonoBehaviour
    {
        Train train;
        void Awake()
        {

        }
        // Use this for initialization
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            KeyboardInput();
        }

        void KeyboardInput()
        {

            //move right
            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                //move to train track to right 
            }

            //move left
            if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                //move to train track to left
            }
        }
    }
}
