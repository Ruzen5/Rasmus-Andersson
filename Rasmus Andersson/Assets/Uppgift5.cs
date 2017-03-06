using UnityEngine;
using System.Collections;

public class Uppgift5 : MonoBehaviour
{
    // I create variables and give them values.
    public int a = 10;
    public int b = 5;
    private int c;
    public float d = 10;
    public float e = 0;
    
    //Its a method
    int Method(int a, int b)
    {
        return a + b;
        
    }
    // Use this for initialization
    void Start()
    {
        //Prints if c is bigger than d and smaller than e.
        c = Method(a, b);
        if (c < e && c > d)
         Debug.Log("C is bigger than d and smaller than e");
        
        
        else
        {
            //Prints if c is bigger than e or smaller than d. 
            Debug.Log("C is bigger than e or smaller than d");
        }
        
    }


}

