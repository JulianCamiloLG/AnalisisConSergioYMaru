using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CapacidadCombustible : MonoBehaviour {
	int [] costo = new int[4];
	int beneficio;

	// Use this for initialization
	void Start () {
		costo[0]=1500;
		costo[1]=2000;
		costo[2]=1500;
		costo[3]=3000;
		beneficio=50000;		
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
