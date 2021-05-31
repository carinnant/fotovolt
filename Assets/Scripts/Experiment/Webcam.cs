using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Webcam : MonoBehaviour {

	public string url = "http://images.earthcam.com/ec_metros/ourcams/fridays.jpg";
	//public Image myimage;
	// Use this for initialization

	public Image imageToDisplay;
	public bool cond= true;
	public bool temp = false;
	public float tempo = 0 ;
	IEnumerator Start() {
		while (true) {
			WWW www = new WWW(url);
			yield return www;


			// assign texture
			//SpriteRenderer renderer = GetComponent<SpriteRenderer>();
			// renderer.material.mainTexture = www.texture;

			Texture2D texture = new Texture2D(www.texture.width, www.texture.height, TextureFormat.DXT1, false);

			// assign the downloaded image to sprite
			www.LoadImageIntoTexture(texture);
			Rect rec = new Rect(0, 0, texture.width, texture.height);
			Sprite spriteToUse = Sprite.Create(texture, rec, new Vector2(0.5f, 0.5f), 100);
			imageToDisplay.sprite = spriteToUse;
			// Debug.LogError("funcionando");
			yield return new WaitForSeconds(1);
			www.Dispose();
			www = null;
		}

	}

	// Update is called once per frame
	void Update () {




	}

	IEnumerator refresh_image()
	{
		WWW www = new WWW(url);
		yield return www;


		// assign texture
		//SpriteRenderer renderer = GetComponent<SpriteRenderer>();
		// renderer.material.mainTexture = www.texture;

		Texture2D texture = new Texture2D(www.texture.width, www.texture.height, TextureFormat.DXT1, false);

		// assign the downloaded image to sprite
		www.LoadImageIntoTexture(texture);
		Rect rec = new Rect(0, 0, texture.width, texture.height);
		Sprite spriteToUse = Sprite.Create(texture, rec, new Vector2(0.5f, 0.5f), 100);
		imageToDisplay.sprite = spriteToUse;
		www.Dispose();
		www = null;
	}
}


