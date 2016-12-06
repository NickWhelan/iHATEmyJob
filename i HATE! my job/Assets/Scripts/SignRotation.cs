using UnityEngine;
using System.Collections;

public class SignRotation : MonoBehaviour
{
    public GameObject sign;
    public Quaternion rotation;

    public float deg = 30.0f;
    float rad;
	// Use this for initialization
	void Start ()
    {
        rad = deg * Mathf.Deg2Rad;
	}
	
	// Update is called once per frame
	void Update ()
    {
        //deg++;
        rad = deg * Mathf.Deg2Rad;
        transform.Rotate(0, rad, 0);
	}
}
