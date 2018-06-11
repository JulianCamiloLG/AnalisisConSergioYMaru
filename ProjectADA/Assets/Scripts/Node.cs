using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Node : MonoBehaviour {

	public Color hoverColor;
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
		if(ocupado){
			return;
		}
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
		CrearNebulosas();
	}

	public void CrearNebulosas(){
		ocupado=true;
		GameObject construirNebulosa = ControladorCreacion.instance.getNebulosa();
		nebulosa = (GameObject) Instantiate(construirNebulosa,transform.position+Offset,transform.rotation);
		GameObject nebulosas = GameObject.Find("Nebulosas");
		GameObject nebula = GameObject.Find("Nebulosa(Clone)");
		nebula.transform.parent=nebulosas.transform;
		nebula.name="Nebulosa";
		CrearNebulosa creacion= nebula.GetComponent(typeof(CrearNebulosa)) as CrearNebulosa;
		creacion.reCrear();
	}
}
