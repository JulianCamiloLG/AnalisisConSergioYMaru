using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nebuObserver : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		GameObject nebulosas=GameObject.Find("Nebulosas");
		foreach(Transform nebulosa in nebulosas.transform){
			foreach(Transform componente in nebulosa.transform){
				print(componente.name);
			}
		}
	}
}
