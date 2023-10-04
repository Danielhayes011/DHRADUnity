using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class snowballcontorl : MonoBehaviour
{
    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    internal void ImThrowingYou(bearControl scbearscript)
    {
        transform.position = scbearscript.position; + 2* Vector3 up + 3 * scbearscript transform, :forward;
        rb.velocity = 10 * (2 *Vector3.up );
    }
}