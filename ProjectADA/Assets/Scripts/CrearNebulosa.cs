using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CrearNebulosa : MonoBehaviour {

	public  bool arreglada;
	private GameObject nebulosaMover;
	private Vector3 screenPoint;
	private string nombre;

	void Start(){
		nombre="Ingrese el nombre de la nebulosa";
		arreglada=true;
		GetComponent<Galaxia.Galaxy>().GPU=false;
		StartCoroutine (volverFalso ());
		//GetComponent<Collider>().enable=true;
	}

	void Update(){
		if(!arreglada){
			GameObject particula = GameObject.Find("Shuriken Renderer");
			if(particula != null){
				particula.name="Particulas";
				particula.transform.position= new Vector3(transform.position.x,transform.position.y+2,transform.position.z);
				particula.transform.localScale= new Vector3(25,2,25);
				particula.transform.parent=transform;
			}
			else{
				arreglada=true;
			}
		}
	}

	void OnMouseDown(){
		print("clickee");
	}
	void OnMouseEnter(){
		print("entre");
	}

	IEnumerator volverFalso(){
		GetComponent<Renderer>().enabled=false;
		yield return new WaitForSeconds (0.1f);
		arreglada=false;
	}

}
