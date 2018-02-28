using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControllerScript : MonoBehaviour {

    public int cellCount;

    int[] pathID = { 151, 152, 153, 154, 155, 156, 157, 158, 159, 160, 161, 162,
    187, 212, 237, 262, 263, 264, 265, 266, 267, 268, 269, 270, 271, 272, 273, 274, 275};

    List<CellScript> AllCells = new List<CellScript>();

    public GameObject cellPref;
    public Transform cellGroup;

	// Use this for initialization
	void Start () {
        CreateCells();
        CreatePath();
	}

    void CreateCells()
    {
        for (int i = 0; i < cellCount; i++)
        {
            GameObject tempCell = Instantiate(cellPref);
            tempCell.transform.SetParent(cellGroup, false);
            tempCell.GetComponent<CellScript>().id = i + 1;
            tempCell.GetComponent<CellScript>().SetState(0);
            AllCells.Add(tempCell.GetComponent<CellScript>());
        }
    }

    void CreatePath()
    {
        for (int i = 0; i < pathID.Length; i++)
        {
            AllCells[pathID[i] - 1].SetState(1);
        }
    }
}
