using UnityEngine;
using System.Collections;

public class PlayerCamera : MonoBehaviour
{
    private float sensitivity = 0.7f;
    private float angle;

	// Use this for initialization
	void Start ()
    {
	
	}
	
	// Update is called once per frame
	void Update ()
    {
        float rotateSpeedY = -1 * (Input.GetAxis("Mouse Y") * sensitivity);

        angle = transform.eulerAngles.x;

        if (angle > 270)
        {
            angle = transform.eulerAngles.x - 360;
        }

        if (angle < 50 && angle > -30)
        {
            transform.Rotate(rotateSpeedY, 0, 0);
        }

        else if (angle >= 30 && rotateSpeedY < 0)
        {
            transform.Rotate(rotateSpeedY, 0, 0);
        }

        else if (angle <= -20 && rotateSpeedY > 0)
        {
            transform.Rotate(rotateSpeedY, 0, 0);
        }

        Debug.Log(angle);
    }
}
