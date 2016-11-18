using UnityEngine;
using System.Collections;

public class Beziercurve : MonoBehaviour
{
    public Transform OrginPoint, EndPoint, OrginPointControl, EndPointControl;
    Vector3 Vec3_OrginPoint, Vec3_EndPoint, Vec3_OrginPointControl, Vec3_EndPointControl;
    LineRenderer line;
    public int numberOfsegInLine = 10;
    // Update is called once per frame
    public void Start()
    {
        Vec3_OrginPoint = OrginPoint.position;
        Vec3_EndPoint = EndPoint.position;
        Vec3_OrginPointControl = OrginPointControl.position;
        Vec3_EndPointControl = EndPointControl.position;
        line = GetComponent<LineRenderer>();
        //EndPoint.transform.position = cam.ScreenToWorldPoint(new Vector3(0, 0, 38.5f));
        //OrginPointControlObj.transform.position = OrginPoint;
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
            Vector3 pos = Mathf.Pow((1 - t), 3) * Vec3_OrginPoint + 3 * Mathf.Pow((1 - t), 2) * t * Vec3_OrginPointControl + 3 * (1 - t) * Mathf.Pow(t, 2) * Vec3_EndPointControl + Mathf.Pow(t, 3) * Vec3_EndPoint;
            line.SetPosition(i, pos);
        }

    }
}
