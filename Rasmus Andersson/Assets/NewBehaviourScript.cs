using UnityEngine;
using System.Collections;

public class NewBehaviourScript : MonoBehaviour
{
    // I give the ints a value. 

    public int number1 = 1;
    public int number2 = 2;
    private int number3 = 0;
    private int number4 = 0;

    // Use this for initialization
    void Start()     
    {
        // I give meme and meme 2 opposite values
        number3 = number1;
        number4 = number2;
        number1 = number4;
        number2 = number3;

    }
	
}

