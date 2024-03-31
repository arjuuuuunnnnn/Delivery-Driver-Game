using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    // making the camera's position same as the car's position
    // that is we have to create a reference
    [SerializeField] GameObject thingToFollow;
    void LateUpdate()//added late update coz camera should follow car and shouldn't go before car
    {
        transform.position = thingToFollow.transform.position + new Vector3 (0, 0, -10);
        // right after doing this the camera will be inside the car and nothing would be seen 
        // so the thing what we should do is 
        // take that camera upwards so that it could see things
    }
}
