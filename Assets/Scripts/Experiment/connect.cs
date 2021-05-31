using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using WebSocketSharp;
using WebSocketSharp.Net;

using System.IO;
using SocketIO;

namespace SocketIO
{
	public class connect : MonoBehaviour
	{
		//https://stackoverflow.com/questions/28473707/how-to-use-socketioclient-in-unity

		#region Public Properties

		public string url = "ws://relle.ufsc.br:8080/labs/9/socket.io/?EIO=3&transport=websocket"; 

		public WebSocket socket { get { return ws; } }

		public volatile bool connectFila;

		#endregion

		#region Private Properties
		private WebSocket ws;

		#endregion

		public void Awake(){
			ws = new WebSocket(url);

			connectFila = false;
		}

		public void Start(){
			//StartCoroutine("Acess");
			Acess();
		}
		 
		public void Update(){

		
		}

		public IEnumerable Acess(){
			//continuar tentando conectar
			while (true) {

				yield return new WaitForSeconds (1f);

				ws.OnMessage += (sender, e) =>
				Debug.Log ("Laputa says: " + e.Data);

				ws.Connect();

				//waitLab();
				StatusHandler ();
			}

		}

		public void StatusHandler(){

			if (ws.IsConnected) {
				connectFila = true;
				Debug.Log ("conectou fila");
			} else {
				Debug.Log ("exp ocupado");
			}			
		}

  }
		
}