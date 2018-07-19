/***************************************************************************************
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

    public GameObject player;
    private Vector3 offset;


    // Use this for initialization
    void Start()
    {
        offset = transform.position - player.transform.position;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = player.transform.position + offset;
    }
}
