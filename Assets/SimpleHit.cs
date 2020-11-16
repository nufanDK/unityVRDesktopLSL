using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleHit : MonoBehaviour
{

    public FloatSO RayHitPosX;
    public FloatSO RayHitPosY;
    public FloatSO RayHitPosZ;

    private float posX;
    private float posY;
    private float posZ;

    private Vector3 posTemp;

    void Update()
    {
        RaycastHit hitCast;
        var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        
        

        if (Physics.Raycast(ray, out hitCast))
        {
            posTemp = hitCast.transform.InverseTransformPoint(hitCast.point);

            //Physics.Linecast(transform.position,hitCast.transform.InverseTransformPoint(hitCast.point));
            Debug.Log("HitCastX: " + posTemp);

            RayHitPosX.Value = posTemp.x;
            RayHitPosY.Value = posTemp.y;
            RayHitPosZ.Value = posTemp.z;
        };
    }
}
