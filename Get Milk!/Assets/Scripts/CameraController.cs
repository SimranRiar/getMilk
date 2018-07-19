﻿/***************************************************************************************
*    Title: <CameraController>
*    Author: <Jeremy Gibson Bond>
*    Code version: <Second Edition>
*    Availability: <Introduction to Game Design, Prototyping, and Develeopment>
*
***************************************************************************************/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{

    /*public GameObject player;
    private Vector3 offset;

    // Use this for initialization
    void Start()
    {
        offset = transform.position;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = player.transform.position + offset;
    }*/

    /***************************************************************************************
    *    Title: <CameraFollow>
    *    Author: <Brackeys>
    *    Source: YouTube Video
    *    Availability: <https://www.youtube.com/watch?v=MFQhpwc6cKE>
    *
    ***************************************************************************************/


    /*    public Transform target;

        public float smoothSpeed = 0.125f;
        public Vector3 offset;

        void FixedUpdate()
        {
            Vector3 desiredPosition = target.position + offset;
            Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
            transform.position = smoothedPosition;

            transform.LookAt(target);
        }
    }


    [SerializeField]
    private Transform target;

    [SerializeField]
    private Vector3 offsetPosition;

    [SerializeField]
    private Space offsetPositionSpace = Space.Self;

    [SerializeField]
    private bool lookAt = true;

    private void Update()
    {
        Refresh();
    }

    public void Refresh()
    {
        if (target == null)
        {
            Debug.LogWarning("Missing target ref !", this);

            return;
        }

        // compute position
        if (offsetPositionSpace == Space.Self)
        {
            transform.position = target.TransformPoint(offsetPosition);
        }
        else
        {
            transform.position = target.position + offsetPosition;
        }

        // compute rotation
        if (lookAt)
        {
            transform.LookAt(target);
        }
        else
        {
            transform.rotation = target.rotation;
        }
    }*/

}