using UnityEngine;
using System.Collections;

public class MainMenuRotation : MonoBehaviour
{

	// Use this for initialization
	void Start ()
    {
        //Time.timeScale = Time.deltaTime;
	}
	
	// Update is called once per frame
	void Update ()
    {
        transform.Rotate(0, transform.position.y + .05f, 0);
    }
}
