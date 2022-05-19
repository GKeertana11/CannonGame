using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnSAstroid : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnAsteroids());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private IEnumerator SpawnAsteroids()
    {
        while (true)
        {
            

            yield return new WaitForSeconds(Random.Range(2f,5f));
            SpawnAsteroid();
        }
    }
    private void SpawnAsteroid()
    {
        PoolManager.Instance.Spawn(Constants.ENEMY_PREFAB_NAME);
      //  PoolManager.Instance.Spawn(Constants.BROWNBRICK_PREFAB_NAME);
    }
}
