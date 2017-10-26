using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class notestofire : MonoBehaviour {
	//public Transform tile;
	public Transform prefab;
	public Transform target;

	void Start(){
		transform.rotation =  Quaternion.LookRotation(target.position - transform.position);
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKey("q")){
			Transform gameObject = Instantiate(prefab, transform.position, transform.rotation);
			Rigidbody bullet = gameObject.GetComponent<Rigidbody>();
			bullet.velocity = transform.TransformDirection(Vector3.forward * 10);
			//bullet.isKinematic = true;
		}
	}
}
