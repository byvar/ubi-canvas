using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace ITF {
	public class InputDesc : BaseObject {
		[Serialize(0, "name")] public StringID name;
		[Serialize(1, "varType")] public InputType varType;

		public InputDesc(Reader reader) : base(reader) {
		}

		public enum InputType {
			F32 = 0,
			U32
		}
	}
}
