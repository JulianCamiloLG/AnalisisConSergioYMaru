using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlindajeNavePesada : MonoBehaviour {
	int [] costo = new int[4];
	int beneficio;

	// Use this for initialization
	void Start () {
		costo[0]=4000;
		costo[1]=5500;
		costo[2]=3500;
		costo[3]=5100;	
		beneficio=1200;	
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	public int[] getCosto(){
		return this.costo;
	}
	public int getBeneficio(){
		return this.beneficio;
	}
	public void setCosto(int[] costo){
		this.costo=costo;
	}
	public void setBeneficio(int beneficio){
		this.beneficio=beneficio;
	}
}
