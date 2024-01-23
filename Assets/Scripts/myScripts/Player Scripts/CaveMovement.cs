using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class CaveMovement : MonoBehaviour
{
    public float xSpeed;
    public bool cave;
    private float xDirection; 
    private float xVector;
    private float yDirection;
    private float yVector;

    public float ySpeed;
    // Start is called before the first frame update
    void Start()
    {
        xSpeed = 4;
        ySpeed = 4;
    }

    // Update is called once per frame
    void Update()
    {
        string currentScene = UnityEngine.SceneManagement.SceneManager.GetActiveScene().name;
        if (currentScene == "Overworld")
        {
            cave = false;
        }
        else
        {
            cave = true;
        }

        if (cave)
        {
            ySpeed = 0;
        }

        xDirection = Input.GetAxis("Horizontal");
        yDirection = Input.GetAxis("Vertical");
        yVector = yDirection * ySpeed * Time.deltaTime;
        xVector = xDirection * xSpeed * Time.deltaTime;
        transform.position = transform.position + new Vector3(xVector, yVector, 0);
    }
}
