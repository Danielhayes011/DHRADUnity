using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SocialPlatforms;

[DebuggerDisplay("{" + nameof(DebuggerDisplayAttribute) + "(),nq}")]
public class scbearscript : MonoBehaviour
{
    public GameObject snowballCloneTemplate;
    Transform tr;
    Rigidbody rb;
    private float currentspeed;
    private readonly float walkingspeed = 2;
    private float runspeed = 4;
    private float turningspeed = 100;
    Animator myAnimator;
    private object deltaTime;


    // Start is called before the first frame update
    void Start()
    {
        tr = GetComponent<Transform>();
        rb = GetComponent<Rigidbody>();
        myAnimator = GetComponent<Animator>();
        currentspeed = walkingspeed;
    }

    // Update is called once per frame
    void Update()
    {

        myAnimator.SetBool("isRun", false);

        if (Input.GetKey(KeyCode.W))

            // rb Addforce(tr.forward);
            tr.position += currentspeed * tr.forward * Time.deltaTime;
        myAnimator.SetBool("isRun", true);
      //  tr.position -= currentspeed * tr.forward * Time.deltaTime;
        if (Input.GetKey(KeyCode.A))

            transform.Rotate(Vector3.up, turningspeed * Time.deltaTime);

        if (Input.GetMouseButton(0))
        {
            GameObject nergo = Instantiate( snowballCloneTemplate);


            snowballcontorlsc mySnowball = nergo.GetComponent<snowballcontorlsc>();

            mySnowball.ImThrowingYou(this);
        } }
    


   



}
