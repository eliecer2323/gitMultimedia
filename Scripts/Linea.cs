using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Linea : MonoBehaviour {

	public AudioSource fondo,fuente;
	public AudioClip sonido,clic;
	public Canvas canvasCultura, canvasVias, canvasVestimenta, canvasHechos, canvasLocalidades;
	public Animator animacion;

	public void Start () {
		fuente.clip = clic;
	}

	public void btnVias(){
		animacion.Play ("animacionVias(1)");
		terminarCultura ();
		terminarHechos ();
		terminarLocalidades ();
		terminarVestimenta ();
		fuente.Play ();
		empezarVias ();
	}

	public void btnHechos(){
		animacion.Play ("animacionVias(1)");
		terminarVias ();
		terminarCultura ();
		terminarLocalidades ();
		terminarVestimenta ();
		fuente.Play ();
		Invoke ("empezarHechos", fuente.clip.length);
	}

	public void btnCultura(){
		animacion.Play ("animacionVias(1)");
		terminarVias ();
		terminarHechos();
		terminarLocalidades ();
		terminarVestimenta ();
		fuente.Play ();
		Invoke ("empezarCultura", fuente.clip.length);
	}

	public void btnVestimenta(){
		animacion.Play ("animacionVias(1)");
		terminarVias ();
		terminarHechos();
		terminarCultura();
		terminarLocalidades ();
		fuente.Play ();
		Invoke ("empezarVestimenta", fuente.clip.length);
	}

	public void btnLocalidades(){
		animacion.Play ("animacionVias(1)");
		terminarVias ();
		terminarHechos();
		terminarCultura();
		terminarVestimenta ();
		fuente.Play ();
		Invoke ("empezarLocalidades", fuente.clip.length);
	}

	public void terminarCultura(){
		canvasCultura.gameObject.SetActive (false);
	}

	public void terminarVias(){
		canvasVias.gameObject.SetActive (false);
	}

	public void terminarVestimenta(){
		canvasVestimenta.gameObject.SetActive (false);
	}

	public void terminarHechos(){
		canvasHechos.gameObject.SetActive (false);
	}

	public void terminarLocalidades(){
		canvasLocalidades.gameObject.SetActive (false);
	}

	public void empezarCultura(){
		canvasCultura.gameObject.SetActive (true);
	}

	public void empezarVias(){
		canvasVias.gameObject.SetActive (true);
	}

	public void empezarVestimenta(){
		canvasVestimenta.gameObject.SetActive (true);
	}

	public void empezarHechos(){
		canvasHechos.gameObject.SetActive (true);
	}

	public void empezarLocalidades(){
		canvasLocalidades.gameObject.SetActive (true);
	}
}

