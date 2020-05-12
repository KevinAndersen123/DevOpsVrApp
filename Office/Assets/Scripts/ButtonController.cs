using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
public class ButtonController : MonoBehaviour
{
    Transform parent;
    public Transform pointA;
    public Transform pointB;

    public UnityEvent ReleasedA;
    public UnityEvent ReleasedB;
    public UnityEvent HitA;
    public UnityEvent HitB;
    Vector3 offset = new Vector3(0, 0, 0);
    int state = 0;
    int prevState = 0;
    public GameObject spawnPos;
    public GameObject shapePrefab;
    public void SpawnShape()
    {
        Instantiate(shapePrefab, spawnPos.transform.position, shapePrefab.transform.rotation);
    }
    void Update()
    {
        if (parent != null)
        {
            transform.position = ClosestPointOnLine(parent.position) - offset;
        }
        else
        {
            transform.position = ClosestPointOnLine(transform.position) - offset;
        }
        if (transform.position == pointA.position)
        {
            state = 1;
        }
        else if (transform.position == pointB.position)
        {
            state = 2;
        }
        else
            state = 0;

        prevState = state;
        if(state == 1 && prevState == 0)
        {
            HitA.Invoke();
        }
        else if(state == 2 && prevState == 0)
        {
            HitB.Invoke();
        }
        else if(state== 0 && prevState==1)
        {
            ReleasedA.Invoke();
        }
        else if (state == 0 && prevState == 2)
        {
            ReleasedB.Invoke();
        }
        //for testing spawn without any headset
        if(Input.anyKeyDown)
        {
            HitB.Invoke();
        }
    }


    Vector3 ClosestPointOnLine(Vector3 point)
    {
        Vector3 va = pointA.position + offset;
        Vector3 vb = pointB.position + offset;

        Vector3 vVector1 = point - va;

        Vector3 vVector2 = (vb - va).normalized;

        float t = Vector3.Dot(vVector2, vVector1);

        if (t <= 0)
            return va;

        if (t >= Vector3.Distance(va, vb))
            return vb;

        Vector3 vVector3 = vVector2 * t;

        Vector3 vClosestPoint = va + vVector3;

        return vClosestPoint;
    }
}

