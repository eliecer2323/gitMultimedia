using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Ventanas : MonoBehaviour {

	public AudioSource fuente;
	public AudioSource narracion;
	public AudioSource fondo;
	public AudioClip clip;
	public AudioClip boton;
	public AudioClip sonido;
	public Canvas canvasCultura,canvasReligion,canvasPoblacion,canvasNarracion;

	public void Start () {
		fuente.clip = clip;
	}

	public void btnVolver(){
		fuente.Play ();
		Invoke ("terminar", fuente.clip.length);
		fuente.Stop ();
	}
		

	public void btnCultura(){
		fondo.UnPause();
		narracion.Stop ();
		fuente.Play ();
		Invoke ("empezarCultura", fuente.clip.length);
		terminarNarracion ();
		terminarPoblacion ();
		terminarReligion ();
	}

	public void btnNarracion(){
		narracion.Stop ();
		fondo.Pause ();
		fuente.Play ();
		empezarNarracion ();
		terminarCultura ();
		terminarPoblacion ();
		terminarReligion ();
	}


	public void btnReligion(){
		fondo.UnPause ();
		narracion.Stop ();
		fuente.Play ();
		Invoke ("empezarReligion", fuente.clip.length);
		terminarNarracion ();
		terminarCultura ();
		terminarPoblacion ();
	}

	public void btnPoblacion(){
		fondo.UnPause();
		narracion.Stop ();
		fuente.Play ();
		Invoke ("empezarPoblacion", fuente.clip.length);
		terminarNarracion ();
		terminarCultura ();
		terminarReligion ();
	}

	public void terminarCultura(){
		canvasCultura.gameObject.SetActive (false);
	} 

	public void terminarNarracion(){
		canvasNarracion.gameObject.SetActive (false);
	}

	public void terminarReligion(){
		canvasReligion.gameObject.SetActive (false);
	}

	public void terminarPoblacion(){
		canvasPoblacion.gameObject.SetActive (false);
	}


	public void empezarCultura(){
		canvasCultura.gameObject.SetActive (true);
	}

	public void empezarReligion(){
		canvasReligion.gameObject.SetActive (true);
	}

	public void empezarPoblacion(){
		canvasPoblacion.gameObject.SetActive (true);
	}

	public void empezarNarracion(){
		canvasNarracion.gameObject.SetActive (true);
	}




}
