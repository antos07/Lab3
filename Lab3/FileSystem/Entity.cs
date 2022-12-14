using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3.FileSystem
{
    public abstract class Entity
    {

        public string Name { get { return _name; } set { SetName(value); } }
        public string Path { get; protected set; }
        public DateTime CreationTime { get; protected set; }

        abstract public void Delete();

        protected string _name;

        abstract protected void SetName(string value);
    }
}
