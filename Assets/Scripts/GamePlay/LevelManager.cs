using UnityEngine;
using System.Collections;
using System.Collections.Generic;
namespace TrainWreck.GamePlay
{
    //Manages switching between different levels
    public class LevelManager
    {
        Level currentLevel;
        //<level num, level object>
        Dictionary<int, Level> Levels = new Dictionary<int,Level>();
        
        //constructor
        public LevelManager() {
            InitializeLevels();
        }

        void InitializeLevels(){
            //grab all levels put them in levels dictionary
        }

       public void SwitchToLevel(int levelNum) {
            //fetch the level
            currentLevel = Levels[levelNum];
        }
    }
}