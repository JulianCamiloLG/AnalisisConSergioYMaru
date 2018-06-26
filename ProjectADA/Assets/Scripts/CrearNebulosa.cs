using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CrearNebulosa : MonoBehaviour {

	public  bool creada;
	private GameObject nebulosaMover;
	private Vector3 screenPoint;
	private string nombre;

	void Start(){
		nombre="Ingrese el nombre de la nebulosa";
		creada=true;
		GetComponent<Galaxia.Galaxy>().GPU=false;
		print(GetComponent<CrearNebulosa>().creada);
	}

	void Update(){
		
	}

	void OnMouseDown(){
		print("clickee");
	}

	public void particulas(){
		creada=true;
	}

}
