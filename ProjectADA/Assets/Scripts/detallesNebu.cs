using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class detallesNebu : MonoBehaviour {


	private GameObject label;
	public string nombre;

	// Use this for initialization
	void Start () {
		nombre="SergioMonsalve";
		cambiarNombre();
	}


	void OnMouseDown(){
		print("clickee");
	}
	void OnMouseEnter(){
		label=GameObject.Find("labelnebu");
		//label.GetComponent<Text>().text=nombre;
		label.transform.position=transform.position;
		label.transform.rotation=transform.rotation;
		print(Camera.main.WorldToViewportPoint(label.transform.position));
	}
	void OnMouseExit(){
		//label.GetComponent<Text>().text="";
		label.transform.position=new Vector3(0,0,0);
	}


	public void cambiarNombre(){
		
	}
}
