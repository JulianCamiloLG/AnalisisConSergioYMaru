using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoverNebulosa : MonoBehaviour {

	void OnTriggerEnter(Collider colision){
		print(colision.name);
		if(colision.name=="Sphere(Clone)"){
			Destroy(this);
		}
	}

}
