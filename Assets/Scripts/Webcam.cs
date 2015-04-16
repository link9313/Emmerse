using UnityEngine;
using System.Collections;

public class Webcam : MonoBehaviour
{
	void Start()
	{
		WebCamTexture webcamTexture = new WebCamTexture();
		renderer.material.mainTexture = webcamTexture;
		webcamTexture.Play();
	}
}
