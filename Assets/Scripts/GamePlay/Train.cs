using UnityEngine;
using System.Collections;

namespace TrainWreck.GamePlay
{
    public enum TrackType { 
        LEFT,
        MIDDLE,
        RIGHT
    }
    public enum TrainShift { 
        LEFT,
        LEVELED,
        RIGHT
    }

    public class Train : MonoBehaviour
    {
        public bool lookForward;
        BezierSpline trackPath;
        public float duration = 0f;
        [SerializeField]
        private float progress = 0f;
        public const int MaxHealth = 100;
        public int health = MaxHealth;
        public Vector3 pos;
        TrackType cTrackType = TrackType.MIDDLE;
        TrainShift cTrainShift = TrainShift.LEVELED;

        void Awake() {
            trackPath = (BezierSpline)GameObject.FindGameObjectWithTag("TrackPath").GetComponent<BezierSpline>();    
        }

        // Use this for initialization
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            progress += Time.deltaTime/duration;
            if (progress >= 1f) {
                progress -= 1f;
            }
            Vector3 position = trackPath.GetPoint(progress);
            transform.localPosition = position;
            if (lookForward) {
                transform.LookAt(position + trackPath.GetDirection(progress));
            }
        }

        public void JumpTrack(TrackType track) {
            if (track == cTrackType) {
                return;
            }

            switch (track) { 
                case TrackType.LEFT:
                    cTrackType = TrackType.LEFT;
                    break;
                case TrackType.MIDDLE:
                    cTrackType = TrackType.MIDDLE;
                    break;
                case TrackType.RIGHT:
                    cTrackType = TrackType.RIGHT;
                    break;
                default:
                    Debug.LogError("Function JumpTrack() in Train.cs:  Not a valid Track type.");
                    break;
            }
        }

        public void ShiftTrain(TrainShift shift) {
            if (shift == cTrainShift) {
                return;
            }

            switch (shift) {
                case TrainShift.LEFT:
                    //play shift left animation
                    //play shift right audio
                    cTrainShift = TrainShift.LEFT;
                    break;
                case TrainShift.LEVELED:
                    //play leveling animation
                    //play leveling audio
                    cTrainShift = TrainShift.LEVELED;
                    break;
                case TrainShift.RIGHT:
                    //play shift right animation
                    //play shift right audio11
                    cTrainShift = TrainShift.RIGHT;
                    break;
                default:
                    Debug.LogError("Function ShifTrack in Train.cs: Not a valid ShiftTrain type.");
                    break;
            }
        }
    }
}
