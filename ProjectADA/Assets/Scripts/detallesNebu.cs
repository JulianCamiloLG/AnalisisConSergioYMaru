using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class detallesNebu : MonoBehaviour {

	private GameObject label;
	private string nombre;
	private string [] nombres;

	// Use this for initialization
	void Start () {
		nombre="SergioMonsalve";
		//cambiarNombre();
		nombres=new string[4] {"Sergio","Andres","Cardona","Castro"};
		//cambiarNombre();
	}


	void OnMouseDown(){
		print("clickee");
	}
	void OnMouseEnter(){
		label=GameObject.Find("labelnebu");
		nombre=nombres[Random.Range(0,3)];
		label.GetComponent<TextMesh>().text=nombre;
		label.transform.position=transform.position;
		label.transform.localRotation= Quaternion.Euler(90f,0,0);
		//print(Camera.main.WorldToViewportPoint(label.transform.position));
	}
	void OnMouseExit(){
		//label.GetComponent<Text>().text="";
		label.transform.position=new Vector3(0,0,0);
	}



}
