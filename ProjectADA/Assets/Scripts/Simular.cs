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

	//Calcular los beneficios de una nebulosa
	int[] materiales = { 10, 20, 30, 40 };
	int[] planeta = { 1 };
	int[] sistemaSolar = { 2 };
	int[][] SistemaPlanetario1 = { sistemaSolar, planeta, materiales };
	
	int[] materiales1 = { 150, 250, 350, 450 };
	int[] planeta1 = { 1 };
	int[] sistemaSolar1 = { 2 };
	int[][] SistemaPlanetario2 = { sistemaSolar1, planeta1, materiales1 };
	
	int[] materiales2 = { 101, 201, 301, 401 };
	int[] planeta2 = { 1 };
	int[] sistemaSolar2 = { 2 };
	int[] materiales3 = { 111, 222, 333, 444 };
	int[] planeta3 = { 1 };			
	int[] sistemaSolar3 = { 6 };
	int[][] SistemaPlanetario3 = {
		sistemaSolar2,
		planeta2,
		materiales2,
		sistemaSolar3,
		planeta3,
		materiales3
	};
	
	int[][][] Nebulosa = { SistemaPlanetario1, SistemaPlanetario2, SistemaPlanetario3 };
	
	int[] necesarios = { 20, 50, 68, 10 }; //Este funcionara haciendo el llamado a la funcion MaterialesTotales

	GananciaNebulosa(Nebulosa,necesarios);

	public static float GananciaNebulosa(int[][][] nebulosasTotales, int[] necesarios){
		int contador = 0, necesario = 0;
		double w = 0, x = 0, y = 0, z = 0;
		foreach (var SistemaPlanetario in Nebulosa) {				
			foreach (var Planeta in SistemaPlanetario) {
				foreach (var elemento in Planeta) {
					if (contador == 2) {
						Console.WriteLine("\t" + "Dato" + contador + "->>" + elemento.ToString());	
						x = Int32.Parse(elemento.ToString());
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

	//Calcular el total de recuros necesarios para las mejoras
	int[] mejora1 = { 10, 20, 30, 40 };
	int[] mejora2 = { 100, 200, 300, 400 };
	int[] mejora3 = { 30, 40, 50, 60 };
	int[] mejora4 = { 300, 400, 500, 600 };
	int[] mejora5 = { 50, 60, 70, 80 };
	int[] mejora6 = { 500, 600, 700, 800 };
	
	int[][] Mejoras = { mejora1,mejora2,mejora3,mejora4,mejora5,mejora6 };
	int [] totales = new int [4];
	
	MaterialesTotales(Mejoras,totales);

	public static int [] MaterialesTotales(int [][] MejorasTotales,int [] totales){
		int contador=0;
		foreach (var Mejora in MejorasTotales) {
			contador=0;				
			foreach (var valorMejora in Mejora) {
				Console.WriteLine("\t" + "Dato" + valorMejora.ToString());
				totales[contador]=totales[contador]+Int32.Parse(valorMejora.ToString());
				contador++;					
			}				
		}
		return totales;			
	}
	
	
}
