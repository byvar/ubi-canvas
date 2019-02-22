using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace ITF.ActorComponents {
	public class AFXPostProcessComponent : ActorComponent {

		public AFXPostProcessComponent(Reader reader) : base(reader) {
			Debug.LogError("Decipher AFXPostProcessComponent @ " + Pointer.Current(reader));
		}
	}
}
