using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearningCurve : MonoBehaviour
{

  public int testNum = 0;

  public float testFloat = 0;

  public string testString = "hello";

  public bool testBool = false;

  int[] arr = new int[5];

  List<string> str = new List<string>();


    // Start is called before the first frame update
    void Start()
    {

      Debug.Log("Test num: " + testNum);
      Debug.Log("Test num: " + testNum + "\n test float: "+ testFloat);

      Debug.Log(Method(testNum));

      if (testNum > testFloat)
      {
        Debug.Log("num is bigger than float");
      }
      else if (testBool != true)
      {
        Debug.Log("not anymore");
      }
      else
      {
        Debug.Log(testBool);
      }

      switch (testNum){

        case < 1:
          Debug.Log("case 1");
          break;

        case > 1:
          Debug.Log("case 2");
          break;

        default:
          Debug.Log("no match found");
          break;


      str.Add("hello");
      str.Add("what");

      for (int x = 0; x < str.size() ; x++) {

      }
      }


    }

    // Update is called once per frame
    void Update()
    {

    }


    int Method(int methodNum){

      return methodNum + 1;
    }
}
