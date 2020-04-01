using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class LockOnSeatController : MonoBehaviour
{

    private Vector3 seatPos;
    private GameObject x;
    private Rigidbody rb;
    private bool InSeat = false;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if(InSeat)
        transform.position = seatPos;
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "chair")
        {
            InSeat = true;
            x = other.gameObject;
            seatPos = x.transform.position;
            transform.position = x.transform.position;
            rb.constraints = RigidbodyConstraints.FreezePosition;
        }
    }
}
