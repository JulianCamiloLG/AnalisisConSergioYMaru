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
	int[] materiales = { 10, 20, 30, 40 };
	int[] planeta = { 1 };
	int[] sistemaSolar = { 2 };
	int[][] nebulosa = { sistemaSolar, planeta, materiales };
	
	int[] materiales1 = { 150, 250, 350, 450 };
	int[] planeta1 = { 1 };
	int[] sistemaSolar1 = { 2 };
	int[][] nebulosa1 = { sistemaSolar1, planeta1, materiales1 };
	
	int[] materiales2 = { 101, 201, 301, 401 };
	int[] planeta2 = { 1 };
	int[] sistemaSolar2 = { 2 };
	int[] materiales3 = { 111, 222, 333, 444 };
	int[] planeta3 = { 1 };			
	int[] sistemaSolar3 = { 6 };
	int[][] nebulosa2 = {
		sistemaSolar2,
		planeta2,
		materiales2,
		sistemaSolar3,
		planeta3,
		materiales3
	};
	
	int[][][] nebulosasTotales = { nebulosa, nebulosa1, nebulosa2 };
	
	int[] necesarios = { 20, 50, 68, 10 };

	GananciaNebulosa(nebulosasTotales,necesarios);

	public static float GananciaNebulosa(int[][][] nebulosasTotales, int[] necesarios){
		int contador = 0, necesario = 0;
		double w = 0, x = 0, y = 0, z = 0;
		double valorSistemaPlanetario = 0;
		foreach (var element in nebulosasTotales) {				
			foreach (var element1 in element) {
				foreach (var element2 in element1) {
					if (contador == 2) {
						Console.WriteLine("\t" + "Dato" + contador + "->>" + element2.ToString());	
						x = Int32.Parse(element2.ToString());
						y = (x * 100) / necesarios[necesario];
						z = z + y;
						necesario++;
					}
				}					
				contador++;
				if (contador == 3) {
					Console.WriteLine("planeta" + z);						
					w = w + z;
					Console.WriteLine("Nebulosa" + w);
					contador = 0;
					necesario = 0;
					x = 0;
					y = 0;
					z = 0;
					
				}
			}			
		}
		return w;
	}
	
	
}
