using System;

namespace Netron.GraphLib
{
	/// <summary>
	/// ICommand interface allows the whole machinery of undo/redo
	/// </summary>
	public interface ICommand
	{
		/// <summary>
		/// The undo part of the interface
		/// </summary>
		void Undo();

		/// <summary>
		/// The do/redo part of the interface
		/// </summary>
		void Redo();
		/// <summary>
		/// Returns wether empty
		/// </summary>
		bool Empty { get; }
	}
}
