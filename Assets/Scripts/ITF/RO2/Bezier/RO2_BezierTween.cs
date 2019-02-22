using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace ITF {
	public class RO2_BezierTween : BaseObject {
		[Serialize(0, "set")] public StringID set;
		[Serialize(1, "offset")] public float offset;

		public RO2_BezierTween(Reader reader) : base(reader) {
		}
	}
}
