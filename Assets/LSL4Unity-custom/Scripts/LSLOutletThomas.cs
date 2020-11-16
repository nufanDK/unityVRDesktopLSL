using UnityEngine;
using System.Collections;
using LSL;
using System.Diagnostics;

namespace Assets.LSL4Unity.Scripts
{
    
    public class LSLOutletThomas : MonoBehaviour
    {
        private liblsl.StreamOutlet outlet;
        private liblsl.StreamInfo streamInfo;
        private float[] currentSample;

        public string StreamName = "Unity.ExampleStream";
        public string StreamType = "Unity.FixedUpdateTime";
        public int ChannelCount = 3;

        public FloatSO FocusPointOnObjectX;
        public FloatSO FocusPointOnObjectY;
        public FloatSO FocusPointOnObjectZ;

        // Use this for initialization
        void Start()
        {

            currentSample = new float[ChannelCount];

            streamInfo = new liblsl.StreamInfo(StreamName, StreamType, ChannelCount, Time.fixedDeltaTime * 1000);

            outlet = new liblsl.StreamOutlet(streamInfo);
        }

        public void FixedUpdate()
        {


            currentSample[0] = FocusPointOnObjectX.Value;
            currentSample[1] = FocusPointOnObjectY.Value;
            currentSample[2] = FocusPointOnObjectZ.Value;
            outlet.push_sample(currentSample);
        }
    }
}