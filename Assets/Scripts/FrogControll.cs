using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using static UnityEditor.PlayerSettings;

public class FrogControll : MonoBehaviour
{
    public float moveDistance = 1.0f;
    public float jumpingheight = 1.0f;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void MoveForward()
    {
        transform.position += Vector3.forward * moveDistance;
    }

    public void MoveBackward()
    {
        transform.position += Vector3.back * moveDistance;
    }

    public void MoveRight()
    {
        transform.position += Vector3.right * moveDistance;

    }

    public void MoveLeft()
    {
        transform.position += Vector3.left * moveDistance;
    }

    public void MoveUp()
    {
        transform.position += Vector3.up * jumpingheight;
    }
}
