using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace ITF.ActorComponents {
	public class TextBoxComponent : UIComponent {

		public TextBoxComponent(Reader reader) : base(reader) {
			Debug.LogError("Decipher textbox @ " + Pointer.Current(reader));
		}
	}
}
