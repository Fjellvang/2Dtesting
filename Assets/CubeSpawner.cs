using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeSpawner : MonoBehaviour {

    public GameObject toSpawn;
    public int xval = 10;
    public int yval = 10;
    public float offsetx = 5f;
    public float offsetz = -1f;

	void SpawnCubes() {
		Vector3 pos;
		for(int i = 0; i < xval; i++) {
			for(int j = 0; j < yval; j++){
                float x = i - offsetx;
                float z = j - offsetz;
                pos = new Vector3(x, 0, z);
                GameObject obj = GameObject.Instantiate(toSpawn, pos, Quaternion.identity, transform);
                if ((i + j) % 2 == 0)
                {
                    obj.GetComponentInChildren<Renderer>().material.color = new Color(0, 0, 0);
                }
                //if ((i+j) / (xval + yval) / 4)
			}
		}
	}


	// Use this for initialization
	void Start () {
        SpawnCubes();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
