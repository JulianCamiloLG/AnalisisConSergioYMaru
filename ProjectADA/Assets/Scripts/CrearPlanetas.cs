using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrearPlanetas : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void crearPlanetas(int cantidadPlanetas, string nebulosa){
		/*GameObject instance=GameObject.Find("sistemasPlanetarios");
		GameObject nebulosaAcrear=GameObject.Find(nebulosa);
		GameObject sistemaplaneta = (GameObject) Instantiate(instance,nebulosaAcrear.transform.position,nebulosaAcrear.transform.rotation);
		sistemaplaneta.transform.parent=nebulosaAcrear.transform;
		sistemaplaneta.name="Sistema planetario";
		for(int i=0;i<cantidadPlanetas;i++){
			int numplaneta=Random.Range(0, 16);
			GameObject planeta = (GameObject) Instantiate(planetas[numplaneta],nebulosaAcrear.transform.position,nebulosaAcrear.transform.rotation);
			planeta.transform.parent=sistemaplaneta.transform;
			planeta.name=nebulosaAcrear.name+" Planeta "+i;
			planeta.transform.localScale-= new Vector3(0.98f, 0.98f, 0.98f);
		}
	*/}
}
