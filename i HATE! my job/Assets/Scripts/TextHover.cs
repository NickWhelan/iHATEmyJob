using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class TextHover : MonoBehaviour
{
    public Text text;
    public Vector3 textScale;
    public Color color;
	// Use this for initialization
	void Start ()
    {
        text = GetComponent<Text>();
        textScale = text.transform.localScale;
        color = text.color;
	}
	
	// Update is called once per frame
	void Update ()
    {
	    
	}

    public void Hover()
    {
        text.transform.localScale = new Vector3(1.8f, 1.8f, 0);
    }

    public void DeHover()
    {
        text.transform.localScale = textScale;
    }

    public void ColorClickDown()
    {
        Debug.Log("Clicking");
        text.color = new Vector4(0.9f, 0.5f, 0.5f, 1);
    }

    public void ColorClickUp()
    {
        text.color = color;
    }

    public void LoadGame()
    {
        //Application.LoadLevel("MainGame");
        Application.LoadLevel("TestingFeild");
    }

    public void LoadOptions()
    {
        Application.LoadLevel("Options");
    }

    public void Quit()
    {
        Application.Quit();
    }
}
