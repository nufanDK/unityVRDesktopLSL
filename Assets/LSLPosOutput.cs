using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using LSL;

public class LSLPosOutput : MonoBehaviour
{
    private liblsl.StreamOutlet outlet;
    private float[] currentSample;

    public string StreamName = "Unity.ExampleStream";
    public string StreamType = "Unity.StreamType";
    public string StreamId = "MyStreamID-Unity1234";

    public FloatSO FocusPointOnObjectX;
    public FloatSO FocusPointOnObjectY;
    public FloatSO FocusPointOnObjectZ;

    // Start is called before the first frame update
    void Start()
    {
        liblsl.StreamInfo streamInfo = new liblsl.StreamInfo(StreamName, StreamType, 3, Time.fixedDeltaTime * 1000, liblsl.channel_format_t.cf_float32);
        liblsl.XMLElement chans = streamInfo.desc().append_child("channels");
        chans.append_child("channel").append_child_value("VirtualScreenFocus", "X");
        chans.append_child("channel").append_child_value("VirtualScreenFocus", "Y");
        chans.append_child("channel").append_child_value("VirtualScreenFocus", "Z");
        outlet = new liblsl.StreamOutlet(streamInfo);
        currentSample = new float[3];
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        currentSample[0] = FocusPointOnObjectX.Value;
        currentSample[1] = FocusPointOnObjectY.Value;
        currentSample[2] = FocusPointOnObjectZ.Value;
        outlet.push_sample(currentSample);
    }
}
