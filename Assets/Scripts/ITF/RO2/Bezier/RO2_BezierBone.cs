using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace ITF {
	public class RO2_BezierBone : BaseObject {
		[Serialize(0, "id")] public StringID id;
		[Serialize(1, "distance")] public float distance;
		[Serialize(2, "offset")] public float offset;
		[Serialize(3, "followTangent")] public bool followTangent;

		public RO2_BezierBone(Reader reader) : base(reader) {
		}
	}
}
