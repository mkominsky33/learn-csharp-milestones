using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearningCurve : MonoBehaviour
{

  public int testNum = 5;

  public float testFloat = 0;

  public string testString = "hello";

  public bool testBool = false;

  int[] arr = new int[5];

  List<string> str = new List<string>();

  Dictionary<string, int> dict = new Dictionary<string, int>
        {
            { "key1", 0 },
            { "key2", 1 }
        };


    // Start is called before the first frame update
    void Start()
    {
      Character hero = new Character();
      Character heroine = new Character("Jade");

      Debug.LogFormat("Hero: {0} - {1} EXP", heroine.name, heroine.exp);

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

      str.Add("hello");
      str.Add("what");

      switch (testNum) {

        case 1:
            Debug.Log("case 1");
            break;

        case 5:
            Debug.Log("case 5");
            break;

        case 9:
            Debug.Log("case 9");
            break;

        default:
            Debug.Log("No match found");
            break;
        }
        for (int i = 0; i < 1; i++)
          {
            Debug.Log(str[i]);
          }

        foreach(string s in str)
            {
                Debug.Log(s);
            }

        foreach(var (key, value) in dict)
          {
            int i =1;
        // do something with entry.Value or entry.Key
            Debug.Log("key: " + key + " value: "+ value);
            i++;
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
