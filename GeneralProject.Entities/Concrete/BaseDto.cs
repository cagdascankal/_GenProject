using GeneralProject.Core.Enties;
using System;
using System.Collections.Generic;
using System.Text;

namespace GeneralProject.Entities.Concrete
{
    public class BaseDto:IEntity
    {
        public long Id { get; set; }
        public bool IsActive { get; set; }
        public bool Isdelete { get; set; }

    }
}
