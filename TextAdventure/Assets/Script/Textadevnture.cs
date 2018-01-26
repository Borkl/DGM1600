using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Textadevnture : MonoBehaviour {

    public enum States { cell, window, gate, bed, go, continuing };
    public States currentState;
    public Text textobject;
    
	void Start () {
        currentState = States.cell;
	}
	

	void Update () {
		if (currentState == States.cell)
        {
            Cell();
        }
        if (currentState == States.window)
        {
            Window();
        }
	}
    private void Cell()
    {
        print("You are in a jail cell. It is gross and crusty. You don't remeber why you are in here. " +
              textobject.text = "There is a Window. " +
              "There is a Gate. " +
              " There is a Bed. " +
              "Press W for Window, G for Gate, B for Bed. ");
        if (Input.GetKeyDown(KeyCode.W)) { currentState = States.window; }
        if (Input.GetKeyDown(KeyCode.G)) { currentState = States.gate; }
        if (Input.GetKeyDown(KeyCode.B)) { currentState = States.bed; }
    }
    private void Window()
    {
        print("You can see the exit and several prisoners exercising, and doing other activities...no one likes a snitch " +
              "Press G to Go back to your cell " +
              "Press C to Continue looking at the window " +
              "Press G for Go back, C for Continuing. ");
        if (Input.GetKeyDown(KeyCode.G)) { currentState = States.go; }
        if (Input.GetKeyDown(KeyCode.C)) { currentState = States.continuing; }
       
    }
}
