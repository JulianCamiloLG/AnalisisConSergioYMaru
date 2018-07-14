using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class listaPlanetas : MonoBehaviour {

	public GameObject[] planetas;
	public static listaPlanetas instance;
	int cantsistemas;
	// Use this for initialization
	void Start () {
		cantsistemas=0;
	}

	void Awake(){
		if(instance!=null){
			Debug.LogError("Mas de un controlador creado");
			return;
		}
		instance=this;
	}
	
	public void crearPlanetas(int cantidadPlanetas, string nebulosa){
		GameObject instance=GameObject.Find("sistemasPlanetarios");
		GameObject nebulosaAcrear=GameObject.Find(nebulosa);
		GameObject sistemaplaneta = (GameObject) Instantiate(instance,transform.position,transform.rotation);
		sistemaplaneta.transform.parent=nebulosaAcrear.transform;
		sistemaplaneta.name=sistemaplaneta.name+" "+cantsistemas;
		cantsistemas++;
	}
}
