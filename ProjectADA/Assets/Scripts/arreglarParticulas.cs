using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class arreglarParticulas : MonoBehaviour {

	private GameObject nebulosa;
	private GameObject particula;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		nebulosa=GameObject.Find("Nebula");
		if(nebulosa != null){
			print("encontre nebulosa");
			particula = GameObject.Find("Shuriken Renderer");
			nebulosa.GetComponent<Renderer>().enabled=false;
			if(particula!=null){
				print("movi particula");
				particula.name="Particulas";
				particula.transform.position= new Vector3(nebulosa.transform.position.x,nebulosa.transform.position.y+2,nebulosa.transform.position.z);
				particula.transform.localScale= new Vector3(25,1,25);
				particula.transform.parent=nebulosa.transform;
			}
			else{
				nebulosa.name="Nebulosa";
			}
			
		}
	}
}
