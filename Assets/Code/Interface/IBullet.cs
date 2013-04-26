using System;
using System.Collections.Generic;
using System.Text;

namespace HitPlaneOfPeople
{
    public interface IBullet
    {
        int GetDamage();
		UnityEngine.Object GetBulletObj();
    }
}