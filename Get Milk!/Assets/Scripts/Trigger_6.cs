using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Trigger_6 : MonoBehaviour
{
    public GUIText referencetotext;

    void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Character"))
        {
            referencetotext.text = "";
        }
    }
}