using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemeyMovement : MonoBehaviour
{
    public float speed;
    CannonMovement Cannon;
    ScoreManager scoreManager;
    Rigidbody rb;
    public float goblincount;


    // Start is called before the first frame update
    void Start()
    {
        Cannon = GameObject.Find("Player").GetComponent<CannonMovement>();
        scoreManager = GameObject.Find("Player").GetComponent<ScoreManager>();
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Cannon.istrue == false && scoreManager.isWon==false)
        {
            transform.Translate(0, 0, speed);

            if(transform.position.z>=-71)
            {
                goblincount = goblincount + 1;
                
            }
        }
        if(Cannon.istrue==true)
        {

            GetComponent<Animator>().enabled = false;
            rb.constraints = RigidbodyConstraints.FreezeAll;
        }

    }
}
