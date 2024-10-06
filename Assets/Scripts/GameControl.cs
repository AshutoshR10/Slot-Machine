using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

public class GameControl : MonoBehaviour
{
    public static event Action startSpin = delegate { };

    [SerializeField]
    private Text prize;

    [SerializeField]
    private Rows[] rows;

    [SerializeField]
    private Transform button;

    private int prizeValue;

    private bool resultsChecked = false;

    private void Update()
    {
       if (!rows[0].rowStopped || !rows[1].rowStopped || !rows[2].rowStopped || !rows[3].rowStopped || !rows[4].rowStopped)
        {
            prizeValue = 0;
            prize.enabled = false;
            resultsChecked = false;
        }

        if (rows[0].rowStopped && rows[1].rowStopped && rows[2].rowStopped && rows[3].rowStopped && rows[4].rowStopped && !resultsChecked)
        {
            CheckResults();
            prize.enabled = true;
            prize.text= "Jackpot price:" + prizeValue;
            //Debug.Log(prizeValue);
        }
    }

    private void OnMouseDown()
    {
        if (rows[0].rowStopped && rows[1].rowStopped && rows[2].rowStopped && rows[3].rowStopped && rows[4].rowStopped) { StartCoroutine("PullHandle"); }
    }
    private IEnumerator PullHandle()
    {
        for (int i = 0;i < 15; i += 5)
        {
            button.Rotate(0f, 0f, -i);
            yield return new WaitForSeconds(0.01f);
        }

        startSpin();

        for (int i = 0; i < 15; i += 5)
        {
            button.Rotate(-i, 0f, -i);
            yield return new WaitForSeconds(0.01f);
        }
    }

    private void CheckResults()
    {
        if (rows[0].stoppedSlot == "ShipStopper"
            && rows[1].stoppedSlot == "ShipStopper"
            && rows[2].stoppedSlot == "ShipStopper"
            && rows[3].stoppedSlot == "ShipStopper"
            && rows[4].stoppedSlot == "ShipStopper")

            prizeValue = 200;

        else if (rows[0].stoppedSlot == "House"
            && rows[1].stoppedSlot == "House"
            && rows[2].stoppedSlot == "House"
            && rows[3].stoppedSlot == "House"
            && rows[4].stoppedSlot == "House")

            prizeValue = 400;

        else if (rows[0].stoppedSlot == "Rock"
            && rows[1].stoppedSlot == "Rock"
            && rows[2].stoppedSlot == "Rock"
            && rows[3].stoppedSlot == "Rock"
            && rows[4].stoppedSlot == "Rock")

            prizeValue = 600;

        else if (rows[0].stoppedSlot == "Man"
            && rows[1].stoppedSlot == "Man"
            && rows[2].stoppedSlot == "Man"
            && rows[3].stoppedSlot == "Man"
            && rows[4].stoppedSlot == "Man")

            prizeValue = 800;

        else if (rows[0].stoppedSlot == "Helmet"
            && rows[1].stoppedSlot == "Helmet"
            && rows[2].stoppedSlot == "Helmet"
            && rows[3].stoppedSlot == "Helmet"
            && rows[4].stoppedSlot == "Helmet")

            prizeValue = 1500;

        else if (rows[0].stoppedSlot == "Boot"
            && rows[1].stoppedSlot == "Boot"
            && rows[2].stoppedSlot == "Boot"
            && rows[3].stoppedSlot == "Boot"
            && rows[4].stoppedSlot == "Boot")

            prizeValue = 3000;

        else if (rows[0].stoppedSlot == "ManWithHat"
            && rows[1].stoppedSlot == "ManWithHat"
            && rows[2].stoppedSlot == "ManWithHat"
            && rows[3].stoppedSlot == "ManWithHat"
            && rows[4].stoppedSlot == "ManWithHat")

            prizeValue = 5000;

        else if (rows[0].stoppedSlot == "Hammer"
            && rows[1].stoppedSlot == "Hammer"
            && rows[2].stoppedSlot == "Hammer"
            && rows[3].stoppedSlot == "Hammer"
            && rows[4].stoppedSlot == "Hammer")

            prizeValue = 6000;

        else if (((rows[0].stoppedSlot == rows[1].stoppedSlot)
            && (rows[0].stoppedSlot == "ShipStopper"))

            || ((rows[0].stoppedSlot == rows[2].stoppedSlot)
            && (rows[0].stoppedSlot == "ShipStopper"))

             || ((rows[0].stoppedSlot == rows[3].stoppedSlot)
            && (rows[0].stoppedSlot == "ShipStopper"))

             || ((rows[0].stoppedSlot == rows[4].stoppedSlot)
            && (rows[0].stoppedSlot == "ShipStopper"))

            || ((rows[1].stoppedSlot == rows[4].stoppedSlot)
            && (rows[1].stoppedSlot == "ShipStopper")))

            prizeValue = 100;

        else if (((rows[0].stoppedSlot == rows[1].stoppedSlot)
           && (rows[0].stoppedSlot == "House"))

           || ((rows[0].stoppedSlot == rows[2].stoppedSlot)
           && (rows[0].stoppedSlot == "House"))

            || ((rows[0].stoppedSlot == rows[3].stoppedSlot)
           && (rows[0].stoppedSlot == "House"))

            || ((rows[0].stoppedSlot == rows[4].stoppedSlot)
           && (rows[0].stoppedSlot == "House"))

           || ((rows[1].stoppedSlot == rows[4].stoppedSlot)
           && (rows[1].stoppedSlot == "House")))

            prizeValue = 300;

        else if (((rows[0].stoppedSlot == rows[1].stoppedSlot)
           && (rows[0].stoppedSlot == "Rock"))

           || ((rows[0].stoppedSlot == rows[2].stoppedSlot)
           && (rows[0].stoppedSlot == "Rock"))

            || ((rows[0].stoppedSlot == rows[3].stoppedSlot)
           && (rows[0].stoppedSlot == "Rock"))

            || ((rows[0].stoppedSlot == rows[4].stoppedSlot)
           && (rows[0].stoppedSlot == "Rock"))

           || ((rows[1].stoppedSlot == rows[4].stoppedSlot)
           && (rows[1].stoppedSlot == "Rock")))

            prizeValue = 600;

        else if (((rows[0].stoppedSlot == rows[1].stoppedSlot)
           && (rows[0].stoppedSlot == "Man"))

           || ((rows[0].stoppedSlot == rows[2].stoppedSlot)
           && (rows[0].stoppedSlot == "Man"))

            || ((rows[0].stoppedSlot == rows[3].stoppedSlot)
           && (rows[0].stoppedSlot == "Man"))

            || ((rows[0].stoppedSlot == rows[4].stoppedSlot)
           && (rows[0].stoppedSlot == "Man"))

           || ((rows[1].stoppedSlot == rows[4].stoppedSlot)
           && (rows[1].stoppedSlot == "Man")))

            prizeValue = 800;

        else if (((rows[0].stoppedSlot == rows[1].stoppedSlot)
           && (rows[0].stoppedSlot == "Helmet"))

           || ((rows[0].stoppedSlot == rows[2].stoppedSlot)
           && (rows[0].stoppedSlot == "Helmet"))

            || ((rows[0].stoppedSlot == rows[3].stoppedSlot)
           && (rows[0].stoppedSlot == "Helmet"))

            || ((rows[0].stoppedSlot == rows[4].stoppedSlot)
           && (rows[0].stoppedSlot == "Helmet"))

           || ((rows[1].stoppedSlot == rows[4].stoppedSlot)
           && (rows[1].stoppedSlot == "Helmet")))

            prizeValue = 1600;

        else if (((rows[0].stoppedSlot == rows[1].stoppedSlot)
           && (rows[0].stoppedSlot == "ManWithHat"))

           || ((rows[0].stoppedSlot == rows[2].stoppedSlot)
           && (rows[0].stoppedSlot == "ManWithHat"))

            || ((rows[0].stoppedSlot == rows[3].stoppedSlot)
           && (rows[0].stoppedSlot == "ManWithHat"))

            || ((rows[0].stoppedSlot == rows[4].stoppedSlot)
           && (rows[0].stoppedSlot == "ManWithHat"))

           || ((rows[1].stoppedSlot == rows[4].stoppedSlot)
           && (rows[1].stoppedSlot == "ManWithHat")))

            prizeValue = 2200;

        else if (((rows[0].stoppedSlot == rows[1].stoppedSlot)
          && (rows[0].stoppedSlot == "Hammer"))

          || ((rows[0].stoppedSlot == rows[2].stoppedSlot)
          && (rows[0].stoppedSlot == "Hammer"))

           || ((rows[0].stoppedSlot == rows[3].stoppedSlot)
          && (rows[0].stoppedSlot == "Hammer"))

           || ((rows[0].stoppedSlot == rows[4].stoppedSlot)
          && (rows[0].stoppedSlot == "Hammer"))

          || ((rows[1].stoppedSlot == rows[4].stoppedSlot)
          && (rows[1].stoppedSlot == "Hammer")))

            prizeValue = 4400;
        Debug.Log(prizeValue);
        resultsChecked = true;

    }
}
