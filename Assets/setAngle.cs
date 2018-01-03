using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class setAngle : MonoBehaviour {
    float value = 60f;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void addAngle()
    {
         value+= 10f;
        GetComponent<Image>().material.SetFloat("_Angle",value);
    }
}
