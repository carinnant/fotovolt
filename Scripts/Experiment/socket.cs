using UnityEngine;
using System.Collections;
using SocketIO;
using System;
using System.Collections.Generic;
using Random = UnityEngine.Random;

public class socket : MonoBehaviour
{

	public SocketIOComponent socketi;
	//id da conexão
	public string id;
	//chaves
	public static string[] sws = { "0", "0", "0", "0"};
	public static float[] sliders = {  };
	public static string[] send = { "0" };

	public float sValue = 100f;

	// Use this for initialization

	void Start()
	{
			GameObject go = GameObject.Find("SocketIO");
			socketi = go.GetComponent<SocketIOComponent>();


		//if(socketi.IsConnected == true){
		
			id = Random.Range(1000000, 9999999).GetHashCode().ToString();

			JSONObject begin = new JSONObject(JSONObject.Type.OBJECT);
			begin.AddField("pass", id);


			socketi.Emit("teste", begin);
			Debug.Log("conection socket");
			socketi.On("boop", TestBoop);


			JSONObject data = new JSONObject(JSONObject.Type.OBJECT);
			data.AddField("pass", id);
			socketi.Emit("new connection", data);
		
		//}

	}
		

	// Update is called once per frame
	void Update()
	{


	}


	public void ScrollBar(float newValue)
	{
		sValue = newValue;

		JSONObject data = new JSONObject(JSONObject.Type.OBJECT);
		data.AddField("pass", id);

		socketi.Emit("new connection", data);
		socketi.On("boop", TestBoop);
		JSONObject slider = new JSONObject(JSONObject.Type.NUMBER);

		//if (sliders[0] ==  )
		//{
			sliders[0] = newValue;
			questexperimento.value[0] = newValue;
		//}
/*		else 
		{
			sliders[0] = 0;
			questexperimento.value[0] = 0;
		}
*/			
		slider.Add(sliders[0]); 

		data.AddField("slider", slider);
		data.AddField("slider",20);
		Debug.Log(sliders);
		Debug.Log(data);
		socketi.Emit("new message", data); 
//	}

//	public void Enviar()
//	{

//		JSONObject data = new JSONObject(JSONObject.Type.OBJECT);
//		data.AddField("pass", id);

//		socketi.Emit("new connection", data);
//		socketi.On("boop", TestBoop);
		JSONObject arrs = new JSONObject(JSONObject.Type.ARRAY);

		if (send[0] == "0")
		{
			send[0] = "1";
			questexperimento.button[0] = true;
			questexperimento.value[0] = newValue;
		}
/*		else
		{
			send[0] = "0";
			questexperimento.button[0] = false;
		}
*/
		//guarda as chaves, verificar se esta
		arrs.Add(send[0]);

		data.AddField("send", arrs);
		Debug.Log(sws);
		Debug.Log(data);
		socketi.Emit("new message", data);
	}

	public void Lampada()
	{
		JSONObject data = new JSONObject(JSONObject.Type.OBJECT);
		data.AddField("pass", id);

		socketi.Emit("new connection", data);

		JSONObject arr = new JSONObject(JSONObject.Type.ARRAY);

		//if (sws[1] == "0")
		//{
		sws[0] = "1";
		//questexperimento.keys[1] = true;
		//}

		arr.Add(sws[0]);
		arr.Add(sws[1]);
		arr.Add(sws[2]);
		arr.Add(sws[3]);

		data.AddField("sw", arr);
		Debug.Log(sws);
		Debug.Log(data);
		socketi.Emit("new message", data);
	}

	
	public void ChaveS3()
	{
		JSONObject data = new JSONObject(JSONObject.Type.OBJECT);
		data.AddField("pass", id);

		socketi.Emit("new connection", data);

		JSONObject arr = new JSONObject(JSONObject.Type.ARRAY);

		//if (sws[2] == "0")
		//{
			sws[1] = "1";
			//questexperimento.keys[2] = true;
		//}
/*		else
		{
			sws[2] = "0";
			questexperimento.keys[2] = false;
		}
*/

		arr.Add(sws[0]);
		arr.Add(sws[1]);
		arr.Add(sws[2]);
		arr.Add(sws[3]);

		data.AddField("sw", arr);
		Debug.Log(sws);
		Debug.Log(data);
		socketi.Emit("new message", data);
	}

	public void Capacitor()
	{
		JSONObject data = new JSONObject(JSONObject.Type.OBJECT);
		data.AddField("pass", id);

		socketi.Emit("new connection", data);

		JSONObject arr = new JSONObject(JSONObject.Type.ARRAY);

		//if (sws[3] == "0")
		//{
			sws[2] = "1";
			//questexperimento.keys[3] = true;
		//}
/*		else
		{
			sws[2] = "0";
			questexperimento.keys[2] = false;
		}
*/


		arr.Add(sws[0]);
		arr.Add(sws[1]);
		arr.Add(sws[2]);
		arr.Add(sws[3]);

		data.AddField("sw", arr);
		Debug.Log(sws);
		Debug.Log(data);
		socketi.Emit("new message", data);
	}


	public void MatrizLed()
	{
		JSONObject data = new JSONObject(JSONObject.Type.OBJECT);
		data.AddField("pass", id);

		socketi.Emit("new connection", data);

		JSONObject arr = new JSONObject(JSONObject.Type.ARRAY);

		//if (sws[4] == "0")
		//{
			sws[3] = "1";
			//questexperimento.keys[4] = true;
		//}
/*		else
		{
			sws[2] = "0";
			questexperimento.keys[2] = false;
		}
*/


		arr.Add(sws[0]);
		arr.Add(sws[1]);
		arr.Add(sws[2]);
		arr.Add(sws[3]);

		data.AddField("sw", arr);
		Debug.Log(sws);
		Debug.Log(data);
		socketi.Emit("new message", data);
	}

	public void TestBoop(SocketIOEvent e) {
		Debug.Log(string.Format("[name: {0}, data: {1}]", e.name, e.data));
	}
		
}
