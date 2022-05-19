using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    public float time;
    public GameObject Goblin;
    CannonMovement Cannon;
    ScoreManager scoreManager;
   
    // Start is called before the first frame update
    void Start()
    {
        Cannon = GameObject.Find("Player").GetComponent<CannonMovement>();
        scoreManager = GameObject.Find("Player").GetComponent<ScoreManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Cannon.istrue == false && scoreManager.isWon==false)
        {
            time = time + Time.deltaTime;
            float x = Random.Range(398f, -398f);
            float z = Random.Range(-693f, 75f);
            time = time + Time.deltaTime;




            if (time >= 6.0f)
            {


                Instantiate(Goblin, new Vector3(x, 0, z), Quaternion.identity);
                time = 0;



            }
        }
        
    }
}
