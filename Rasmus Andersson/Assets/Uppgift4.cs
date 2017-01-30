using UnityEngine;
using System.Collections;

public class Uppgift4 : MonoBehaviour {
    // I create variables
    public float a;
    public float b;
    public float c;
    // Use this for initialization
   void Start () {
        // A is 5 less than b
        a = b - 5;
        // Im saying that if c is less than b and that if a is less then c it should type out memeaf in console.  
        if (c < b && c > a) Debug.Log("memeaf");
    }

	// Update is called once per frame
	void Update () {
	
	}
}
