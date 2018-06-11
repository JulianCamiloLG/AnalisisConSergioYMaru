using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrearMapa : MonoBehaviour {

	public GameObject terreno;
	
	public void CrearNebulosas(){
		terreno.SetActive(true);
	}

	public void TerminarNebulosas(){
		terreno.SetActive(false);
	}
}
