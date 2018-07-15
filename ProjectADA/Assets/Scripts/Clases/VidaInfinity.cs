using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VidaInfinity : MonoBehaviour {
	int [] costo = new int[4];
	int beneficio;

	// Use this for initialization
	void Start () {
		costo[0]=500;
		costo[1]=1000;
		costo[2]=1000;
		costo[3]=1000;
		beneficio=100;		
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
}
