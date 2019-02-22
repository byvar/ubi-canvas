using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace ITF.RO2.Bezier.BranchComponents {
	public class RO2_BezierBranchGrowComponent : RO2_BezierBranchComponent {
		public RO2_BezierBranchGrowComponent(Reader reader) : base(reader) {
			Debug.LogError("Decipher BezierBranchGrowComponent @ " + Pointer.Current(reader));
		}
	}
}
