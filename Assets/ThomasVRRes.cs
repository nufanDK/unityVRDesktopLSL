using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class ThomasVRRes : MonoBehaviour
{
    public float eyeTextureTestSize = 1f;

    // Start is called before the first frame update
    void Start()
    {
        XRSettings.eyeTextureResolutionScale = eyeTextureTestSize;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
