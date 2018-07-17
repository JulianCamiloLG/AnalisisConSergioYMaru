using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class listaPlanetas : MonoBehaviour {

	public GameObject[] planetas;
	public GameObject[] mejoras;
	public static listaPlanetas instance;
	int cantsistemas;
	// Use this for initialization
	void Start () {
		cantsistemas=0;
	}

	void Awake(){
		if(instance!=null){
			Debug.LogError("Mas de un controlador creado");
			return;
		}
		instance=this;
	}
	
	public void crearSistemas(string nebulosa){
		//print("entre a crear planeta");
		GameObject nebulosaAcrear=GameObject.Find(nebulosa);
		Camera.main.transform.position=new Vector3(nebulosaAcrear.transform.position.x,nebulosaAcrear.transform.position.y+8.0f,nebulosaAcrear.transform.position.z);
		GameObject terrenos=GameObject.Find("TerrenosPlaneta");
		//terrenos.transform.position=new Vector3(nebulosaAcrear.transform.position.x-8.0f,nebulosaAcrear.transform.position.y,nebulosaAcrear.transform.position.z+7.0f);
		crearPlanetas(5,nebulosaAcrear,terrenos);
	}
	public void crearPlanetas(int cantidadPlanetas,GameObject nebulosaAcrear, GameObject terreno){
		GameObject instance=GameObject.Find("sistemasPlanetarios");
		GameObject sistemaplaneta = (GameObject) Instantiate(instance,nebulosaAcrear.transform.position,nebulosaAcrear.transform.rotation);
		sistemaplaneta.transform.parent=nebulosaAcrear.transform;
		sistemaplaneta.name="Sistema "+cantsistemas;
		cantsistemas++;
		ponerPlanetas(cantidadPlanetas,nebulosaAcrear,sistemaplaneta);
	}
	public void ponerPlanetas(int cantidadPlanetas, GameObject nebulosaAcrear, GameObject sistemaplaneta){
		for(int i=0;i<cantidadPlanetas;i++){
			int numplaneta=Random.Range(0, 15);
			GameObject planeta = (GameObject) Instantiate(planetas[numplaneta],nebulosaAcrear.transform.position,nebulosaAcrear.transform.rotation);
			float offsetX=Random.Range(-5.0f, 5.0f);
			float offsetZ=Random.Range(-5.0f, 5.0f);
			planeta.transform.parent=sistemaplaneta.transform;
			planeta.AddComponent(typeof(Planeta));
			planeta.name=nebulosaAcrear.name+" Planeta "+i;
			planeta.transform.position=new Vector3(sistemaplaneta.transform.position.x+offsetX, sistemaplaneta.transform.position.y+3.0f, sistemaplaneta.transform.position.z+offsetZ);
			planeta.transform.localScale-= new Vector3(0.98f, 0.98f, 0.98f);
		}
	}
}
