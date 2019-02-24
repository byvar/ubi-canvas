using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace ITF {
	public class Spline : BaseObject {
		[Serialize(0, "Points")] public Container<SplinePoint> points;
		[Serialize(1, "TimeLoopMode")] public uint timeLoopMode;
		[Serialize(2, "TimeLoop")] public float timeLoop;

		public Spline(Reader reader) : base(reader) {
		}

		public class SplinePoint : BaseObject {
			[Serialize(0, "Point")] public Vector3 point;
			[Serialize(1, "Time")] public float time;
			[Serialize(2, "NormalIn")] public Vector3 normalIn;
			[Serialize(3, "NormalInTime")] public Vector3 normalInTime;
			[Serialize(4, "NormalOut")] public Vector3 normalOut;
			[Serialize(5, "NormalOutTime")] public Vector3 normalOutTime;
			[Serialize(6, "Interpolation")] public Interpolation interpolation;

			public SplinePoint(Reader reader) : base(reader) {
			}

			public enum Interpolation {
				Linear = 0,
				Spline,
				Bezier,
				Constant,
				BezierStandard
			}
		}
	}
}
