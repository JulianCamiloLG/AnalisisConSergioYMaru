using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class detallesNebu : MonoBehaviour {


	public GameObject label;
	private string nombre;

	// Use this for initialization
	void Start () {
		nombre="SergioMonsalve";
		//cambiarNombre();
	}


	void OnMouseDown(){
		print("clickee");
	}
	void OnMouseEnter(){
		label.GetComponent<Text>().text=nombre;
		label.transform.position=transform.position;
		label.SetActive(true);
	}
	void OnMouseExit(){
		label.GetComponent<Text>().text="";
		//label.text="";
		label.SetActive(false);
	}


	public void cambiarNombre(){
	}
}
