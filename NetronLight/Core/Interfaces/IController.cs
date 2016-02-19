using System;
using System.Windows.Forms;
namespace Netron.NetronLight
{
    public interface IController : IUndoSupport
    {
        #region Events
        event EventHandler<HistoryChangeEventArgs> OnHistoryChange;
        event EventHandler<ToolEventArgs> OnToolActivate;
        event EventHandler<ToolEventArgs> OnToolDeactivate;
        event EventHandler<SelectionEventArgs> OnShowSelectionProperties;
        event EventHandler<EntityEventArgs> OnEntityAdded;
        event EventHandler<EntityEventArgs> OnEntityRemoved;
        event EventHandler<MouseEventArgs> OnMouseDown;
        #endregion

        #region Properties
        Model Model { get; set;}

        IView View { get;set;}

        CollectionBase<ITool> Tools { get;}

        UndoManager UndoManager { get;}

        IDiagramControl ParentControl { get;}

        bool Enabled
        {
            get;
            set;
        }
        #endregion

        #region Methods

        void ActivateTool(string toolName);

        void AddTool(ITool tool);

        bool DeactivateTool(ITool tool);

        void RaiseOnShowSelectionProperties(SelectionEventArgs e);
        void SuspendAllTools();

        void UnsuspendAllTools();
        #endregion

        
    }
}
