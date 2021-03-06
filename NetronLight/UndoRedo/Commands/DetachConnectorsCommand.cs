using System;
using System.Collections.Generic;
using System.Text;

namespace Netron.NetronLight
{
    class DetachConnectorCommand : Command
    {
        IConnector parent;
        IConnector child;

        public override void Redo()
        {
            parent.DetachConnector(child);            
        }
        public override void Undo()
        {
            parent.AttachConnector(child);            
        }

        #region Constructor
        public DetachConnectorCommand(IController controller, IConnector parent, IConnector child) : base(controller)
        {
            this.parent = parent;
            this.child = child;
        }
        #endregion
  
    }
}
