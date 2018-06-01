using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Node : MonoBehaviour {

	private bool colored;
	private bool creandoNebulosas;
	public GameObject node;
	// Use this for initialization
	void Start(){
		creandoNebulosas=false;
		colored=false;
	}

	void Update(){
		if(creandoNebulosas){
			if(Time.fixedTime%.5<.2){
				node.GetComponent<Renderer>().sharedMaterial.color=Color.cyan;
			}
			else{
				node.GetComponent<Renderer>().sharedMaterial.color=Color.white;
			}
		}
	}

	public void parpadear(){
		creandoNebulosas=true;
	}
}
