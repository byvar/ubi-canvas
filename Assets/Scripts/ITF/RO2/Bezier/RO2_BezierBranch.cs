using ITF.RO2.Bezier.BranchComponents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace ITF {
	public class RO2_BezierBranch : BaseObject {
		[Serialize(0, "nodes")] public Container<RO2_BezierNode> nodes;
		[Serialize(1, "subBranches")] public Container<RO2_BezierSubBranch> subBranches;
		[Serialize(2, "components")] public Container<Generic<RO2_BezierBranchComponent>> components;
		[Serialize(3, "autoStartTweening")] public bool autoStartTweening;

		public RO2_BezierBranch(Reader reader) : base(reader) {
		}
	}
}
