using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Linea : MonoBehaviour {

	public AudioSource fondo,fuente;
	public AudioClip sonido,clic;
	public Canvas canvasCultura, canvasVias, canvasInfraestructura, canvasZonas;
	public Animator animacion;

	public void Start () {
		fuente.clip = clic;
	}

	public void btnVias(){
		animacion.Play ("animacionVias(1)");
		terminarCultura ();
		terminarZonas();
		terminarInfraestructura();
		fuente.Play ();
		empezarVias ();
	}

	public void btnTerminarVias(){
		animacion.Play ("animacionVolver");
		fuente.Play ();
	}


	public void btnZonas(){
		animacion.Play ("animacionVias(1)");
		terminarVias ();
		terminarCultura ();
		terminarInfraestructura();
		fuente.Play ();
		empezarZonas();
	}

	public void btnTerminarZonas(){
		animacion.Play ("animacionVolver");
		fuente.Play ();
	}

	public void btnCultura(){
		animacion.Play ("animacionVias(1)");
		terminarVias ();
		terminarZonas ();
		terminarInfraestructura();
		fuente.Play ();
		empezarCultura();
	}

	public void btnTerminarCultura(){
		animacion.Play ("animacionVolver");
		fuente.Play ();
	}

	public void btnInfraestructura(){
		animacion.Play ("animacionVias(1)");
		terminarVias ();
		terminarZonas();
		terminarCultura();
		fuente.Play ();
		empezarInfraestructura();
	}

	public void btnTerminarInfraestructura(){
		animacion.Play ("animacionVolver");
		fuente.Play ();
	}
		

	public void terminarCultura(){
		canvasCultura.gameObject.SetActive (false);
	}

	public void terminarVias(){
		canvasVias.gameObject.SetActive (false);
	}

	public void terminarInfraestructura(){
		canvasInfraestructura.gameObject.SetActive (false);
	}

	public void terminarZonas(){
		canvasZonas.gameObject.SetActive (false);
	}

	public void empezarCultura(){
		canvasCultura.gameObject.SetActive (true);
	}

	public void empezarVias(){
		canvasVias.gameObject.SetActive (true);
	}

	public void empezarInfraestructura(){
		canvasInfraestructura.gameObject.SetActive (true);
	}

	public void empezarZonas(){
		canvasZonas.gameObject.SetActive (true);
	}
		
}

