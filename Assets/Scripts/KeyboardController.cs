using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class KeyboardController : MonoBehaviour
{
    public FrogControll frogController;
    public FrogControll Controller;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void Movingforward()
    {
        frogController.MoveForward();
        Controller.MoveForward();
    }

    public void Movingbackward()
    {
        frogController.MoveBackward();
        Controller.MoveBackward();
    }

    public void Movingleft()
    {
        frogController.MoveLeft();
    }

    public void Movingright()
    {
        frogController.MoveRight();
    }

    public void Jumping()
    {
        frogController.MoveUp();
    }
}
