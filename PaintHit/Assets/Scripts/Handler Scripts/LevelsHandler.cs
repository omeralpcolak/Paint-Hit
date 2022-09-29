using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelsHandler : MonoBehaviour
{
    public static int currentLevel;
    public static int ballsCount;
    public static int totalCircles;

    public static Color currentColor;
    void Awake()
    {
        if (PlayerPrefs.GetInt("firstTime1",0) == 0)
        {
            PlayerPrefs.SetInt("firsTime1", 1);
            PlayerPrefs.SetInt("C_Level", 1);
            //Add more to it
        }

        UpgradeLevel();
    }

    void UpgradeLevel()
    {
        currentLevel = PlayerPrefs.GetInt("C_Level", 1);

        if (currentLevel == 1)
        {
            ballsCount = 3;
            totalCircles = 2;
        }

        if(currentLevel == 2)
        {
            ballsCount = 3;
            totalCircles = 3;
        }

        if (currentLevel == 3)
        {
            ballsCount = 3;
            totalCircles = 4;
        }

        if (currentLevel == 4)
        {
            ballsCount = 3;
            totalCircles = 5;
        }

        if (currentLevel == 5)
        {
            ballsCount = 3;
            totalCircles = 5;
        }

        if (currentLevel == 6)
        {
            ballsCount = 3;
            totalCircles = 5;
        }

        if (currentLevel == 7)
        {
            ballsCount = 3;
            totalCircles = 5;
        }

        if (currentLevel >= 8 && currentLevel <= 12)
        {
            ballsCount = 4;
            totalCircles = 5;
        }

        if (currentLevel >= 12 && currentLevel <= 20)
        {
            ballsCount = 4;
            totalCircles = 5;
            BallHandler.rotationSpeed = 135;
            BallHandler.rotationTime = 2;
        }

        if (currentLevel >= 21)
        {
            ballsCount = 5;
            totalCircles = 5;
            BallHandler.rotationSpeed = 140;
            BallHandler.rotationTime = 1;
        }
    }

    public void MakeHurdles1()
    {
        GameObject gameObject = GameObject.Find("Circle" + BallHandler.currentCircleNo);

        int index = Random.Range(0, 3);

        gameObject.transform.GetChild(index).gameObject.GetComponent<MeshRenderer>().enabled = true;
        gameObject.transform.GetChild(index).gameObject.GetComponent<MeshRenderer>().material.color = currentColor;
        gameObject.transform.GetChild(index).gameObject.tag = "red";

    }

    public void MakeHurdles2()
    {
        GameObject gameObject = GameObject.Find("Circle" + BallHandler.currentCircleNo);

        int[] array = new int[]
        {
            Random.Range(1, 3),
            Random.Range(15, 17)
        };

        for (int i = 0; i < array.Length; i++)
        {
            gameObject.transform.GetChild(array[i]).gameObject.GetComponent<MeshRenderer>().enabled = true;
            gameObject.transform.GetChild(array[i]).gameObject.GetComponent<MeshRenderer>().material.color = currentColor;
            gameObject.transform.GetChild(array[i]).gameObject.tag = "red";
        }

    }


    public void MakeHurdles3()
    {
        GameObject gameObject = GameObject.Find("Circle" + BallHandler.currentCircleNo);

        int[] array = new int[]
        {
            Random.Range(1, 3),
            Random.Range(4, 6),
            Random.Range(18,20)
        };

        for (int i = 0; i < array.Length; i++)
        {
            gameObject.transform.GetChild(array[i]).gameObject.GetComponent<MeshRenderer>().enabled = true;
            gameObject.transform.GetChild(array[i]).gameObject.GetComponent<MeshRenderer>().material.color = currentColor;
            gameObject.transform.GetChild(array[i]).gameObject.tag = "red";
        }

    }


    public void MakeHurdles4()
    {
        GameObject gameObject = GameObject.Find("Circle" + BallHandler.currentCircleNo);

        int[] array = new int[]
        {
            Random.Range(1, 3),
            Random.Range(4, 6),
            Random.Range(15,17),
            Random.Range(22,24)
        };

        for (int i = 0; i < array.Length; i++)
        {
            gameObject.transform.GetChild(array[i]).gameObject.GetComponent<MeshRenderer>().enabled = true;
            gameObject.transform.GetChild(array[i]).gameObject.GetComponent<MeshRenderer>().material.color = currentColor;
            gameObject.transform.GetChild(array[i]).gameObject.tag = "red";
        }

    }

    public void MakeHurdles5()
    {
        GameObject gameObject = GameObject.Find("Circle" + BallHandler.currentCircleNo);

        int[] array = new int[]
        {
            Random.Range(1, 3),
            Random.Range(4, 6),
            Random.Range(11,13),
            Random.Range(8,10),
            Random.Range(15,17)
        };

        for (int i = 0; i < array.Length; i++)
        {
            gameObject.transform.GetChild(array[i]).gameObject.GetComponent<MeshRenderer>().enabled = true;
            gameObject.transform.GetChild(array[i]).gameObject.GetComponent<MeshRenderer>().material.color = currentColor;
            gameObject.transform.GetChild(array[i]).gameObject.tag = "red";
        }

    }


}
