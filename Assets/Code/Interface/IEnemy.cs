using System;
using System.Collections.Generic;
using System.Text;

namespace HitPlaneOfPeople
{
    /// <summary>
    /// 敌人类接口
    /// </summary>
    public interface IEnemy : IPawn
    {
        /// <summary>
        /// 当这个敌人被激活时.(当玩家快遇到它时,会被激活)
        /// </summary>
        void OnActiveUpdate();
    }
}