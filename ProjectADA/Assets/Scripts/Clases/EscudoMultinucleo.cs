using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EscudoMultinucleo : MonoBehaviour {
	int [] costo= new int [4];
	int beneficio;

	// Use this for initialization
	void Start () {
		costo[0]=500;
		costo[1]=1200;
		costo[2]=1800;
		costo[3]=1600;	
		beneficio=400;	
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
