using UnityEngine;
using System.Collections;

public class Steps : MonoBehaviour {
	
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		
		if(Input.GetAxis ("Horizontal") != 0 || Input.GetAxis("Vertical") != 0){
			this.GetComponent<SECTR_PointSource>().Play();
		}
	}
}