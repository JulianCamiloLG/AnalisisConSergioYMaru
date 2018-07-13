using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CrearNebulosa : MonoBehaviour {


	private  bool arreglada;
	private GameObject nebulosaMover;
	
	void Start(){
		arreglada=true;
		GetComponent<Galaxia.Galaxy>().GPU=false;
		StartCoroutine (volverFalso ());
		Collider clider=GetComponent<Collider>();
		clider.enabled=true;
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

	IEnumerator volverFalso(){
		GetComponent<Renderer>().enabled=false;
		yield return new WaitForSeconds (0.1f);
		arreglada=false;
	}

}
