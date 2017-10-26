using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hitcheck : MonoBehaviour {
	public Transform note;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (note.position.z < transform.position.z + 1 && note.position.z > transform.position.z - 1) {
			Debug.Log ("hit");
		} else if (note.position.z < transform.position.z - 1 && note.position.z > transform.position.z - 2) {
			Debug.Log ("miss");
		}
	}

	void OnTriggerStay(){
		Debug.Log ("inside");
	}
}
