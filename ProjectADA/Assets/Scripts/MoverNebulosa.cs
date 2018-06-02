using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoverNebulosa : MonoBehaviour {

	public Color seleccionado;
	private bool mover;
	private Renderer rend;
	private Color startColor;
	private GameObject nebulosa;
	private Vector3 nuevaPosicion;

	void Start(){
		rend=GetComponent<Renderer>();
		startColor=rend.material.color;
		mover=false;
	}

	void FixedUpdate(){
		if(mover){
			transform.position=transform.position-nuevaPosicion;
		}
	}

	void OnMouseEnter(){
		rend.material.color=seleccionado;
	}
	void OnMouseLeave(){
		rend.material.color=startColor;
	}

	void OnMouseDrag(){
		Vector3 screenPoint = Camera.main.WorldToScreenPoint(gameObject.transform.position);
		nuevaPosicion=screenPoint;
		print(screenPoint);
		mover=true;
	}

	void OnMouseUp(){
		mover=false;
	}
}
