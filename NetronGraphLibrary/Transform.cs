using System;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Printing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
//using System.Runtime.Serialization.Formatters.Soap;
using System.Reflection;
using System.Threading;
using System.Windows.Forms;

namespace Netron.GraphLib
{
	/// <summary>
	/// The transform class contains the transformation (move, resize...) on the plex. An instance of this class
	/// is added to the history when the user changes something.
	/// </summary>
	/// <remarks>This class is very similar to the Select class and is indeed just another item that represents a user action that is being added to the history for undo/redo. If one day you wish to add a particular action then just copy this class structure and adapt
	/// it accordingly. </remarks>


		 internal class Transform : ICommand
		{
			 internal class State
			{
				public Shape Shape;
				public RectangleF Undo;
				public RectangleF Redo;
    
				public State(Shape o, RectangleF u, RectangleF r)
				{
					Shape = o;
					Undo = u;
					Redo = r;
				}
			}  

			private ArrayList Edit = new ArrayList();

			public void Add(Shape o, RectangleF r)
			{
				foreach (State s in Edit)
					if (s.Shape == o)
					{
						Edit.Remove(s);
						break;
					}

				if (!o.Rectangle.Equals(r))
					Edit.Add(new State(o, o.Rectangle, r));
			}

			public void Undo()
			{
				foreach (State s in Edit) s.Shape.Rectangle = s.Undo;
			}

			public void Redo()
			{
				foreach (State s in Edit) s.Shape.Rectangle = s.Redo;
			}

			public Boolean Empty
			{
				get { return (Edit.Count == 0); }
			}
		}
	}

