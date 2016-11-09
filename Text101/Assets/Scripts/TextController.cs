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
			state_cell();
		}else if (myState == States.sheets_0) {
			state_sheets_0();
		}else if (myState == States.mirror) {
			state_mirror();
		}else if (myState == States.lock_0) {
			state_lock_0();
		}
	}
	
	void state_cell () {
		text.text = "You are in a prison cell, and you want to escape. There are " +
					"some dirty sheets on the bed, a mirror on the wall and the door " + 
					"is locked from the outside.\n\n" +
					"Press S to view sheets. Pres M to view mirror and L to view lock";
		if(Input.GetKeyDown(KeyCode.S)) {
			myState = States.sheets_0;
		} else if(Input.GetKeyDown(KeyCode.L)) {
			myState = States.lock_0;
		} else if(Input.GetKeyDown(KeyCode.M)) {
			myState = States.mirror;
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
	
	void state_mirror() {
		text.text = "You have a look at the mirror. Damn im fine you think to yourself! "+
					"The mirror is just hanging off the wall. Maybe you could take it? \n\n" + 
					"Press R to return to the cell or T to take the mirror";
		if(Input.GetKeyDown(KeyCode.R)) {
			myState = States.cell;
		} else if(Input.GetKeyDown(KeyCode.T)) {
		/*
			UNCOMMENT CODE WHEN "States.cell_mirror" HAS BEEN CREATED.		
			myState = States.cell_mirror();
		*/
		}
	}
	
	void state_lock_0() {
		text.text = "Theres a lock on the outside. It's obviously the way into your cell. " + 
					"If only there was a way to see the keypad on it.\n\n" +
					"Press R to return to cell";
					if(Input.GetKeyDown(KeyCode.R)) {
						myState = States.cell;
					}
	}
}
