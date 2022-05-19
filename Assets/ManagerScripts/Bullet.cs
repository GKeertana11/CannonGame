using UnityEngine;
using System.Collections;

// Class for bullet objects.
public class Bullet : MonoBehaviour
{

	#region PUBLIC VARIABLES
	// The bullet's speed in Unity units.
	public float speed = 7f;
	Rigidbody rb;
	public Transform target;
	#endregion

	#region PRIVATE VARIABLES
	private Camera mainCamera;
	#endregion

	#region MONOBEHAVIOUR METHODS
	void Start()
	{
		rb = GetComponent<Rigidbody>();
		mainCamera = Camera.main;
	}

	void Update()
	{
		Vector3 newPosition = transform.position + transform.forward * speed * Time.deltaTime; //need to change again.
		newPosition.z = transform.position.z;
		//rb.AddForce(newPosition);
       transform.position = newPosition;

		
	}
	#endregion

	#region PUBLIC METHODS
	// Set the position of the bullet.
	public void SetPosition(Vector3 position)
	{
		transform.position = position;
	}

	// Set the tragectory of the bullet.
	public void SetTrajectory(Vector3 target)
	{
		transform.LookAt(target, Vector3.forward);
	
	}
	
	#endregion



}