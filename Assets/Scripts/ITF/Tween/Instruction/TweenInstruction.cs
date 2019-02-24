using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace ITF.TweenInstructions {
	public class TweenInstruction : BaseObject {
		[Serialize(0, "name")] public StringID name;

		public TweenInstruction(Reader reader) : base(reader) {
		}
	}
}
