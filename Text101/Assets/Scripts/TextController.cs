using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TextController : MonoBehaviour {
	
	public Text text;
	
	// Use this for initialization
	void Start () {
		text.text = "Hello World";
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.Space)) {
			text.text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus eu imperdiet magna. Nunc pulvinar sem sit amet suscipit vestibulum. Morbi tristique magna quis tellus consectetur porta. Proin vel sodales nisi, congue finibus velit. Fusce auctor est urna, nec fermentum mi finibus sed.";
		}
	}
}
