using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Trigger_1 : MonoBehaviour
{
    void onTriggerEnter(Collider other)
    {
        Debug.Log("Passed through Trigger");
    }
}