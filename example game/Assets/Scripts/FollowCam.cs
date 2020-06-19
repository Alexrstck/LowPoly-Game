using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCam : MonoBehaviour

{
    public float distanceAway = 10;
    public float distanceUp = 5;
    public float smooth = 3;

    public bool FollowMe = true;

    public Transform Target;
    private Vector3 targetPosition;


    void LateUpdate()
    {
        if (FollowMe)
        {
            targetPosition = Target.position + Target.up * distanceUp - Target.forward * distanceAway;
            transform.position = Vector3.Lerp(transform.position, targetPosition, Time.deltaTime * smooth);
            transform.LookAt(Target);
        }
    }
    
 
}
