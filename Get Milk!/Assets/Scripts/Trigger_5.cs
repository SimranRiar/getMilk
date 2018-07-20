using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Trigger_5 : MonoBehaviour
{
    public GUIText referencetotext;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Character"))
        {
            referencetotext.text = "Go to the Refrigerator to get some milk.";
        }
    }
}