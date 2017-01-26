using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss
{
    public int mp = 53;
    public void Magic(int i)
    {
            this.mp -= i;
            Debug.Log("魔法攻撃をした。残りMPは" + this.mp);       
    }
}

public class NewBehaviourScript : MonoBehaviour {

	// Use this for initialization
	void Start ()
    {
        Boss Mboss = new Boss();
        for (int m=0;m<=10;m++)
        {
            if (m < 10)
            {
                Mboss.Magic(5);
            }
            else
            {
                Debug.Log("MPが足りないため魔法が使えない");
            }
        }
        int[] array = { 10, 20, 30, 40, 50 };
        foreach (int n in array)
        {
            Debug.Log(n);
        }
        for(int m = 4; m >= 0; m--)
        {
            Debug.Log(array[m]);
        }

    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
