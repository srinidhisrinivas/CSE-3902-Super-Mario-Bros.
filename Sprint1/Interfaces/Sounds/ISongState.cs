using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSE3902
{
    public interface ISongState
    {
        void Play();
        void SpeedUp();
        void SlowDown();
        void ChangeToOverworld();
        void ChangeToUnderworld();
    }
}
