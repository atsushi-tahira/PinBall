using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RetryButton : MonoBehaviour {
	string sceneName;
	public void  OnClick(){
		Retry ();
		//		Debug.Log ("押された！");
	}

	public void Start(){
		sceneName = SceneManager.GetActiveScene ().name;
	}

	public void Update(){

	}

	public void Retry(){
		SceneManager.LoadScene (sceneName);
	}
}