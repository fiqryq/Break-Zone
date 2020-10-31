using UnityEngine;
using System.Collections;

public class BrakeZone : MonoBehaviour {

	// Use this for initialization
	public float targetSpeed = 14f;

	float orginalSpeed;

	void OnTriggerEnter(Collider col)
	{

		if (col.CompareTag ("Player")) {
			orginalSpeed = col.GetComponent<NavMeshAgent> ().speed;
			col.GetComponent<NavMeshAgent> ().speed = targetSpeed;
		}
		
	}

	void OnTriggerExit(Collider col)
	{

		if(col.CompareTag("Player"))
			col.GetComponent<NavMeshAgent> ().speed = orginalSpeed;
	}
}
