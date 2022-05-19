using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CannonMovement : MonoBehaviour
{
    #region PUBLIC VARIABLES
    public float speed;
    Vector3 movement;
    public GameObject bullet;
    public Vector3 offset;
    public int lives;
    public Text live;
    public Text gameOver;
    public bool istrue;
    Rigidbody rb;
    ScoreManager scoreManager;
    public int count;
    public GameObject player;
    public Text invaded;
    #endregion

    #region PRIVATE VARIABLES
    private Vector3 _touchPosition;
    private Rigidbody _rb;
    private Vector3 _direction;
    private float _moveSpeed = 10f;
    #endregion

    #region MONOBEHAVIOUR METHODS
    // Start is called before the first frame update
    void Start()
    {
        istrue = false;
        lives = 3;
        _rb = GetComponent<Rigidbody>();
        scoreManager = GetComponent<ScoreManager>();



    }


    // Update is called once per frame
    void Update()
    {
        /* if (istrue == false && scoreManager.isWon==false)
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

             }*/

        /* if (Input.touchCount > 0)
         {
             Touch touch = Input.GetTouch(0);
             _touchPosition = Camera.main.ScreenToWorldPoint(touch.position);
             _touchPosition.z = 0;
             _direction = (_touchPosition - transform.position);
             _rb.velocity = new Vector2(_direction.x, _direction.y) * _moveSpeed;
             if (touch.phase == TouchPhase.Ended)
             {
                 _rb.velocity = Vector2.zero;
             }
         }*/
        if(Input.touchCount==0)
        {
            player.transform.Translate(0f,0f,0f);
        }
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Stationary)
        {
            Vector2 touchPosition = Input.GetTouch(0).position;
            double halfScreen = Screen.width / 2.0;

            //Check if it is left or right?
            if (touchPosition.x < halfScreen)
            {
                player.transform.Translate(Vector3.left * 50 * Time.deltaTime);
            }
            else if (touchPosition.x > halfScreen)
            {
                player.transform.Translate(Vector3.right * 50 * Time.deltaTime);
            }

        }
    }
    #endregion
    private void OnCollisionEnter(Collision collision)
    {
        if (istrue == false && scoreManager.isWon == false)
        {
            if (collision.gameObject.tag == "Goblin")
            {
                lives = lives - 1;
                live.text = lives.ToString();
                if (lives == 0)
                {
                    gameOver.GetComponent<Text>().enabled = true;
                    invaded.GetComponent<Text>().enabled = true;
                    istrue = true;
                    rb.constraints = RigidbodyConstraints.FreezeAll;
                }

            }
        }

    }
}



