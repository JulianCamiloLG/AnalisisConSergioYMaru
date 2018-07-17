using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrearMapa : MonoBehaviour {

	public GameObject terreno;
	public GameObject botonTerminar;
	public GameObject botonPlanetas;
	public GameObject botonNebulosas;
	public GameObject botonSimular;
	public GameObject botonBorrar;
	public GameObject terrenoplanetas;
	public GameObject botonTerminarPlanetas;
	public GameObject nodosPlaneta;
	private Vector3 nodosPos;
	private int numeroNebu=0;
	private Vector3 posCamera;
	
	void Start(){
		posCamera=Camera.main.transform.position;
		nodosPos=nodosPlaneta.transform.position;
	}

	void Update(){
		GameObject nebu=GameObject.Find("Nebulosa");
		if(nebu!=null){
			nebu.name=nebu.name+" "+numeroNebu;
			numeroNebu++;
		}
	}

	public void CrearNebulosas(){
		terreno.SetActive(true);
		botonTerminar.SetActive(true);

		botonPlanetas.SetActive(false);
		botonNebulosas.SetActive(false);
		botonSimular.SetActive(false);
		botonBorrar.SetActive(false);
		terrenoplanetas.SetActive(false);
	}

	public void TerminarNebulosas(){
		terreno.SetActive(false);
		terrenoplanetas.SetActive(true);
		botonTerminar.SetActive(false);

		botonPlanetas.SetActive(true);
		botonNebulosas.SetActive(true);
		botonSimular.SetActive(true);
		botonBorrar.SetActive(true);
	}
	public void CrearPlanetas(){
		botonTerminarPlanetas.SetActive(true);

		botonPlanetas.SetActive(false);
		botonNebulosas.SetActive(false);
		botonSimular.SetActive(false);
		botonBorrar.SetActive(false);

	}
	public void terminarPlanetas(){
		Camera.main.transform.position=posCamera;
		nodosPlaneta.transform.position=nodosPos;
		botonTerminarPlanetas.SetActive(false);

		botonPlanetas.SetActive(true);
		botonNebulosas.SetActive(true);
		botonSimular.SetActive(true);
		botonBorrar.SetActive(true);

	}
}
