using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoyAni : MonoBehaviour
{
    public float VelX, VelZ;
    Animator Ani;

    // Start is called before the first frame update
    void Start()
    {
        Ani = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.LeftShift) && VelZ <= 1f)
        {
            VelZ += 0.5f * Time.deltaTime;
        }
        else if (Input.GetKey(KeyCode.W) && VelZ <= 0.5f)
        {
            VelZ += 0.5f * Time.deltaTime;
        }
        else if (VelZ >= 0)
        {
            VelZ -= 0.5f * Time.deltaTime;
        }
        else if (Input.GetKey(KeyCode.S) && Input.GetKey(KeyCode.LeftShift) && VelZ >= -1f)
        {
            VelZ -= 0.5f * Time.deltaTime;
        }
        else if (Input.GetKey(KeyCode.S) && VelZ >= -0.5f)
        {
            VelZ -= 0.5f * Time.deltaTime;
        }
        else if (VelZ <= 0)
        {
            VelZ += 0.5f * Time.deltaTime;
        }


        if (Input.GetKey(KeyCode.A) && Input.GetKey(KeyCode.LeftShift) && VelX >= -1f)
        {
            VelX -= 0.5f * Time.deltaTime;
        }
        else if (Input.GetKey(KeyCode.A) && VelX >= -0.5f)
        {
            VelX -= 0.5f * Time.deltaTime;
        }
        else if (VelX <= 0)
        {
            VelX += 0.5f * Time.deltaTime;
        }
        else if (Input.GetKey(KeyCode.D) && Input.GetKey(KeyCode.LeftShift) && VelX <= 1f)
        {
            VelX += 0.5f * Time.deltaTime;
        }
        else if (Input.GetKey(KeyCode.D) && VelX <= 0.5f)
        {
            VelX += 0.5f * Time.deltaTime;
        }
        else if (VelX >= 0)
        {
            VelX -= 0.5f * Time.deltaTime;
        }


        if (Input.GetKeyDown(KeyCode.Space))
        {
            Ani.SetTrigger("Jump");
        }

        Ani.SetFloat("VelocityX", VelX);
        Ani.SetFloat("VelocityZ", VelZ);
    }
}
