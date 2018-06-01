using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Node : MonoBehaviour {

	private bool colored;
	// Use this for initialization
	void Start () {
			colored=false;
			StartCoroutine(parpadear());
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	IEnumerator parpadear(){
		yield return new WaitForSeconds(1);
		if(!colored){
			GetComponent<Renderer>().material.color=Color.cyan;
			colored=true;
		}
		else{
			GetComponent<Renderer>().material.color=Color.white;
			colored=false;
		}
	}

}
