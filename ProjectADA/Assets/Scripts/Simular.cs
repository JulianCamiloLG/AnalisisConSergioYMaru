using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Simular : MonoBehaviour {

	public Camera main;
	public Camera second;
	public GameObject ui;
	public GameObject botones;

	void Start(){

	}

	public void iniciarSimulacion(){
		print("click");
		second.enabled=true;
		main.enabled=false;
		ui.SetActive(true);
		botones.SetActive(false);
	}

	public static int [] MaterialesTotales(int [] mejoras){
		// disable once SuggestUseVarKeywordEvident
		var costos = new int[4];
		if (mejoras.Length>0){
			for (int i = 0; i < mejoras.Length; i++) {
				for (int j = 0; j < mejoras.getCosto.length; j++) {
					costosT[j]=costosT[j]+mejoras.getCosto[j];
				}
			}
		}
		return costos;
	}

	public static float [] MejorCamino(CrearNebulosa[] nebulosas, float[] totalesNecesarios){
		float w;
		float x;
		float y;
		float z;
		float valorSistemaPlanetario;
		float valorFinalGanancia;
		var totales = new float[4];
		if (nebulosas.Length > 1) {
			for (int i = 0; i < nebulosas.Length; i++) {
				for (int j = 0; j < nebulosas[i].getSistemasPlanetarios.length; j++) {
					for (int k = 0; k < nebulosas[i].getSistemasPlanetarios.getPlanetas.length; k++) {
						for (int l = 0; l < nebulosas[i].getSistemasPlanetarios.getPlanetas.getMateriales.length; l++) {
							x = nebulosas[i].getSistemasPlanetarios.getPlanetas.getMateriales[l];
							y = (x * 100) / totalesNecesarios[l];
							z = z + y;
						}
						w = w + z;
					}
					valorSistemaPlanetario = valorSistemaPlanetario + w;
				}
				valorFinalGanancia = valorFinalGanancia + valorSistemaPlanetario;
				totales[i] = valorFinalGanancia;
			}
		}
		return totales;
	}
	
	
}
