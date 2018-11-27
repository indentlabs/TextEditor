// This file has been autogenerated from a class added in the UI designer.

using System;
using Foundation;
using AppKit;
using TextEditor.Classes;

namespace TextEditor
{
	public partial class WindowController : NSWindowController
	{
		public WindowController (IntPtr handle) : base (handle)
		{
		}
        public override void WindowDidLoad()
        {
            base.WindowDidLoad();
            Window.Delegate = new EditorWindowDelegate(Window);
        }
    }
}
