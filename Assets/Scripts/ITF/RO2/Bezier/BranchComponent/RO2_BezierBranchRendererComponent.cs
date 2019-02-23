using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace ITF.RO2.Bezier.BranchComponents {
	public class RO2_BezierBranchRendererComponent : RO2_BezierBranchComponent {
		[Serialize(0, "flipTexture")] public bool flipTexture;
		public RO2_BezierBranchRendererComponent(Reader reader) : base(reader) {
		}
	}
}
