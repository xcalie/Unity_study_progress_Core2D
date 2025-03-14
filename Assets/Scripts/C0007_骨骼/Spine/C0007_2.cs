using System.Collections;
using System.Collections.Generic;
using Spine;
using Spine.Unity;
using UnityEngine;

public class C0007_2 : MonoBehaviour
{
    private SkeletonAnimation skeletonAnimation;

    [SpineAnimation] // 动画
    public string animationName;

    [SpineBone] // 骨骼
    public string boneName;

    [SpineSlot] // 插槽
    public string slotName;

    [SpineAttachment] // 附件
    public string attachmentName;

    void Start()
    {
        skeletonAnimation = this.GetComponent<SkeletonAnimation>();

        #region 播放动画

        // 播放动画
        // 方法一
        //skeletonAnimation.loop = true;
        //skeletonAnimation.AnimationName = "animation";


        // 方法二 通过AnimationState
        skeletonAnimation.AnimationState.SetAnimation(0, "animation", true);
        //排队播放
        skeletonAnimation.AnimationState.AddAnimation(0, "animation", true, 0);

        #endregion


        #region 转向

        skeletonAnimation.skeleton.ScaleX = -1;

        #endregion

        #region 动画事件

        //动画开始播放
        skeletonAnimation.state.Start += (t) =>
        {
            Debug.Log("动画开始播放");
        };

        //动画播放被中断或者被清除
        skeletonAnimation.state.End += (t) =>
        {
            Debug.Log("动画播放被中断或者被清除");
        };

        //动画播放完成
        skeletonAnimation.state.Complete += (t) =>
        {
            Debug.Log("动画播放完成");
        };

        //自定义事件
        skeletonAnimation.state.Event += (t, e) =>
        {
            Debug.Log("自定义事件");
        };

        #endregion

        #region 获取数据

        // 获取骨骼
        Bone bone = skeletonAnimation.skeleton.FindBone(boneName);

        // 设置骨骼
        skeletonAnimation.skeleton.SetBonesToSetupPose();

        #endregion

        #region 在UI上显示
        #endregion
    }

}
