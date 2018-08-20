using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;

public class LoadThatReverse : MonoBehaviour {
    public float slowdown;
    public bool Clock;
    private SpriteRenderer rendSprite;


    // Use this for initialization
    void Start()
    {


        StartCoroutine(FadeReverse());

    }

    IEnumerator FadeReverse()
    {
        float FillBar;
        while (true)
        {
            Clock = false;
            GetComponent<Image>().fillClockwise = Clock;

            for (float i = 0; i <= 1; i += 0.01f)
            {

                FillBar = (float)Math.Round(i, 2);
                GetComponent<Image>().fillAmount = FillBar;

                yield return new WaitForSeconds(slowdown);
                //Debug.Log(FillBar);

            }

            Clock = true;
            GetComponent<Image>().fillClockwise = Clock;

            for (float c = 1; c >= 0; c -= 0.01f)
            {

                FillBar = (float)Math.Round(c, 2);
                GetComponent<Image>().fillAmount = FillBar;

                yield return new WaitForSeconds(slowdown);
                //Debug.Log(FillBar);

            }
        }
    }
}
