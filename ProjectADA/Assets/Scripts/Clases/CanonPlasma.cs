using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanonPlasma : MonoBehaviour {
	int [] costo = new int [4];
	int dano;

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
	public int costo
	{
		get
		{
			return this.costo;
		}
		set
		{
			this.costo = value;
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
