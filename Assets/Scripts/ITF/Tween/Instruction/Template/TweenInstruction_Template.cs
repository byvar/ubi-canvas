using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace ITF.TweenInstructions.Template {
	public class TweenInstruction_Template : BaseObject {
		[Serialize(0, "duration")] public float duration;
		[Serialize(1, "name")] public StringID name;

		public TweenInstruction_Template(Reader reader) : base(reader) {
		}
	}
}
