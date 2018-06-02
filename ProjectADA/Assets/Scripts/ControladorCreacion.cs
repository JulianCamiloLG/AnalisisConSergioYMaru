using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorCreacion : MonoBehaviour {

	public static ControladorCreacion instance;
	public GameObject nebulosaInicial;
	private GameObject nebulosaAConstruir;

	// Use this for initialization
	void Awake(){
		if(instance!=null){
			Debug.LogError("Mas de un controlador creado");
			return;
		}
		instance=this;
	}
	
	void Start(){
		nebulosaAConstruir=nebulosaInicial;
	}
	

	public GameObject getNebulosa(){
		return nebulosaAConstruir;
	}
}
