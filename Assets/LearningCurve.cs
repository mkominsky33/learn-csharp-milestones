using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearningCurve : MonoBehaviour
{

  public int testNum = 0;

  public float testFloat = 0;

  public string testString = "hello";

  public bool testBool = false;
    // Start is called before the first frame update
    void Start()
    {

      Debug.Log("Test num: " + testNum);
      Debug.Log("Test num: " + testNum + "\n test float: "+ testFloat);

      Debug.Log(Method(testNum));
    }

    // Update is called once per frame
    void Update()
    {

    }


    int Method(int methodNum){

      return methodNum + 1;
    }
}
