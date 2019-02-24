using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace ITF.ActorComponents {
	public class TouchScreenInputComponent : ActorComponent {

		public TouchScreenInputComponent(Reader reader) : base(reader) {
			Debug.Log("Decipher TouchScreenInputComponent @ " + Pointer.Current(reader));
		}
	}
}
