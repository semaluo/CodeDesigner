using System;
using System.Diagnostics;
using System.Collections;
using System.Drawing;
using System.Windows.Forms;

namespace Netron.NetronLight
{
    class HitTool : AbstractTool, IMouseListener
    {

        #region Fields
       

     

        #endregion

        #region Constructor
        public HitTool(string name)
            : base(name)
        {
        }
        #endregion

        #region Methods

        protected override void OnActivateTool()
        {
            

        }

        public void MouseDown(MouseEventArgs e)
        {
            if(e == null)
                throw new ArgumentNullException("The argument object is 'null'");
            if(e.Button == MouseButtons.Left  && Enabled && !IsSuspended)
            {
                //if(e.Clicks == 1)
                {
                    TextEditor.Hide();
                    Selection.CollectEntitiesAt(e.Location);
                    if(Selection.SelectedItems.Count > 0)
                    {
                        IMouseListener listener = Selection.SelectedItems[0].GetService(typeof(IMouseListener)) as IMouseListener;
                        if(listener != null)
                        {
                            listener.MouseDown(e);
                        }
                    }
                }
                if(e.Clicks == 2)
                {
                    if (Selection.SelectedItems.Count > 0 && Selection.SelectedItems[0] is TextOnly)
//                    if (Selection.SelectedItems.Count > 0 )
                    {
                        TextEditor.GetEditor(Selection.SelectedItems[0] as IShape);
                        TextEditor.Show();                        
                    }
                }
            }
        }

        public void MouseMove(MouseEventArgs e)
        {
      
        }
      
        public void MouseUp(MouseEventArgs e)
        {
            if(IsActive)
            {
                DeactivateTool();
            }
        }
        #endregion
    }

}
