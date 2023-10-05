using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class snowballcontorlsc : MonoBehaviour
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
    private void OnCollisionEnter(Collision collision)
    {
        print("Ouch");

        dealwithhits thingIHit = collision.gameObject.GetComponent<dealwithhits>();
        if (thingIHit != null)
        {
            thingIHit.IHitYou();
        }
    }
    internal void ImThrowingYou(scbearscript scbearscript)
    {
        transform.position = scbearscript.transform.position + 2 *Vector3.up + 3 * scbearscript.transform.forward;
        rb = GetComponent<Rigidbody>();
        rb.velocity = 10 * (2 *Vector3.up + 3 * scbearscript.transform. forward );
    }
}