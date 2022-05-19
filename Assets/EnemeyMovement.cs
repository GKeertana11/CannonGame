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
    public float time ;
    public float time1;

   


    // Start is called before the first frame update
    void Start()
    {
        Cannon = GameObject.Find("Player").GetComponent<CannonMovement>();
        scoreManager = GameObject.Find("Player").GetComponent<ScoreManager>();
        rb = GetComponent<Rigidbody>();
        time1 = 2.0f;
    }

    // Update is called once per frame
    void Update()
    {
        if (Cannon.istrue == false && scoreManager.isWon==false)
        {
          //  time = time + Time.deltaTime;
         
         
           if(time>=time1)
            {

                transform.Translate(speed, 0, 0);
                time1 += 2f;
            }
            
                transform.Translate(0, 0, speed);
              
            


        }
        if(Cannon.istrue==true)
        {

            GetComponent<Animator>().enabled = false;
            rb.constraints = RigidbodyConstraints.FreezeAll;
        }

    }
}
