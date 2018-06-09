using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CrearNebulosa : MonoBehaviour {

	public Vector3 Offset;
	private GameObject nebulosaMover;
	private Vector3 screenPoint;
	private string nombre;
	public bool creada;
	private bool movido;

	void Start(){
		nombre="Ingrese el nombre de la nebulosa";
		creada=false;
		movido=false;
		GetComponent<Galaxia.Galaxy>().GPU=false;
	}

	void Update(){
		GameObject shuriken= GameObject.Find("Shuriken Renderer");
		if(shuriken!=null && creada){
			GetComponent<Renderer>().enabled=false;
			shuriken.name="Particulas";
			shuriken.transform.position=transform.position;
			shuriken.transform.localScale=transform.localScale;
			shuriken.transform.parent=transform;
			movido=true;
		}
	}

	void OnMouseDown(){
		print("clickee");
	}

	// Use this for initialization
	public void inicializar () {
		Offset=new Vector3(-80f, 0.5f, 63f);
		GameObject construirNebulosa = ControladorCreacion.instance.getNebulosa();
		nebulosaMover = (GameObject) Instantiate(construirNebulosa,Offset,transform.rotation);
	}
}
