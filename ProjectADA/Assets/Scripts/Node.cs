using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Node : MonoBehaviour {

	public Color hoverColor;
	public Color nodoOcupado;
	public Vector3 Offset;
	private Renderer rend;
	private Color startColor;
	private GameObject nebulosa;
	private GameObject nebulosaMostrar;
	private bool ocupado;
	private bool creado;


	void Start(){
		rend=GetComponent<Renderer>();
		startColor=rend.material.color;
		ocupado=false;
		creado=false;
	}


	void OnMouseEnter(){
		rend.material.color=hoverColor;
		GameObject construirNebulosa = ControladorCreacion.instance.getNebulosa();
		nebulosaMostrar = (GameObject) Instantiate(construirNebulosa,transform.position+Offset,transform.rotation);
		creado=true;
	}

	void OnMouseExit(){
		rend.material.color=startColor;
		if(creado){
			Destroy(nebulosaMostrar);
		}
	}

	void OnMouseDown(){
		if(ocupado){
			Debug.Log("No se puede construir ahi - TODO: Display on screen.");
			return;
		}
		GameObject construirNebulosa = ControladorCreacion.instance.getNebulosa();
		nebulosa = (GameObject) Instantiate(construirNebulosa,transform.position+Offset,transform.rotation);
		ocupado=true;
	}

}
