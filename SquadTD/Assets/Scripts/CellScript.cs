using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CellScript : MonoBehaviour {

    public int state, id;

    public Color backColor, pathColor;

	// Use this for initialization
	void Start () {
		
	}

    public void SetState(int i)
    {
        state = i;

        if (i == 0)
        {
            GetComponent<Image>().color = backColor;
        }

        if (i == 1)
        {
            GetComponent<Image>().color = pathColor;
        }
    }
}
