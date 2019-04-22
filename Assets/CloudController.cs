using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudController : MonoBehaviour {

	private float minimum = 1.0f;
	private float magSpeed = 10.0f;
	private float magnification = 0.07f;

	// Use this for initialization
	void Start () {
//		float dosu = 1.0f; 
//		for (int i = 1; i < 361f; i++) {
//			Debug.Log (string.Format("i = {0}; " + Mathf.Sin (dosu * Mathf.Deg2Rad),i));
//			dosu += 1.0f;
//		}
	}
	
	// Update is called once per frame
	void Update () {
		this.transform.localScale =  new Vector3(this.minimum +  Mathf.Sin(Time.time * this.magSpeed) * this.magnification, this.transform.localScale.y, this.minimum +  Mathf.Sin(Time.time * this.magSpeed) * this.magnification);
	}
}
