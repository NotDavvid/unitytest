using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class notestofire : MonoBehaviour {
	//public Transform tile;
	public Transform prefab;
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKey("q")){
			Transform gameObject = Instantiate(prefab, transform.position, transform.rotation);
			Rigidbody bullet = gameObject.GetComponent<Rigidbody>();
			bullet.velocity = transform.TransformDirection(new Vector3(0,0,-1) * 10);
		}
	}
}
