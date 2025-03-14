using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson32 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        #region 有限状态机

        // 有限状态机 Finite State Machine
        //又称为有限自动机，是表示有限个状态以及在这些状态之间的转移和动作等行为的数学模型。

        //有限：有限个状态
        //状态：状态是指一个系统在某一时刻的状况或情况

        //举例说明:
        //假设有一个人，他有三种状态：站立、行走、奔跑
        //站立状态下，他可以做的事情有：站立、行走
        //行走状态下，他可以做的事情有：站立、行走、奔跑
        //奔跑状态下，他可以做的事情有：站立、行走
        //在达到某种条件时，他会从一个状态转移到另一个状态
        //这些状态随时可以发生
        #endregion

        #region 意义

        //游戏开发中很多功能系统都是有限状态机
        //最典型的状态机系统
        //动作系统、AI系统、UI系统、游戏关卡系统等

        #endregion

        #region 最简单的状态机

        //最简单的状态机 由switch case实现
        string animName = "idle";
        switch (animName)
        {
            case "idle":
                Debug.Log("站立");
                break;
            case "walk":
                Debug.Log("行走");
                break;
            case "run":
                Debug.Log("奔跑");
                break;
        }



        #endregion

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
