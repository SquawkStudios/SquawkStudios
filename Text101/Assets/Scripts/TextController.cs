using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TextController : MonoBehaviour {
	
	public Text text;
	private enum States {cell, mirror, sheets_0, lock_0, cell_mirror, sheets_1, lock_1, corridor_0, stairs_0, floor, closet_door, corridor_1,
						stairs_1, in_closet, corridor_2, stairs_2, corridor_3, courtyard};
	private States myState;
	
	// Use this for initialization
	void Start () {
		myState = States.cell;
	}
	
	// Update is called once per frame
	void Update () {
		print (myState);
		if(myState == States.cell) {state_cell();}
		else if (myState == States.sheets_0) {state_sheets_0();}
		else if (myState == States.mirror) {state_mirror();}
		else if (myState == States.lock_0) {state_lock_0();}
		else if (myState == States.cell_mirror) {state_cell_mirror();}
		else if (myState == States.sheets_1) {state_sheets_1();}
		else if (myState == States.lock_1) {state_lock_1();}
		else if (myState == States.corridor_0) {state_corridor_0();}
		else if (myState == States.stairs_0) {state_stairs_0();}
		else if (myState == States.floor) {state_floor();}
		else if (myState == States.closet_door) {state_closet_door();}
		else if (myState == States.corridor_1) {state_corridor_1();}
		else if (myState == States.stairs_1) {state_stairs_1();}
		else if (myState == States.in_closet) {states_in_closet();}
		else if (myState == States.corridor_2) {states_corridor_2(); }
		else if (myState == States.stairs_2) {states_stairs_2();}
		else if (myState == States.corridor_3) {states_corridor_3();}
		else if (myState == States.courtyard) {states_courtyard();}
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
			myState = States.cell_mirror;
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
	
	void state_cell_mirror() {
		text.text = "You have the mirror in your hand. It seems logical to have a look at that lock again, " + 
					"Maybe you should give that a try? Just a suggestion, I mean you could look at those " +
					"manky sheets again.\n\n" +
					"Press S to look at the sheets or L to look at the lock";
		if(Input.GetKeyDown(KeyCode.S)) {
			myState = States.sheets_1;
		} else if(Input.GetKeyDown(KeyCode.L)) {
			myState = States.lock_1;
		}
	}
	
	void state_sheets_1() {
		text.text = "What a surprise, these sheets are still as drab and depressing as when " + 
					"you last looked at them mere moments ago.\n\n" +
					"Press R to return to the cell.";
		if(Input.GetKeyDown(KeyCode.R)) {
			myState = States.cell_mirror;
		}
	}
	
	void state_lock_1() {
		text.text = "You have the mirror, you have the lock. You place the mirror on the lock and look at the " +
					"keypad. You try the plethora of combinations that visible thumb presses are on.\n" +
					"Huzzah it worked, you are safe to leave if you wish! Or you could just go back to the cell, " +
					"I mean 3 meals a day, a bed (with horrific sheets may I add) and all the time in the world.\n\n" +
					"Press R to give up hope and return to your cell or O to open the door!";
		if(Input.GetKeyDown(KeyCode.R)) {
			myState = States.cell_mirror;
		} else if(Input.GetKeyDown(KeyCode.O)) {
			myState = States.corridor_0;
		}
	}
	
	void state_corridor_0() {
		text.text = "You have escaped your cell, However you aren't home free yet!\n" +
					"You are now faced with a corridor. You have a plethora of options " +
					"You can go upstairs, but you are certain that will lead to your capture. " +
					"Can have a look and see if you can get into the closet next to you or look " +
					"at the floor, Who would do that, you must be crazy!\n\n" +
					"Press S to go upstairs, F to look at the floor or C to look in the closet.";
		if(Input.GetKeyDown(KeyCode.S)) {
			myState = States.cell;
		}
	}
}
