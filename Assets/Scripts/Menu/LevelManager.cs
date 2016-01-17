using UnityEngine;
using System.Collections;
using System.Collections.Generic;
namespace TrainWreck.Menu
{
    //Manages switching between different levels
    public class LevelManager
    {
        int currentLevel;
        //<level num, level object>
        Dictionary<int, int> Levels = new Dictionary<int,int>();
        
        //constructor
        public LevelManager() {
            
        }

       public void SwitchToLevel(int levelNum) {
            //fetch the level
            currentLevel = Levels[levelNum];
        }
    }
}