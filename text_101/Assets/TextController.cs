using UnityEngine;
using UnityEngine.UI;
using System.Collections;


public class TextController : MonoBehaviour {
	public Text text;
	private enum State {cell, sheets, mirror, lock_0, cell_mirror};
	private State current_state;
	// Use this for initialization
	void Start () {
		current_state = State.cell;
	}
	
	// Update is called once per frame
	void Update ()
	{	if (current_state == State.cell)
		{	cell_method ();
		}
		else if (current_state == State.sheets)
		{	sheets_method ();
		}
		else if (current_state == State.lock_0)
		{	lock_0_method ();
		}
		else if (current_state == State.mirror)
		{	mirror_method ();
		}
		else if (current_state == State.cell_mirror)
		{	cell_mirror_method ();
		}
	}
	
	void cell_method ()
		{	text.text = "You are locked at the cell. Press S to inspect the sheets, M to inspect the mirror or L to inspect the lock";
			if (Input.GetKeyDown(KeyCode.S))
			{	current_state = State.sheets;
			}
			else if (Input.GetKeyDown(KeyCode.M))
			{	current_state = State.mirror;
			}
			else if (Input.GetKeyDown(KeyCode.L))
			{	current_state = State.lock_0;
			}
		}

	void sheets_method ()
	{	text.text = "Your sheets are dirty. Press R to return";				
		if (Input.GetKeyDown(KeyCode.R))
		{	current_state = State.cell;
		}
	}
	
	void mirror_method ()
	{	text.text = "You are at the mirror. It is broken. Press T to take a broken glass, press R to return";
		if (Input.GetKeyDown(KeyCode.T))
		{	current_state = State.cell_mirror;
		}
		else if (Input.GetKeyDown(KeyCode.R))
		{	current_state = State.cell;
		}
	}
	
	void lock_0_method ()
	{	text.text = "It is closed from outside. Maybe you could try to force it with some tools. Press R to return";
		if (Input.GetKeyDown(KeyCode.R))
		{	current_state = State.cell;
		}
	}
	
	void cell_mirror_method ()
	{	text.text = "You hold the mirror glass with your hands. Press R to return";
		if (Input.GetKeyDown(KeyCode.R))
		{	current_state = State.cell;
		}
	}
	
}

