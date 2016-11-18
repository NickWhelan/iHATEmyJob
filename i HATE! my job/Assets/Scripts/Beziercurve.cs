using UnityEngine;
using System.Collections;

public class Beziercurve : MonoBehaviour
{
    public Transform OrginPoint, EndPoint, OrginPointControl, EndPointControl;
    LineRenderer line;
    public int numberOfsegInLine = 10;
    // Update is called once per frame
    public void Start()
    {
        line = GetComponent<LineRenderer>();
        line.SetVertexCount(numberOfsegInLine);
    }
    void Update()
    {
        //OrginPointControl = OrginPointControlObj.position;
        // EndPointControl = EndPointControlObj.position;
        for (int i = 0; i < numberOfsegInLine; ++i)
        {
            float t = (float)i / (float)(numberOfsegInLine - 1);
            // Bezier curve function
            Vector3 pos = Mathf.Pow((1 - t), 3) * OrginPoint.position + 3 * Mathf.Pow((1 - t), 2) * t * OrginPointControl.position + 3 * (1 - t) * Mathf.Pow(t, 2) * EndPointControl.position + Mathf.Pow(t, 3) * EndPoint.position;
            line.SetPosition(i, pos);
        }

    }
}
