using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallHandler : MonoBehaviour
{
    public static float rotationSpeed = 75f;
    public static float rotationTime = 3;
    public static int currentCircleNo;

    public static Color oneColor;
    public GameObject ball;

    private float speed = 100;
    private int ballsCount;
    private int circleNo;

    private Color[] ChangingColors;

    public SpriteRenderer spr;
    public Material splashMat;
    
    void Start()
    {
       ResetGame();
        
    }

    
    void Update()
    {
        if (Input.GetMouseButtonDown(0) || Input.GetKeyDown(KeyCode.Space))
        {
            Hitball();
        }
    }


    void ResetGame()
    {

        ChangingColors = ColorScript.colorArray;
        oneColor = ChangingColors[0];
        spr.color = oneColor;
        splashMat.color = oneColor;

        GameObject gameObject2 = Instantiate(Resources.Load("round" + Random.Range(1, 4))) as GameObject;
        gameObject2.transform.position = new Vector3(0, 20, 23);
        gameObject2.name = "Circle" + circleNo;


        ballsCount = LevelsHandler.ballsCount;

        currentCircleNo = circleNo;
        LevelsHandler.currentColor = oneColor;

        MakeHurdles();
    }


    public void Hitball()
    {   
        if (ballsCount <= 1)
        {
            base.Invoke("MakeNewCircle", 0.4f);
            //Disable Button for some time
        }

        ballsCount--;

        GameObject gameObject = Instantiate<GameObject>(ball,new Vector3(0,0,-8), Quaternion.identity);
        gameObject.GetComponent<MeshRenderer>().material.color = oneColor;
        gameObject.GetComponent<Rigidbody>().AddForce(Vector3.forward * speed, ForceMode.Impulse);
    }

    void MakeNewCircle()
    {
        GameObject[] array = GameObject.FindGameObjectsWithTag("circle");
        GameObject gameObject = GameObject.Find("Circle" + circleNo);

        for (int i = 0; i < 24; i++)
        {
            gameObject.transform.GetChild(i).gameObject.SetActive(false);
        }

        gameObject.transform.GetChild(24).gameObject.GetComponent<MeshRenderer>().material.color = BallHandler.oneColor;

        if (gameObject.GetComponent<iTween>())
        {
            gameObject.GetComponent<iTween>().enabled = false;
        }
        foreach(GameObject target in array)
        {
            iTween.MoveBy(target, iTween.Hash(new object[]
            {
                "y",
                -2.98f,
                "easetype",
                iTween.EaseType.spring,
                "time",
                0.5
            }));
        }
        this.circleNo++;

        currentCircleNo = circleNo;


        GameObject gameObject2 = Instantiate(Resources.Load("round" + Random.Range(1,4))) as GameObject;
        gameObject2.transform.position = new Vector3(0, 20, 23);
        gameObject2.name = "Circle" + circleNo;


        ballsCount = LevelsHandler.ballsCount;
        

        oneColor = ChangingColors[circleNo];
        spr.color = oneColor;
        splashMat.color = oneColor;

        LevelsHandler.currentColor = oneColor;

        MakeHurdles();

        
    }


    void MakeHurdles()
    {
        if (circleNo == 1)
        {
            FindObjectOfType<LevelsHandler>().MakeHurdles1();
        }

        if (circleNo == 2)
        {
            FindObjectOfType<LevelsHandler>().MakeHurdles2();
        }

        if (circleNo == 3)
        {
            FindObjectOfType<LevelsHandler>().MakeHurdles3();
        }

        if (circleNo == 4)
        {
            FindObjectOfType<LevelsHandler>().MakeHurdles4();
        }

        if (circleNo == 5)
        {
            FindObjectOfType<LevelsHandler>().MakeHurdles5();
        }

    }   


}
