using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace ITF {
	public class RO2_BezierSubBranch : BaseObject {
		[Serialize(0, "dist")] public float dist;
		[Serialize(1, "offset")] public float offset;
		[Serialize(2, "branch")] public RO2_BezierBranch branch;

		public RO2_BezierSubBranch(Reader reader) : base(reader) {
		}
	}
}
