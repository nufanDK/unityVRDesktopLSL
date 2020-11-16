using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetScreenPosition : MonoBehaviour
{
    public Transform CameraPos;
    public Transform ScreenPos;
    public float DistanceToScreen;
    
    private Vector3 frontVector;
    private bool notRun = true;
    
    // Start is called before the first frame update
    void Start()
    {
        frontVector = CameraPos.forward;
    }

    // Update is called once per frame
    void Update()
    {
        if (notRun)
        {
            ScreenPos = CameraPos;
            ScreenPos.rotation = CameraPos.rotation;
            ScreenPos.forward *= DistanceToScreen; 
        }
    }
}
