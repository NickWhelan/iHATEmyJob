using UnityEngine;
using System.Collections;

public class SecuirtyCam : MonoBehaviour {
    Quaternion startingAngle;
    public Vector3 EndingAngle;
    public float turningSpeed =1;
    bool Towards;
	// Use this for initialization
	void Start () {
        startingAngle = transform.rotation;
        Towards = true;
    }
	
	// Update is called once per frame
	void Update () {
        if (Towards)
        {
            transform.rotation = Quaternion.RotateTowards(transform.rotation, Quaternion.Euler(EndingAngle), turningSpeed);
            if (transform.rotation == Quaternion.Euler(EndingAngle)) {
                Towards = false;
            }
        }
        else {
            transform.rotation = Quaternion.RotateTowards(transform.rotation,startingAngle, turningSpeed);
            if (transform.rotation == startingAngle)
            {
                Towards = true;
            }
        } 
	}
}
