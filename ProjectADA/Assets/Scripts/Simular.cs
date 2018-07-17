using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class Simular : MonoBehaviour {

	public Camera main;
	public Camera second;
	public GameObject ui;
	public GameObject botones;
	public GameObject[] mejoras;
	public int[] totalesNecesarios;

	void Start(){

	}

	public void iniciarSimulacion(){
		print("click");
		second.enabled=true;
		main.enabled=false;
		ui.SetActive(true);
		botones.SetActive(false);
		GameObject nebulosas=GameObject.Find("Nebulosas");
		//gananciasTotales(nebulosas,mejoras);
		revisionEstaciones(nebulosas,mejoras);
	}

	public void gananciasTotales(GameObject nebulosas, GameObject[] mejoras){
		//int[] costeMejoras=MaterialesTotales(mejoras);
		int totalNebubolas=0;
		
		int cont=0;
		foreach(Transform child in nebulosas.transform){

			//ganancias[cont]+=GananciaNebulosa(child.gameObject, totalesNecesarios);
			print(child.GetComponent<CrearNebulosa>().tieneEstacion);
			cont++;
		}
		float[] ganancias=new float[cont];
		cont=0;
		foreach(Transform child in nebulosas.transform){

			ganancias[cont]+=GananciaNebulosa(child.gameObject, totalesNecesarios);
			cont++;
		}
		cont=0;
		foreach(Transform child in nebulosas.transform){
			print("Ganancias en: "+child.name+" "+ganancias[cont]);
			cont++;
		}
	}
	
	public void revisionEstaciones(GameObject nebulosas, GameObject[] mejoras){
		//int[] costeMejoras=MaterialesTotales(mejoras);
		int totalNebubolas=0;
		
		int cont=0;
		foreach(Transform child in nebulosas.transform){
			if(child.GetComponent<CrearNebulosa>().tieneEstacion==true){
				//ganancias[cont]+=basadoEnEstacion(child.gameObject, totalesNecesarios);
				cont++;
			}
		}
		float[] ganancias=new float[cont];
		cont=0;
		SortedDictionary<string,float> nebulosasArecorrer=new SortedDictionary<string,float>();
		foreach(Transform child in nebulosas.transform){
			if(child.GetComponent<CrearNebulosa>().tieneEstacion==true){
				ganancias[cont]+=basadoEnEstacion(child.gameObject, totalesNecesarios);
				print("Ganancias en: "+child.name+" "+ganancias[cont]+"%");
				nebulosasArecorrer.Add(child.name,ganancias[cont]);
				cont++;
			}
		}
		
		var items = from pair in nebulosasArecorrer
                    orderby pair.Value descending
                    select pair;
        string camino="Ruta: ";
		foreach(KeyValuePair<string,float>nebulosaConEstacion in items){
			camino+=nebulosaConEstacion.Key+" ";
		}
		print(camino);
	}

	// int[] materiales = { 10, 20, 30, 40 };
	// int[] planeta = { 1 };
	// int[] sistemaSolar = { 2 };
	// int[][] SistemaPlanetario1 = { sistemaSolar, planeta, materiales };
	
	// int[] materiales1 = { 150, 250, 350, 450 };
	// int[] planeta1 = { 1 };
	// int[] sistemaSolar1 = { 2 };
	// int[][] SistemaPlanetario2 = { sistemaSolar1, planeta1, materiales1 };
	
	// int[] materiales2 = { 101, 201, 301, 401 };
	// int[] planeta2 = { 1 };
	// int[] sistemaSolar2 = { 2 };
	// int[] materiales3 = { 111, 222, 333, 444 };
	// int[] planeta3 = { 1 };			
	// int[] sistemaSolar3 = { 6 };
	// int[][] SistemaPlanetario3 = {
	// 	sistemaSolar2,
	// 	planeta2,
	// 	materiales2,
	// 	sistemaSolar3,
	// 	planeta3,
	// 	materiales3
	// };
	
	// static int[][][] Nebulosa = { SistemaPlanetario1, SistemaPlanetario2, SistemaPlanetario3 };
	
	// int[] necesarios = { 20, 50, 68, 10 }; //Este funcionara haciendo el llamado a la funcion MaterialesTotales

	// float ganancia=GananciaNebulosa(Nebulosa,necesarios);

	//Calcular los beneficios de una nebulosa
	public static float GananciaNebulosa(GameObject nebulosasTotales, int[] necesarios){//, int[] necesarios){
		int contador = 0, necesario = 0;
		float w = 0, x = 0, y = 0, z = 0;
		foreach(Transform SistemaPlanetario in nebulosasTotales.transform) {			
			foreach (Transform Planeta in SistemaPlanetario.gameObject.transform) {
				foreach (var elemento in Planeta.GetComponent<Planeta>().materiales) {
					if (contador == 2) {
						//print("\t" + "Dato" + contador + "->>" + elemento.ToString());	
						x = int.Parse(elemento.ToString());
						y = (x * 100) / necesarios[necesario];
						z = z + y;
						necesario++;
					}
				}					
				contador++;
				if (contador == 3) {
					//print("planeta" + z);						
					w = w + z;
					//print("Nebulosa" + w);
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

	public static float basadoEnEstacion(GameObject nebulosasTotales, int[] necesarios){//, int[] necesarios){
		int contador = 0, necesario = 0;
		float w = 0, x = 0, y = 0, z = 0;
		foreach(Transform SistemaPlanetario in nebulosasTotales.transform) {			
			foreach (Transform Planeta in SistemaPlanetario.gameObject.transform) {
				foreach (var elemento in Planeta.GetComponent<Planeta>().materiales) {
					if (contador == 2) {
						//print("\t" + "Dato" + contador + "->>" + elemento.ToString());	
						x = int.Parse(elemento.ToString());
						y = (x * 100) / necesarios[necesario];
						z = z + y;
						necesario++;
					}
				}					
				contador++;
				if (contador == 3) {
					//print("planeta" + z);						
					w = w + z;
					//print("Nebulosa" + w);
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
	
	// int[] mejora1 = { 10, 20, 30, 40 };
	// int[] mejora2 = { 100, 200, 300, 400 };
	// int[] mejora3 = { 30, 40, 50, 60 };
	// int[] mejora4 = { 300, 400, 500, 600 };
	// int[] mejora5 = { 50, 60, 70, 80 };
	// int[] mejora6 = { 500, 600, 700, 800 };
	
	// int[][] Mejoras = { mejora1,mejora2,mejora3,mejora4,mejora5,mejora6 };
	// int [] totales = new int [4];
	
	// int[] total=MaterialesTotales(Mejoras,totales);

	//Calcular el total de recuros necesarios para las mejoras
	/*public static int [] MaterialesTotales(GameObject[] MejorasTotales){
		int[] totales=new int[4];
		int contador=0;
		foreach(Transform mejora in MejorasTotales[contador].transform) {
			contador=0;				
			for(int i=0; i<4;i++) {
				print("\t" + "Dato" + mejora.gameObject.getCosto()[i].ToString());
				totales[contador]=totales[contador]+int.Parse(mejora.gameObject.getCosto()[i].ToString());
				contador++;					
			}			
		}
		return totales;			
	}*/
	
	
}
