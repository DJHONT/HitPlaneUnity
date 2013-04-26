using System;
using System.Collections.Generic;

namespace HitPlaneOfPeople
{
    public interface IPlayer : IPawn
    {
        void BulletRefresh(IBullet newBullet);
    }
}