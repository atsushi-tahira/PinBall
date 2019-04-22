using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BallController : MonoBehaviour {

	//ボールが見える可能性のあるz軸の最大値
	private float visiblePosZ = -6.5f;
	//ゲームオーバを表示するテキスト
	private GameObject gameoverText;
	string sceneName;
	private GameObject rtBottun;


	// Use this for initialization
	void Start () {
		//シーン中のGameOverTextオブジェクトを取得
		this.gameoverText = GameObject.Find("GameOverText");
		rtBottun = GameObject.Find ("Button");
		sceneName = SceneManager.GetActiveScene ().name;
		rtBottun.SetActive (false);


	}

	// Update is called once per frame
	void Update () {
		//ボールが画面外に出た場合
		if (this.transform.position.z < this.visiblePosZ) {
			//GameoverTextにゲームオーバを表示
			this.gameoverText.GetComponent<Text> ().text = "Game Over";
			rtBottun.SetActive (true);
		}
	}

	void OnCollisionEnter(Collision other){
		string gotag = other.gameObject.tag;
		if (gotag == "SmallStarTag") {
			FindObjectOfType<Score>().AddPoint(5);
//			Debug.Log ("5points!");
		} else if (gotag == "LargeStarTag") {
			FindObjectOfType<Score>().AddPoint(10);
//			Debug.Log ("10points!");
		} else if (gotag == "SmallCloudTag") {
			FindObjectOfType<Score>().AddPoint(20);
//			Debug.Log ("20points!");
		} else if (gotag == "LargeCloudTag") {
			FindObjectOfType<Score>().AddPoint(50);
//			Debug.Log ("50points!");
		}
	}

	public void RetryButton(){
		SceneManager.LoadScene (sceneName);
	}
}