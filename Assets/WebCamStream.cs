using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WebCamStream : MonoBehaviour
{
    private WebCamTexture webcamTexture;

    void OnEnable()
    {
        webcamTexture = new WebCamTexture();
        Renderer renderer = GetComponent<Renderer>();
        renderer.material.mainTexture = webcamTexture;
        webcamTexture.Play();
    }

    void OnDisable()
    {
        if(webcamTexture != null)
		{
			webcamTexture.Stop();
            // no dispose??
        }
    }


}
