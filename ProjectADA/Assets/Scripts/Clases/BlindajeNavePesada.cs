using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlindajeNavePesada : MonoBehaviour {
	int [] costo = new int[4];
	int beneficio;

	// Use this for initialization
	void Start () {
		costo[0]=4000;
		costo[1]=5500;
		costo[2]=3500;
		costo[3]=5100;	
		beneficio=1200;	
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
