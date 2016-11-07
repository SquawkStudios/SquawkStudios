using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TextController : MonoBehaviour {
	
	public Text text;
	private enum States {cell, mirror, sheets_0, lock_0, cell_mirror, sheets_1, lock_1, freedom};
	private States myState;
	
	// Use this for initialization
	void Start () {
		myState = States.cell;
	}
	
	// Update is called once per frame
	void Update () {
		print (myState);
		if(myState == States.cell) {
			States.cell();
		}else if (myState == States.sheets_0) {
			States.sheets_0();
		}
	}
	
	void state_cell () {
		text.text = "You are in a prison cell, and you want to escape. There are " +
					"some dirty sheets on the bed, a mirror on the wall and the door " + 
					"is locked from the outside.\n\n" +
					"Press S to view sheets. Pres M to view mirror and L to view lock";
		if(Input.GetKeyDown(KeyCode.S)) {
			myState = States.sheets_0;
		}
	}
	
	void state_sheets_0 () {
		text.text = "You can't believe you sleep in these things. Surely it's " +
					"time somebody changed them. The pleasures of prison life " + 
					"I guess.\n\n" +
					"Press R to return to cell";
		if(Input.GetKeyDown(KeyCode.R)) {
			myState = States.cell;
		}
	}
}
