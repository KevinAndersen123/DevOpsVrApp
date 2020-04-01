using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextTrigger : MonoBehaviour
{
    [SerializeField]
    private GameObject text;
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            text.SetActive(false);
        }
    }
}
