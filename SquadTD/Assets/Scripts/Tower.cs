using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tower : MonoBehaviour {

    float shotTimer = 3.0f;
    float range = 20.0f;
    float damage = 5.0f;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {

        if (findEnemiesInRange().Count > 0)
        {
            //probably some behaviour deciding which target to fire at
            Shoot();
        }

	}

    protected List<GameObject> findEnemiesInRange()
    {
        List<GameObject> enemiesInRange = new List<GameObject>();

        foreach (GameObject obj in FindObjectsOfType(typeof(GameObject)))
        {
            if (Vector2.Distance(obj.transform.position, this.transform.position) < range)
            {
                enemiesInRange.Add(obj);
            }
        }
        return enemiesInRange;
    }

    protected void Shoot()
    {
        //fire projectile
    }
}
