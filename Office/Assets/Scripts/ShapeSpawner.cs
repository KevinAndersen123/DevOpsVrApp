using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShapeSpawner : MonoBehaviour
{
    public Vector3 spawnPos;
    public GameObject[] shapes;
    public void SpawnShape(int shapeIndex)
    {
        Instantiate(shapes[shapeIndex], spawnPos, transform.rotation);
    }
}
