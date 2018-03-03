using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shoot : MonoBehaviour {

    public GameObject projectileprefab; 

    private List<GameObject> Projectiles = new List<GameObject>();

    private float projectilevelocity;

	// Use this for initialization
	void Start ()
    {
        projectilevelocity = 2;	
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetButtonDown("Jump"))
        {
            GameObject bullet = (GameObject)Instantiate(projectileprefab, transform.position, Quaternion.identity);
            Projectiles.Add(bullet);
        }

        for(int i = 0; i < Projectiles.Count; i++)
        {
            GameObject goBullet = Projectiles[i];
            if (goBullet != null)
                goBullet.transform.Translate(new Vector3(1, 0) * Time.deltaTime  * projectilevelocity);

        }
	}
}
