using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class JudgeCollide : MonoBehaviour
{



    public GameObject a;
    public GameObject b;
    public GameObject []cube;
    public bool []judge_cube;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("start");

        judge_cube = new bool[6];
        int []i;
        i=GenerateRandom(3,0,5);

        for (int j = 0; j<3; j++) {

            judge_cube[i[j]] = true;

            Debug.Log(i[j]);

        }
        initial(judge_cube,6);


    }

    private void initial(bool []i,int r)
    {
        for(int j=0; j < r; j++)
        {
            if (i[j] == true)
                cube[j].SetActive(true);

            else
                cube[j].SetActive(false);


        }



        throw new NotImplementedException();
    }

    private int[] GenerateRandom(int Number,int minNum,int maxNum)
    {
        int j;
          int[] b = new int[Number];
        System.Random r = new System.Random();
           for (j = 0; j < Number; j++)
               {
               int i = r.Next(minNum, maxNum + 1);
              int num = 0;
             for (int k = 0; k < j; k++)
                   {
                    if (b[k] == i)
                        {
                        num = num + 1;
                        }
                   }
               if (num == 0)
                   {
                    b[j] = i;
                   }
               else
                   {
                    j = j - 1;
                   }
               }
           return b;






        throw new NotImplementedException();
    }

    // Update is called once per frame
    void Update()
    {



        //    Debug.Log(Math.Sqrt(Math.Pow(a.transform.position.x - b.transform.position.x, 2) + Math.Pow(a.transform.position.y - b.transform.position.y, 2) + Math.Pow(a.transform.position.z - b.transform.position.z, 2)));


        //  Debug.Log("x："+a.transform.position.x+" y："+ a.transform.position.y+" z:"+ a.transform.position.z);

        // Debug.Log("x：" + b.transform.position.x + " y：" + b.transform.position.y + " z:" + b.transform.position.z);
       // Debug.Log (Time.time);

        





    }

    private void OnCollisionEnter(Collision collision)
    {


        if (collision.gameObject.name == "cube1")
        {
           
        }


    }
    private void OnTriggerEnter(Collider other)
    {



        if (other.gameObject.name == "cube1"&&cube[0]==true) {


            Debug.Log("Collide");

            cube[0].SetActive(false) ;


        }
        else if (other.gameObject.name == "cube2"&&cube[1] == true) {

            Debug.Log("Collide");

            cube[1].SetActive(false);



        }
        else if(other.gameObject.name == "cube3" && cube[2] == true) {


            Debug.Log("Collide");

            cube[2].SetActive(false);


        }

        if (other.gameObject.name == "cube4" && cube[3] == true)
        {


            Debug.Log("Collide");

            cube[3].SetActive(false);


        }
        else if (other.gameObject.name == "cube5" && cube[4] == true)
        {

            Debug.Log("Collide");

            cube[4].SetActive(false);



        }
        else if (other.gameObject.name == "cube6" && cube[5] == true)
        {


            Debug.Log("Collide");

            cube[5].SetActive(false);


        }














    }






}
