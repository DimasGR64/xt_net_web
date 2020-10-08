using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPAM.FoolballManager.Entites
{
    public abstract class AbstractInjurny
    {
        private DateTime _RecoveryTime { get;  set; }
        protected AbstractInjurny(DateTime recoveryTime)
        {
            _RecoveryTime = recoveryTime;    
        }
    }
    public class MusculeInjurny : AbstractInjurny
    {
        public MusculeInjurny(DateTime recoveryTime) : base(recoveryTime)
        {

        }
    }
    public class TendonRupture : AbstractInjurny
    {
        public TendonRupture(DateTime recoveryTime) : base(recoveryTime)
        {

        }
    }
}
