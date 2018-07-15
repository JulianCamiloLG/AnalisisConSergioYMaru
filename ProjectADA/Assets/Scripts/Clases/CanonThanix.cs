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
	public int beneficio
	{
		get
		{
			return this.beneficio;
		}
		set
		{
			this.beneficio = value;
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
			this.dano=value;
		}
	}
}
