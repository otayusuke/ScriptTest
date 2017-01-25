using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss
{
    public int mp = 53;
    public void Magic()
    {
        for(int i = 5; i<this.mp; i=5)
        {
            this.mp -= i;
            Debug.Log("魔法攻撃をした。残りMPは" + this.mp);
            if (this.mp < 5)
            { Debug.Log("MPが足りないため魔法が使えない。"); }
        }
    }
}

public class NewBehaviourScript : MonoBehaviour {

	// Use this for initialization
	void Start ()
    {
        Boss Mboss = new Boss();
        Mboss.Magic();

        int[] array = { 10, 20, 30, 40, 50 };
        foreach (int n in array)
        {
            Debug.Log(n);
        }
        for(int i = 4; i >= 0; i--)
        {
            Debug.Log(array[i]);
        }

    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
