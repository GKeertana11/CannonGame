using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BulletMovement : MonoBehaviour
{

    #region PUBLIC VARIABLES
    // The bullet's speed in Unity units.
    public float speed;
    Rigidbody rb;
    public Transform target;
    public GameObject particle;
    public GameObject goblin;
    #endregion

    #region PRIVATE VARIABLES
    private Camera mainCamera;
    #endregion
   // public float speed;
   // Rigidbody rb;
    CannonMovement Cannon;
    public GameObject Player;
    ScoreManager scoreManager;
    ScoreManager score;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        Cannon = GameObject.Find("Player").GetComponent<CannonMovement>();
        scoreManager = GameObject.Find("Player").GetComponent<ScoreManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Cannon.istrue == false && scoreManager.isWon==false)
        {
            Vector3 newPosition = transform.position -transform.forward; //need to change again.
          
            transform.position = newPosition;
            rb.velocity = Vector3.back * speed * Time.deltaTime;

            
           // rb.AddForce(Vector3.back * speed * Time.deltaTime);
        }
       
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (Cannon.istrue == false && scoreManager.isWon==false)
        {
            if (collision.gameObject.tag == "Goblin")
            {
                particle = Instantiate(particle, collision.gameObject.transform.position+new Vector3(0f,6f,0f), Quaternion.identity);
                // Destroy(collision.gameObject);
                 PoolManager.Instance.Recycle(Constants.ENEMY_PREFAB_NAME,collision.gameObject);
                PoolManager.Instance.Recycle(Constants.BULLET_PREFAB_NAME, this.gameObject);
                Destroy(particle, 2f);
                scoreManager.Score(10);

                
            }
        }

    }
    public void SetPosition(Vector3 position)
    {
        transform.position = position;
    }

    // Set the tragectory of the bullet.
    public void SetTrajectory(Vector3 target)
    {
        transform.LookAt(target, Vector3.back);

    }
}
