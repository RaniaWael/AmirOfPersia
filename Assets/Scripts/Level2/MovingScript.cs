using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MovingScript : MonoBehaviour {
	//NavMeshAgent nav;
	public GameObject floor;

	// Use this for initialization
	void Start () {
		//nav = GetComponent <NavMeshAgent> ();
	}
	
	// Update is called once per frame
	void Update () {
		float z = Input.GetAxis("Vertical");
		float x = Input.GetAxis("Horizontal");
		gameObject.transform.Translate (0, 0, z);
		gameObject.transform.Rotate (0, x, 0);
		//nav.SetDestination (new Vector3(x, -floor.transform.position.y, z));
	}
}
