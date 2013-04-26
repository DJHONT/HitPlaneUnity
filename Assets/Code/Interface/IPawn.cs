using System;
using System.Collections.Generic;
using System.Text;

namespace HitPlaneOfPeople
{
    /// <summary>
    /// Pawn 卒，兵.敌人和玩家接口都继承于这个
    /// </summary>
    public interface IPawn
    {
        /// <summary>
        /// x坐标
        /// </summary>
        float X { get; set; }
        /// <summary>
        /// y坐标
        /// </summary>
        float Y { get; set; }
        /// <summary>
        /// 被攻击时触发
        /// </summary>
        /// <param name="damage">受到的攻击力</param>
        void UnderAttack(int damage);
        /// <summary>
        /// 攻击时触发
        /// </summary>
        void Attack();
        /// <summary>
        /// 死亡时触发
        /// </summary>
        void Death();
    }
}
