using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class BotonesLinea : MonoBehaviour {


	public AudioSource fuente,fondo;
	public AudioClip clip,sonido;

	public void Start () {
		fuente.clip = clip;
	}

	public void btnBogota2(){
		fondo.Stop ();
		fuente.Play ();
		Invoke ("Empezar5_6", fuente.clip.length);
	}

	public void btnBogota(){
		fondo.Stop ();
		fuente.Play ();
		Invoke ("Empezar5", fuente.clip.length);
	}

	public void btnBogota3(){
		fondo.Stop ();
		fuente.Play ();
		Invoke ("Empezar6_7", fuente.clip.length);
	}

	public void btnBogota4(){
		fondo.Stop ();
		fuente.Play ();
		Invoke ("Empezar7_8", fuente.clip.length);
	}

	public void Empezar5(){
		SceneManager.LoadScene ("Guion5");
	}

	public void Empezar5_6(){
		SceneManager.LoadScene ("Guion6");
	}

	public void Empezar6_7 (){
		SceneManager.LoadScene ("Guion7");
	}

	public void Empezar7_8 (){
		SceneManager.LoadScene ("Guion8");
	}


}
