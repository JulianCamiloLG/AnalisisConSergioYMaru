using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CrearNebulosa : MonoBehaviour {

	public bool creada;
	private GameObject nebulosaMover;
	private Vector3 screenPoint;
	private string nombre;
	private bool movido;
	private int contador;

	void Start(){
		nombre="Ingrese el nombre de la nebulosa";
		creada=false;
		movido=false;
		GetComponent<Galaxia.Galaxy>().GPU=false;
		print(GetComponent<CrearNebulosa>().creada);
		contador=0;
	}

	void Update(){
		GameObject shuriken= GameObject.Find("Shuriken Renderer");
		print(creada);
		if(shuriken!=null && creada){
			contador+=1;
			print(contador);
			GetComponent<Renderer>().enabled=false;
			shuriken.name="Particulas";
			shuriken.transform.position= new Vector3(transform.position.x,transform.position.y+2,transform.position.z);
			shuriken.transform.localScale= new Vector3(25,1,25);
			shuriken.transform.parent=transform;
			movido=true;
		}
		else{
			creada=false;
		}
	}

	void OnMouseDown(){
		print("clickee");
	}
	public void reCrear(){
		creada=true;
	}
}
