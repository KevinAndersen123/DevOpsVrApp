using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColour : MonoBehaviour
{
    public Material material;
    public void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Square") || other.gameObject.CompareTag("Circle") || other.gameObject.CompareTag("Triangle"))
        {
            other.gameObject.GetComponent<Renderer>().sharedMaterial = material;
        }
    }
}
