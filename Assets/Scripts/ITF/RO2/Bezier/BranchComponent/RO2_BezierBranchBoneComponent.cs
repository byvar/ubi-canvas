using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace ITF.RO2.Bezier.BranchComponents {
	public class RO2_BezierBranchBoneComponent : RO2_BezierBranchComponent {
		[Serialize(0, "bones")] public Container<RO2_BezierBone> bones;
		public RO2_BezierBranchBoneComponent(Reader reader) : base(reader) {
		}
	}
}
