using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class JudgeFinsh: MonoBehaviour
{
    // Start is called before the first frame update

    public Animator _am;
    public Animator _am1;
    float TotalTime=5;

    public TextMesh t_cd;
    public TextMesh t_c;
    void Start()
    {

        StartCoroutine(CountDown());
        

    }

    // Update is called once per frame
    void Update()
    {
         
        AnimatorStateInfo info = _am.GetCurrentAnimatorStateInfo(0);      //加载移动动画
        AnimatorStateInfo info1 = _am1.GetCurrentAnimatorStateInfo(0);

        if (info.normalizedTime >= 1.0f)
        {
            Debug.Log("Finish");

            Debug.Log(Time.time);

            SceneManager.LoadScene("chooseCity");
          //  Application.Quit();
            //UnityEditor.EditorApplication.isPlaying = false;
        }
        if (info1.normalizedTime >= 1.0f)
        {
           

             
            Debug.Log(Time.time);
           // UnityEditor.EditorApplication.isPlaying = false;
            //Application.Quit();
        }
        if (TotalTime == 0)
        {
            _am.speed = 1;

            _am1.speed = 1;

            TotalTime -= 1;

        }
        else if(TotalTime>0)
        {

            _am.speed = 0;

            _am1.speed = 0;


        }

        if (Input.anyKeyDown)//测试能否调整速度
        {
            foreach (KeyCode keyCode in System.Enum.GetValues(typeof(KeyCode)))
            {
                if (Input.GetKeyDown(keyCode))
                {
                   
                    switch (keyCode)
                    {
                        case KeyCode.LeftArrow:
                            {
                                Debug.Log("left");



                                break;
                            }
                        case KeyCode.RightArrow:
                            {
                                Debug.Log("right");
                                break;
                            }
                        case KeyCode.UpArrow:
                            {
                                Debug.Log("up");

                                _am.speed += 1;

                                _am1.speed += 0;
                                break;
                            }
                        case KeyCode.DownArrow:
                            {
                                Debug.Log("down");
                                _am.speed -= 1;

                                _am1.speed -= 0;
                                break;
                            }

                        case KeyCode.W:
                            {

                                

                                break;

                            }
                    }
                }
            }
        }


        if(Time.time>5)
        t_c.text = "计时：" + Time.time.ToString();//计时打印到平面




    }


    public void ShowWord()
    {


        // UnityEditor.EditorApplication.isPlaying = false;
        SceneManager.LoadScene("chooseCity");
        //Application.Quit();
    }
    public void ShowWord1()
    {

        // UnityEditor.EditorApplication.isPlaying = false;

        SceneManager.LoadScene("chooseCity");
        // Application.Quit();
    }

    IEnumerator CountDown()
    {
        while (TotalTime >= 0)//倒计时
        {
            Debug.Log(TotalTime);
            t_cd.text = "倒计时："+TotalTime.ToString();
            yield return new WaitForSeconds(1);
            TotalTime--;

        }
    }

}
