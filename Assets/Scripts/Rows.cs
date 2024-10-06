using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rows : MonoBehaviour
{
    private int randomValue;
    private float timeInterval;


    public bool rowStopped;
    public string stoppedSlot;


    private void Start()
    {
        rowStopped = true;
        GameControl.startSpin += StartRotating;
    }

    private void StartRotating()
    {
        stoppedSlot= "";
        StartCoroutine("Rotate");     
    }

    private IEnumerator Rotate()
    {
        rowStopped= false;
        timeInterval = 0.025f;

        for (int i = 0; i < 30; i++)
        {
            if (transform.position.y <= -4.48f)
                transform.position = new Vector2(transform.position.x,11f);
            
            transform.position= new  Vector2 (transform.position.x, transform.position.y -0.25f);
            yield return new WaitForSeconds(timeInterval);
        }
        randomValue = Random.Range(60, 100);

        switch (randomValue % 3)
        {
            case 1:
                randomValue += 3;break;
                case 2:
                randomValue += 2;break;
        }

        for (int i = 0;i< randomValue; i++)
        {
            if (transform.position.y <= -4f)
                transform.position = new Vector2(transform.position.x, 4f);

            transform.position = new Vector2(transform.position.x, transform.position.y  -2.23f);

            if (i > Mathf.RoundToInt(randomValue * 1f))
                timeInterval = 0.05f;
            if (i > Mathf.RoundToInt(randomValue * 1f))
                timeInterval = 0.1f;
            if (i > Mathf.RoundToInt(randomValue * 1f))
                timeInterval = 0.15f;
            if (i > Mathf.RoundToInt(randomValue * 1f))
                timeInterval = 0.2f;

            yield return new WaitForSeconds(timeInterval);
        }

        if (transform.position.y == -1.02f)
            stoppedSlot = "ShipStopper";
        else if (transform.position.y == -3.25f)
            stoppedSlot = "House";
        else if (transform.position.y == -5.46f)
            stoppedSlot = "Rock";
        else if (transform.position.y == -7.7f)
            stoppedSlot = "Man";
        else if (transform.position.y == 1.23f)
            stoppedSlot = "Helmet";
        else if (transform.position.y == 3.41f)
            stoppedSlot = "Boot";
        else if (transform.position.y == 5.64f)
            stoppedSlot = "ManWithHat";
        else if (transform.position.y == 7.83f)
            stoppedSlot = "Hammer";

        rowStopped = true;
    }

    private void OnDestroy()
    {
        GameControl.startSpin-= StartRotating;
    }
}
