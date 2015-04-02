using UnityEngine;
using System.Collections;

public class Movie : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}

	//MovieTexture movTex;

	// Update is called once per frame

	void Update () {
		Renderer r = GetComponent<Renderer>();
        MovieTexture movie = (MovieTexture)r.material.mainTexture;
		
		movie.loop = true;
		movie.Play();
	}
}
