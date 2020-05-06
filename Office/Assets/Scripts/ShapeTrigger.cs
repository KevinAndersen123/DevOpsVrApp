using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShapeTrigger : MonoBehaviour
{
    public GameObject shapeToSpawn;
    public bool IsShapeThere = true;
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Circle" || other.tag == "Triangle" || other.tag == "Square")
        {
            IsShapeThere = false;
        }
    }
    public void SpawnShape()
    {
        if(!IsShapeThere)
        {
            Instantiate(shapeToSpawn, transform.position, transform.rotation);
            IsShapeThere = true;
        }
    }
}
