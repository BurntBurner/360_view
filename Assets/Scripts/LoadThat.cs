using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;

public class LoadThat : MonoBehaviour {
    public float slowdown;
    public bool Clock;
    private SpriteRenderer rendSprite;
    public bool CoroutineToggle;
    

    // Use this for initialization
    void Start () {


        
        StartCoroutine(Fade());
        InvokeRepeating("Increase", 1, .05f);
	    
	}
	
    IEnumerator Fade()
    {
       float FillBar;
        while (CoroutineToggle)
        {
            Clock = true;
            GetComponent<Image>().fillClockwise = Clock;

            for (float i = 0; i <= 1; i += 0.01f)
            {

                FillBar = (float)Math.Round(i, 2);
                GetComponent<Image>().fillAmount = FillBar;

                yield return new WaitForSeconds(slowdown);
                //Debug.Log(FillBar);

            }


            

         
            Clock = false;
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

    void RotateRect()
    {
         

    }

    void Increase()
    {


        float rotateThis = 0; 
        rotateThis -= 1;

        
        Vector3 RectRotate = new Vector3(0, 0, rotateThis);
        GetComponent<RectTransform>().eulerAngles += RectRotate; 
        //Debug.Log(RectRotate);

    }

	// Update is called once per frame
	void Update () {

        



    }
}
