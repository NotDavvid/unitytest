using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour {

	public Text text;
	public GameObject boss;
	// Use this for initialization
	void Start () {
		text.text = boss.GetComponent<FireNotes> ().health.ToString();
	}
	
	// Update is called once per frame
	void Update () {
		text.text = boss.GetComponent<FireNotes> ().health.ToString();
	}
}
