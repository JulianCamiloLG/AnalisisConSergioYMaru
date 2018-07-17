using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanonThanix : MonoBehaviour {
	int [] costo = new int[4];
	int dano;
	int beneficio;

	// Use this for initialization
	void Start () {
		costo[0]=4000;
		costo[1]=6000;
		costo[2]=6000;
		costo[3]=6000;
		dano=2;
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
	public int getDano(){
		return this.dano;
	}
	public void setCosto(int[] costo){
		this.costo=costo;
	}
	public void setBeneficio(int beneficio){
		this.beneficio=beneficio;
	}
	public void setDano(int dano){
		this.dano=dano;
	}
}
