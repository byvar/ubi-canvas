using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace ITF.TweenInstructions.Template {
	public class TweenTranslation_Template : TweenInstruction_Template {
		[Serialize(0, "startDuration")] public float startDuration;
		[Serialize(1, "endDuration")] public float endDuration;
		[Serialize(2, "startSpeed")] public float startSpeed;
		[Serialize(3, "endSpeed")] public float endSpeed;
		[Serialize(4, "rotateTrajectory")] public bool rotateTrajectory;
		[Serialize(5, "rotateActor")] public bool rotateActor;
		[Serialize(6, "angle")] public AngleAmount angle;
		[Serialize(7, "angleOffset")] public AngleAmount angleOffset;
		[Serialize(8, "scaleMultiplier")] public Vector2 scaleMultiplier;
		[Serialize(9, "speed")] public float speed;

		public TweenTranslation_Template(Reader reader) : base(reader) {
		}
	}
}
