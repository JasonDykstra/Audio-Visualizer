using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParamCube : MonoBehaviour {
    public int _band;
    public float _startScale, _scaleMultiplier;
    

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        //if (_useBuffer)
        //{

        if (AudioPeer._audioBandBuffer[_band] * _scaleMultiplier > 0)
        {
            transform.localScale = new Vector3(transform.localScale.x, (AudioPeer._audioBandBuffer[_band] * _scaleMultiplier) + _startScale, transform.localScale.z);
            Vector3 pos = transform.position;
            //move the y pos, again
            transform.position = new Vector3(pos.x, ((AudioPeer._audioBandBuffer[_band] * _scaleMultiplier) + _startScale) / 2, pos.z);
        }
        /*} else if (!_useBuffer)
        {
            transform.localScale = new Vector3(transform.localScale.x, (AudioPeer._freqBand[_band] * _scaleMultiplier) + _startScale, transform.localScale.z);
            Vector3 pos = transform.position;
            //move the y pos, again
            transform.position = new Vector3(pos.x, ((AudioPeer._freqBand[_band] * _scaleMultiplier) + _startScale) / 2, pos.z);
        }
        */
        
	}
}
