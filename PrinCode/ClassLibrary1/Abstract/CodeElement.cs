using System;
using System.Collections.Generic;
using System.Text;

namespace CsAst.Abstract
{
    public abstract class CodeElement : INamed, IDisplayable
    {
        public string Name { get; set; }
        protected CodeElement(string name)
        {
            Name = name;
        }

        

        public abstract string Display();
    }
}
