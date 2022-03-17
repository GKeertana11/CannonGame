using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CannonMovement : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed;
    Vector3 movement;
    public GameObject bullet;
    public Vector3 offset;
    public int lives;
    public Text live;
    public Text gameOver;
    public bool istrue;
    Rigidbody rb;

    void Start()
    {
        istrue = false;
        lives = 3;
        rb = GetComponent<Rigidbody>();
    }
    

    // Update is called once per frame
    void Update()
    {
        if (istrue == false)
        {
            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                transform.Translate(Vector3.right * speed * Time.deltaTime);
            }
            if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                transform.Translate(Vector3.left * speed * Time.deltaTime);
            }

            if (Input.GetKeyDown(KeyCode.Space))
            {
                Instantiate(bullet, transform.position + offset, Quaternion.identity);

            }
        }
       

    }
    private void OnCollisionEnter(Collision collision)
    {
        if (istrue == false)
        {
            if (collision.gameObject.tag == "Goblin")
            {
                lives = lives - 1;
                live.text = lives.ToString();
                if (lives == 0)
                {
                    gameOver.GetComponent<Text>().enabled = true;
                    istrue = true;
                    rb.constraints = RigidbodyConstraints.FreezeAll;
                }

            }
        }
        
    }

}
