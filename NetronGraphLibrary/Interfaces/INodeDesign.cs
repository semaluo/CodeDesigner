using System;
using System.Drawing;
namespace Netron.GraphLib.Interfaces
{
	public interface INodeDesign
	{
		Color NodeColor {get;set;}
		bool ShowLabel {get;set;}
		Color TextColor{get;set;}
		float FontSize {get;set;}

		
	}
}
