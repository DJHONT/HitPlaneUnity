using System;
using System.Collections.Generic;
using UnityEngine;

namespace HitPlaneOfPeople
{
    /// <summary>
    /// 控制游戏的整体运行.(不是游戏引擎,而是意义上的引擎)
    /// </summary>
    public class Engine : IEngine
    {
        bool mIsPause;

        #region IEngine Interface

        public void Pause()
        {
            Time.timeScale = 0;
			mIsPause = true;
        }

        public void Continue()
        {
            Time.timeScale = 1;
			mIsPause = false;
        }

        public void VoiceSetting(bool toggle)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
