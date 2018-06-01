using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Simular : MonoBehaviour {

	public Camera main;
	public Camera second;
	public GameObject ui;
	public GameObject botones;

	void Start(){

	}

	public void iniciarSimulacion(){
		print("click");
		main.enabled=false;
		second.enabled=true;
		ui.SetActive(true);
		botones.SetActive(false);
	}
	
	
}
