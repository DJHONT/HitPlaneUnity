using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HitPlaneOfPeople
{
    public interface IGUI
    {
        void Init(IPlayerCtrl playerCtrl, IEngine engine);
    }
}