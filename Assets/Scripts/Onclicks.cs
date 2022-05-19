using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Onclicks: MonoBehaviour
{
    public Button upButton;
    public GameObject player;
    Rigidbody rb;
    public GameObject prefab;
    public Transform bulletlauncher;
    public float speed;
    public bool isShooting = false;
    
    // Start is called before the first frame update
    void Start()
    {
        upButton.onClick.AddListener(Move);
      
       

    }

    // Update is called once per frame
    void Update()
    {
      
    }
    public void Move()
    {
        if (isShooting == true)
        {

            Debug.Log("Shoot");
            GameObject prefab= PoolManager.Instance.Spawn(Constants.BULLET_PREFAB_NAME);

            prefab.GetComponent<BulletMovement>().SetPosition(bulletlauncher.position);
            prefab.GetComponent<BulletMovement>().SetTrajectory(prefab.transform.position + transform.forward);



           // PlayerAudioSource.instance.ShotFire();
           // GameObject effect = Instantiate(prefab, bulletlauncher.transform.position, Quaternion.identity);//Particle effect while shooting.
           // Destroy(effect, 1f);




        }
    }
    public void OnPointerDown()
    {
        isShooting = true;
       
        Move();
    }
    public void OnPointerUp()
    {
        isShooting = false;
    }
    
}
