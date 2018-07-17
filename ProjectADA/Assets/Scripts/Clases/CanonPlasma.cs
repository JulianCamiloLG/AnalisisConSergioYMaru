using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanonPlasma : MonoBehaviour {
	public int [] costo = new int [4];
	public int dano;

	// Use this for initialization
	void Start () {
		costo[0]=2500;
		costo[1]=3000;
		costo[2]=2800;
		costo[3]=3500;	
		dano=100;	
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public int[] getCosto(){
		return this.costo;
	}
	public int getBeneficio(){
		return this.dano;
	}
	public void setCosto(int[] costo){
		this.costo=costo;
	}
	public void setBeneficio(int dano){
		this.dano=dano;
	}
}
