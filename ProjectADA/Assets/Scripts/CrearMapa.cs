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
	
	public void CrearNebulosas(){
		terreno.SetActive(true);
		botonTerminar.SetActive(true);

		botonPlanetas.SetActive(false);
		botonNebulosas.SetActive(false);
		botonSimular.SetActive(false);
		botonBorrar.SetActive(false);
	}

	public void TerminarNebulosas(){
		terreno.SetActive(false);
		botonTerminar.SetActive(false);

		botonPlanetas.SetActive(true);
		botonNebulosas.SetActive(true);
		botonSimular.SetActive(true);
		botonBorrar.SetActive(true);
	}
}
