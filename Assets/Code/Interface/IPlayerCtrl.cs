using System;
using System.Collections.Generic;

namespace HitPlaneOfPeople
{
    public interface IPlayerCtrl
    {
        /// <summary>
        /// 移动
        /// </summary>
        void Move(Direction dir);

        /// <summary>
        /// 攻击
        /// </summary>
        void Attack();
    }
}