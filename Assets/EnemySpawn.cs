using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    public float time;
    public GameObject Goblin;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        time = time + Time.deltaTime;
        float x = Random.Range(8.6f, 163.0f);
        float z= Random.Range(-170.0f, -150.0f);
        time = time + Time.deltaTime;
        if (time >= 6.0f)
        {

            Instantiate(Goblin, new Vector3(x, 0, z), Quaternion.identity);
            time = 0;

        }
    }
}
