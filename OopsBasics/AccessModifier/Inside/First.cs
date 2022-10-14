using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Outside;

namespace Inside
{
    public class First:Third
    {
        public int PublicNumber=10;
        private int PrivateNumber=20;
        public int PrivateOutput { get {return PrivateNumber;} }
        internal int InternalNumber =30;
        protected int ProtectedNumber=30;
        public int ProtectedInternaOutput{get {return ProtectedInternalNumber;}}
        
        
    }
}