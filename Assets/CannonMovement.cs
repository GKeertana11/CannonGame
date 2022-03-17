using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonMovement : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed;
    Vector3 movement;
    public GameObject bullet;
    public Vector3 offset;

    void Start()
    { }
    

    // Update is called once per frame
    void Update()
    {
     if(Input.GetKeyDown(KeyCode.RightArrow))
        {
            transform.Translate(Vector3.left*speed*Time.deltaTime);
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            transform.Translate(Vector3.right * speed * Time.deltaTime);
        }
    
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(bullet, transform.position+offset, Quaternion.identity);
            
        }
       

    }
}
