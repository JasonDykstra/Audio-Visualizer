using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instantiate512Cubes : MonoBehaviour {

    public GameObject _sampleCubePrefab;
    GameObject[] _sampleCube = new GameObject[512];
    public float _maxScale;
    

	// Use this for initialization
	void Start () {

        
        

        for(int i = 0; i < 512; i++)
        {
            GameObject _instanceSampleCube = (GameObject)Instantiate(_sampleCubePrefab);
            _instanceSampleCube.transform.position = this.transform.position;
            _instanceSampleCube.transform.parent = this.transform;
            _instanceSampleCube.name = "SamepleCube " + i;
            //make them stand in a circle initially
            this.transform.eulerAngles = new Vector3(0, -0.703125f * i, 0);
            _instanceSampleCube.transform.position = Vector3.forward * 100;
            //initialize array
            _sampleCube[i] = _instanceSampleCube;
        }

	}
	
	// Update is called once per frame
	void Update () {
		
        for(int i = 0; i < 512; i++)
        {
            if(_sampleCube != null)
            {
                Vector3 pos = _sampleCube[i].transform.position;
                _sampleCube[i].transform.localScale = new Vector3(1, (AudioPeer._samples[i] * _maxScale) + 2, 1);
                //make it so that the cubes move upwards halfway the amount they scale, so it only looks like its scaling upwards, not through the floor
                _sampleCube[i].transform.position = new Vector3(pos.x, (AudioPeer._samples[i] * _maxScale + 2) / 2, pos.z);
            }
        }

	}
}
