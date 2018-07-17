using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemigoB : MonoBehaviour {
	public int vida;
	public int dano;

	// Use this for initialization
	void Start () {
		vida=400;
		dano=100;		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public int getVida(){
		return vida;
	}
	public int getDano(){
		return this.dano;
	}
	public void setVida(int beneficio){
		this.vida=beneficio;
	}
	public void setDano(int dano){
		this.dano=dano;
	}
}
