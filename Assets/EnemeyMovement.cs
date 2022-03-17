using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemeyMovement : MonoBehaviour
{
    public float speed;
    CannonMovement Cannon;
    Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        Cannon = GameObject.Find("Player").GetComponent<CannonMovement>();
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Cannon.istrue == false)
        {
            transform.Translate(0, 0, speed);
        }
        if(Cannon.istrue==true)
        {

            GetComponent<Animator>().enabled = false;
            rb.constraints = RigidbodyConstraints.FreezeAll;
        }

    }
}
