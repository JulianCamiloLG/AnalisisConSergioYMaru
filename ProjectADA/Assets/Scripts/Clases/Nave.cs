using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nave : MonoBehaviour {
	public int vidaBAse; 
	public int danoArmaBase;
	public float propulsorBase;
	public int capacidadRecursos;
	public float capacidadCombustible;


	// Use this for initialization
	void Start () {
		vidaBAse=1200; 
		danoArmaBase=60;
		propulsorBase=2.0f;
		capacidadRecursos=5000;
		capacidadCombustible=100000;		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
