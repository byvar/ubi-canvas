using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace ITF.RO2.Bezier.BranchComponents {
	public class RO2_BezierBranchGrowComponent : RO2_BezierBranchComponent {
		[Serialize(0, "startCursor")] public float startCursor;

		[Serialize(1, "useSameSpeed", game = Settings.Game.RL)] public bool useSameSpeed;

		[Serialize(1, "minCursor", game = Settings.Game.RA)] public float minCursor;
		[Serialize(2, "maxCursor", game = Settings.Game.RA)] public float maxCursor;
		[Serialize(3, "reinitTime", game = Settings.Game.RA)] public float reinitTime;
		[Serialize(4, "autoStartTime", game = Settings.Game.RA)] public float autoStartTime;

		[Serialize(5, "growSpeed")] public float growSpeed;
		[Serialize(6, "retractSpeed", game = Settings.Game.RL)] public float retractSpeed;
		[Serialize(7, "easeMode")] public EaseMode easeMode;
		public RO2_BezierBranchGrowComponent(Reader reader) : base(reader) {
		}

		public enum EaseMode {
			None = 0,
			EaseIn,
			EaseOut,
			EaseInOut
		}
	}
}
