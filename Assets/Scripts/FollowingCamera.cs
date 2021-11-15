using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowingCamera : MonoBehaviour
{
    //this is to position the camera to the object
    [SerializeField] GameObject Tofollow;

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = Tofollow.transform.position + new Vector3(0,0,-10);
    }
}
