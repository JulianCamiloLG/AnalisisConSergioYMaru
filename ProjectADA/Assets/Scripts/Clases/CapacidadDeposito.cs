using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CapacidadDeposito : MonoBehaviour {
	int [] costo = new int [4];
	int beneficio;

	// Use this for initialization
	void Start () {
		costo[0]=4000;
		costo[1]=4000;
		costo[2]=4000;
		costo[3]=4000;	
		beneficio=50;	
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
