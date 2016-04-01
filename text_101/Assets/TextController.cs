using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TextController : MonoBehaviour {
	public Text text;
	// Use this for initialization
	void Start () {
		text.text = "";
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (Input.GetKeyDown(KeyCode.Space))
		{ text.text = "Oh my god, what the hell am I doing here? " +
		              "I must escape right now. There are only " +
		              "some dirty sheets and a mirror on the wall.\n\n " +
		              "Shit !! the door in front of me is locked.";
		}
	}
}
