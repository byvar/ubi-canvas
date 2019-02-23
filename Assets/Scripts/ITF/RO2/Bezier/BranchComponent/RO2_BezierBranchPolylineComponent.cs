using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace ITF.RO2.Bezier.BranchComponents {
	public class RO2_BezierBranchPolylineComponent : RO2_BezierBranchComponent {
		[Serialize(0, "polylineMode")] public RO2_PolylineMode polylineMode;
		[Serialize(1, "polylineTesselation", game = Settings.Game.RA)] public float polylineTesselation;
		
		public RO2_BezierBranchPolylineComponent(Reader reader) : base(reader) {
		}

		public enum RO2_PolylineMode {
			None = 0,
			Left,
			Right,
			DoubleSided,
			LeftInverted, // RA only
			RightInverted // RA only
		}
	}
}
