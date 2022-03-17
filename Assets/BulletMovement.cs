using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMovement : MonoBehaviour
{
    public float speed;
    Rigidbody rb;
    CannonMovement Cannon;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        Cannon = GameObject.Find("Player").GetComponent<CannonMovement>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Cannon.istrue == false)
        {
            rb.velocity = new Vector3(0, 0, transform.position.z * speed * Time.deltaTime);
        }
       
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (Cannon.istrue == false)
        {
            if (collision.gameObject.tag == "Goblin")
            {
                Destroy(collision.gameObject);
            }
        }

    }
}
