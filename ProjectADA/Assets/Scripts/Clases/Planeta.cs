using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Planeta : MonoBehaviour {

	// Use this for initialization
	public int [] materiales;
	void Start () {
		materiales=new int[4];
		for(int i=0;i<4;i++){
			int valor= Random.Range(0, 2000);
			materiales[i]=valor;
		}
		//imprimir();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void imprimir(){
		for(int i=0;i<4;i++){
			print(name+" "+materiales[i]);
		}
	}
}
