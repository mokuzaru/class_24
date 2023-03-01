using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class follow : MonoBehaviour
{
    public Transform target;
    public float cam_speed = 0.1f;
    Camera mycam;

    void Start()
    {
        mycam = GetComponent<Camera>();
    }

    
    void Update()
    {
        mycam.orthographicSize = (Screen.height / 100f) / 1f;

        if(target){
            transform.position = Vector3.Lerp(transform.position, target.position, cam_speed) + new Vector3 (0,0,-10);
        }
    }
}
