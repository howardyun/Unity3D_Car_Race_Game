using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class A : MonoBehaviour
{


    private AndroidJavaObject aObj = null;
    // Start is called before the first frame update

       private void   Awake()
    {
        AndroidJavaClass aclass = new AndroidJavaClass("com.unity3d.player.UnityPlayer");
        aObj = aclass.Get<AndroidJavaObject>("currentActivity");

    }
    void Start()
    {
        


    }

    // Update is called once per frame
    void Update()
    {
        if (aObj != null)

        {

            aObj.Call("CallUnityMethod", "testString");

        }
    }


    public void UnityMethod(string str)

    {

        Debug.Log("android called unityMethodparam:" + str);

    }


}
