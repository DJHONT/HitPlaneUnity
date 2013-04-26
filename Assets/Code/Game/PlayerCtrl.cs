//Auther:DJHONT
//Date:2013-4-8

using System;
using UnityEngine;
using System.Collections.Generic;
using HitPlaneOfPeople;

namespace HitPlaneOfPeople
{
    //ReMark: 做摄像机的时候，注意坐标问题,和俯视视角的xyz对应
    public class PlayerCtrl : IPlayerCtrl
    {
        private IPlayer mPlayer;
		private Transform mCameraPos;
        private float mSpeed;

        public PlayerCtrl(IPlayer player, Transform cameraPos, float speed)
        {
            this.mPlayer = player;
			this.mCameraPos = cameraPos;
			this.mSpeed = speed;
        }
		
		private bool IsMove(Direction dir)
		{
			bool result = false;
			Vector2 player = new Vector2(mPlayer.X, mPlayer.Y);
			Vector2 cam = new Vector2(mCameraPos.position.x, mCameraPos.position.y);
			
			switch(dir)
			{
				case Direction.left:
				
					if(player.x - mSpeed > cam.x + Setting.BORDER_LEFT)
					{
						result = true;
					}
				
				break;
				
				case Direction.right:
				
					if(player.x + mSpeed < cam.x + Setting.BORDER_RIGHT)
					{
						result = true;
					}
				
				break;
				
				case Direction.up:
				
					if(player.y + mSpeed < cam.y + Setting.BORDER_TOP)
					{
						result = true;
					}
				
				break;
				
				case Direction.down:
				
					if(player.y - mSpeed > cam.y + Setting.BORDER_BUTTOM)
					{
						result = true;
					}
				
				break;
			}
			
			return result;
		}
		
        #region IPlayerCtrl 成员

        public void Move(Direction dir)
        {
			if(!IsMove(dir)) return;
			
            switch (dir)
            {
                case Direction.left:

                    mPlayer.X -= mSpeed;

                break;

                case Direction.right:

                    mPlayer.X += mSpeed;

                break;

                case Direction.up:

                    mPlayer.Y += mSpeed;

                break;

                case Direction.down:

                    mPlayer.Y -= mSpeed;

                break;
            }
        }

        public void Attack()
        {
            mPlayer.Attack();
        }

        #endregion
    }
}
