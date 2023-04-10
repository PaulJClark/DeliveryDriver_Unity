using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    [SerializeField] GameObject objectToFollow;

    //this things position (camera) should be the same as the car's position

    void Update()
    {
       transform.position =  objectToFollow.transform.position + new Vector3 (0,0,-10);
    }
}
