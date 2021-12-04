using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABC.BL
{
    public abstract class BaseClass
    {
        public bool IsNew { get; set; }
        public bool HasChanges { get; set; }
        public ObjectConditionOptions ObjectCondition { get; set; }
        public bool IsValid
        {
            get
            {
                return Validate();
            }
        }

        public abstract bool Validate();
        
    }


        public enum ObjectConditionOptions
        {
            Active,
            Deleted
        }
}