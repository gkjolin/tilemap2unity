using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camerfallow : MonoBehaviour
{
    public Transform Target;
    public Camera myCamera;
    public float smooth = 5F;

    // Use this for initialization
    void Start()
    {

        myCamera.orthographicSize = (Screen.height / 1000f) * 5;
    }
    private float m_fTime = 0;
    // Update is called once per frame
    void Update()
    {
        Vector3 lerp = Vector3.Lerp(transform.position, Target.position, Time.deltaTime * smooth);
        transform.position = lerp + new Vector3(0, 0, -10);

        if (transform.position == Target.position)
        {
            Debug.Log(Time.time);
        }

    }
}
