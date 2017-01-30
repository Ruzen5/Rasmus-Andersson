using UnityEngine;
using System.Collections;

public class Uppgift2 : MonoBehaviour {
    // I create 2 variables. 
    public int a;
    public int b;
	// Use this for initialization
	void Start () {
    // I give the variables a value
    a = 1;
    b = 2;
    // Here i make it so that if b has a higher value than a the console types out Its lit
    if (b > a) Debug.Log("itslit");


	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
