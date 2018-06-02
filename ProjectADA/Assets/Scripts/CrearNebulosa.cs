using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrearNebulosa : MonoBehaviour {

	public Vector3 Offset;
	private GameObject nebulosaMover;
	private Vector3 screenPoint;
	
	// Use this for initialization
	public void inicializar () {
		Offset=new Vector3(-80f, 0.5f, 63f);
		GameObject construirNebulosa = ControladorCreacion.instance.getNebulosa();
		nebulosaMover = (GameObject) Instantiate(construirNebulosa,Offset,transform.rotation);
	}
}
