using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CrearNebulosa : MonoBehaviour {

	public Vector3 Offset;
	private GameObject nebulosaMover;
	private Vector3 screenPoint;
	private string nombre;
	private bool creada;
	private float posicionActualX;
	private float posicionActualY;
	void Start(){
		nombre="Ingrese el nombre de la nebulosa";
		creada=false;
		posicionActualY=0;
		posicionActualX=0;

	}

	void OnGUI(){
		if(creada){
			nombre=GUI.TextField(new Rect(posicionActualX,posicionActualY+20,200,20), nombre,25);
			if(GUI.Button(new Rect(posicionActualX,posicionActualY,200,20),"Aceptar")){
				print("creada la nebulosa: "+nombre);
				GUI.Label(new Rect(posicionActualX,posicionActualY+40,200,30), nombre);

			}
		}
	}

	void OnMouseDown(){
		creada=true;
		posicionActualX=Input.mousePosition.x;
		posicionActualY=Input.mousePosition.y;
	}

	// Use this for initialization
	public void inicializar () {
		Offset=new Vector3(-80f, 0.5f, 63f);
		GameObject construirNebulosa = ControladorCreacion.instance.getNebulosa();
		nebulosaMover = (GameObject) Instantiate(construirNebulosa,Offset,transform.rotation);
	}
}
