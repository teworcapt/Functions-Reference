using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class Quaternions : MonoBehaviour
{
    public Quaternion currentRotation;
    public Vector3 currenteulerAngles;
    public float rotSpeed;
    public Transform targetA,targetB;
    float x, y, z;
    float timeCount = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
        //transform.rotation = Quaternion.Euler(0, 0, 0);
        //transform.rotation = Quaternion.identity;
    }

    // Update is called once per frame
    void Update()
    {
        //RotationInputs();
        //QuarternionRotateTowards();
        LookRotation();
    }

    private void OnGUI()
    {
        GUIStyle style = new GUIStyle();
        style.fontSize = 28;
        //Use the Euler angles to show the euler angles of the transform rotation

        GUI.Label(new Rect(10, 0, 0, 0), "Rotating On X : " + x + " Y : " + y + " Z : " + z , style);

        //Outpus the Quernion.euler angle values
        GUI.Label(new Rect(10, 25, 0, 0), "Current Euler Angles : " + currenteulerAngles, style);

        //Outpus the transform.eulerAngles of the GameObject
        GUI.Label(new Rect(10, 50, 0, 0), "Game Object World Euler Angles : " + transform.eulerAngles, style);
    }

    void RotationInputs()
    {
        if(Input.GetKeyDown(KeyCode.X)) { x = 1 - x; }
        if (Input.GetKeyDown(KeyCode.Y)) { y = 1 - y; }
        if (Input.GetKeyDown(KeyCode.Z)) { z = 1 - z; }

        currenteulerAngles += new Vector3(x, y, z) * Time.deltaTime * rotSpeed;
        currentRotation.eulerAngles = currenteulerAngles;
        transform.rotation = currentRotation;
    }

    void QuarternionRotateTowards()
    {
        //just replicates game object 1's rotation
        var step = rotSpeed * Time.time;
        transform.rotation =
        Quaternion.RotateTowards(transform.rotation, targetA.rotation, step);
    }

    void QuaternionSlerp()
    {
        transform.rotation = Quaternion.Slerp(targetA.rotation, targetB.rotation, timeCount);
        timeCount = timeCount + Time.deltaTime;
    }

    void LookRotation()
    {
        Vector3 relativePos = targetA.position - transform.position;
        Quaternion rotation = Quaternion.LookRotation(relativePos, Vector3.up);
        transform.rotation = rotation;
    }
}
