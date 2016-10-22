//
// System.Drawing.Design.PropertyValueItem.cs
// 
// Authors:
//  Alejandro Sánchez Acosta  <raciel@es.gnu.org>
//  Andreas Nahr (ClassDevelopment@A-SoftTech.com)
// 
// (C) Alejandro Sánchez Acosta
// (C) 2003 Andreas Nahr
// 

//
// Copyright (C) 2004-2005 Novell, Inc (http://www.novell.com)
//
// Permission is hereby granted, free of charge, to any person obtaining
// a copy of this software and associated documentation files (the
// "Software"), to deal in the Software without restriction, including
// without limitation the rights to use, copy, modify, merge, publish,
// distribute, sublicense, and/or sell copies of the Software, and to
// permit persons to whom the Software is furnished to do so, subject to
// the following conditions:
// 
// The above copyright notice and this permission notice shall be
// included in all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
// MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE
// LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION
// OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION
// WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
//

using System.Security.Permissions;

namespace System.Drawing.Design
{
#if !NETCORE
	[PermissionSet (SecurityAction.LinkDemand, Unrestricted = true)]
	[PermissionSet (SecurityAction.InheritanceDemand, Unrestricted = true)]
#endif
	public class PropertyValueUIItem
	{

		private Image uiItemImage;
		private PropertyValueUIItemInvokeHandler handler;
		private string tooltip;

		public PropertyValueUIItem (Image uiItemImage,
			PropertyValueUIItemInvokeHandler handler, string tooltip)
		{
			if (uiItemImage == null)
				throw new ArgumentNullException ("uiItemImage");
			if (handler == null)
				throw new ArgumentNullException ("handler");
			this.uiItemImage = uiItemImage;
			this.handler = handler;
			this.tooltip = tooltip;
		}

		public virtual Image Image 
		{
			get
			{
				return uiItemImage;
			}
		}

		public virtual PropertyValueUIItemInvokeHandler InvokeHandler
		{
			get
			{
				return handler;
			}
		}

		public virtual string ToolTip 
		{
			get
			{
				return tooltip;
			}
		}

		public virtual void Reset()
		{
			// To be overriden in child classes
		}
	}
}
