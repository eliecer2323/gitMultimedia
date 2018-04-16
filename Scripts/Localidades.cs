using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Localidades : MonoBehaviour
{

	public AudioSource fuente;

	// Use this for initialization
	void Start()
	{
	}

	public void Reproducir()
	{
		fuente.Play();
	}

	void Update()
	{
		if (Input.GetMouseButtonDown(0))
		{
			//Debug.Log("Pressed left click, casting ray.");
			CastRay();
		}
	}

	void CastRay()
	{
		Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
		RaycastHit2D hit = Physics2D.Raycast(ray.origin, ray.direction, 0);
		if (hit)
		{
			Debug.Log(hit.collider.gameObject.name);
			GameObject localidad = hit.collider.gameObject;
			Image imgLocalidad = hit.collider.gameObject.GetComponent<Image>();
			imgLocalidad.enabled = !imgLocalidad.enabled;
			Reproducir();
		}
	}

}