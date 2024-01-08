using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class cOFfe : MonoBehaviour
{

    float coffeeTempurature = 85.0f;
    float hotLiimitTempurature = 70.0f;
    float coldLimitTempurature = 40.0f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
            TempuratureTest();

        coffeeTempurature -= Time.deltaTime * 5.0f;
    }

    void TempuratureTest()
    {
        if (coffeeTempurature > hotLiimitTempurature)
        { 

            print("Coffee is too hot.");
        }

        
            if (coffeeTempurature < hotLiimitTempurature) 
        

        {
            print("Coffee is too cold.");
        }
        else
        {
            print("coffee is just right.");
        }
    }
  }

