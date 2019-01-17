using UnityEngine;
using System.Collections;

public class InputManager : MonoBehaviour {
	// Set up a reference to the Switch via the inspector. Things are starting to get
	// a little out of hand now. This is the 3rd script that has a reference to the Switch.
	// What's going to happen when we have multiple Switches and Doors etc.....
	public SwitchController theSwitch;

	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.Space) == true) { //has spacebar been pressed
			if (theSwitch != null) { //the variable f the switch is equal to nothing (if it hadnt been wired up), if u made a mistake and didnt drag it over, call the function on the switchcontroller script
				theSwitch.toggleSwitch (); //it would work perfectly only if u wired it up, this is just in case it hasnt 
			}
		}
	}
}
