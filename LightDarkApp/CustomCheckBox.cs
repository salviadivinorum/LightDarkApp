using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LightDarkApp
{
	public class CustomCheckBox : CheckBox
	{
		protected override bool ShowFocusCues
		{
			get
			{
				// Only show focus cues when the control has focus
				return Focused;
			}
		}

	}
}
