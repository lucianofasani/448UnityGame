using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TextSwitch : MonoBehaviour {

	Text text;
	// Use this for initialization
	IEnumerator Start () {
		yield return new WaitForSeconds (5);
		text = GetComponent<Text> ();
		text.text = "...oh, are you stuck? Try using your arrow keys.";
	}
	
	// Update is called once per frame
	void Update () {
		
	}


}
