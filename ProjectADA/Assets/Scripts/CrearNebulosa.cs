using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CrearNebulosa : MonoBehaviour {

	private bool arreglada;
	private GameObject nebulosaMover;
	private GameObject label;
	public string nombre;
	public bool tieneEstacion;
	Vector3 originalPos;
	int click;
	float tiempoclicks;
	float tiempomax;
	float delay;
	//jagged
	static int[] materiales;
	static int[] planeta;
	static int[] sistemaSolar;
	int[][] nebulosa = { sistemaSolar,planeta,materiales };
	

	
	void Start(){
		arreglada=true;
		GetComponent<Galaxia.Galaxy>().GPU=false;
		StartCoroutine (volverFalso ());
		Collider clider=GetComponent<Collider>();
		clider.enabled=true;
		nombre="";
		label=GameObject.Find("labelnebu");
		originalPos=label.transform.position;
		click=0;
		delay=0.3f;
		//cambiarNombre();
		materiales = new int[4];
		//planeta = { 1 };
		//sistemaSolar = { 2 };
	}

	void Update(){
		if(!arreglada){
			GameObject particula = GameObject.Find("Shuriken Renderer");
			if(particula != null){
				particula.name="Particulas";
				particula.transform.position= new Vector3(transform.position.x,transform.position.y+2,transform.position.z);
				particula.transform.localScale= new Vector3(25,2,25);
				particula.transform.parent=transform;
			}
			else{
				arreglada=true;
			}
		}
	}

	IEnumerator volverFalso(){
		GetComponent<Renderer>().enabled=false;
		yield return new WaitForSeconds (0.1f);
		arreglada=false;
	}

	public void cambiarNombre(){
		GameObject texto=GameObject.Find("nombreNebu");
		GameObject boton=GameObject.Find("aceptarNombreNebu");
		Vector3 origenTexto=texto.transform.position;
		Vector3 origenBoton=boton.transform.position;
		Vector3 posicionNebu=Camera.main.WorldToScreenPoint(transform.position);
		texto.transform.position=new Vector3(posicionNebu.x+20,posicionNebu.y);
		boton.transform.position=new Vector3(posicionNebu.x+20,posicionNebu.y-25);
		boton.GetComponent<Button>().onClick.AddListener(delegate {changeName(texto,boton,origenBoton,origenTexto);});
	}
	public void changeName(GameObject texto,GameObject boton, Vector3 origenBoton, Vector3 origenTexto){
		if(texto.GetComponent<InputField>().text!=""){
			string nombresito=texto.GetComponent<InputField>().text;
			texto.transform.position=origenTexto;
			boton.transform.position=origenBoton;
			//texto.GetComponent<InputField>().text="";
		}
	}

	void OnMouseDown(){
		click++;
		tiempoclicks=Time.time;
		if(click%2==0){
			if((Time.time-tiempoclicks)<delay){
				listaPlanetas.instance.crearSistemas(name);
			}
		}
	}
	void OnMouseEnter(){
		label.GetComponent<TextMesh>().text=name;
		label.transform.position=transform.position;
		label.transform.localRotation= Quaternion.Euler(90f,0,0);
	}
	void OnMouseExit(){
		label.transform.position=originalPos;
	}
}
