using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PruebaInsttancia : MonoBehaviour {
	private Transform Player;
	public Rigidbody bola;
	public float velocidad = 12f;

	//void Disparador(){
	//	Rigidbody bolaClon = (Rigidbody) Instantiate(bola, transform.position, transform.rotation);
	//	bolaClon.velocity = transform.forward * velocidad;
	//}

	//void Awake()
	//{
	//	Player = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
	//	
	//	if (Player == null)
	//	{
	//		enabled=false;
	//		Debug.Log("Variable null");
	//	}else{
	//		enabled=true;
	//		Debug.Log ("La variable no es igual null!");
	//	}
	//}
	//public GameObject prefab;

	// Use this for initialization
	//void Start () {
		
	//}
	
	// Update is called once per frame
	//void Update () {
	//if (Input.GetKey(KeyCode.Space)){
	//		Instantiate(bola);
	//	}
	//	if (Input.GetKeyUp(KeyCode.Space))
	//		GameObject nebulosa= Instantiate(prefab,transform.position,transform.rotation) as GameObject;		
	//		
	//}
}
