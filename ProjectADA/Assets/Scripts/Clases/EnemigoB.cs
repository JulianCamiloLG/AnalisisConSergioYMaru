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
	public int vida
	{
		get
		{
			return this.vida;
		}
		set
		{
			this.vida = value;
		}
	}
	public int dano
	{
		get
		{
			return this.dano;
		}
		set
		{
			this.dano = value;
		}
	}
}
