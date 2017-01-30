using UnityEngine;
using System.Collections;

public class NewBehaviourScript : MonoBehaviour {
    // I give the ints a value. 
    public int meme = 1;
    public int meme2 = 2;
    private int meme3 = 0;
    private int meme4 = 0;
    // Use this for initialization
    void Start()
        // I give meme and meme 2 opposite values
    {
        meme3 = meme;
        meme4 = meme2;
        meme = meme4;
        meme2 = meme3;

    }




	// Update is called once per frame
	void Update () {
	
	}
}
