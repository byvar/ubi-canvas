using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace ITF {
	public class VertexAnim : BaseObject {
		[Serialize(0, "animGlobalSpeed")] public float animGlobalSpeed;
		[Serialize(1, "animGlobalRotSpeed")] public Angle animGlobalRotSpeed;
		[Serialize(2, "animSpeedX")] public float animSpeedX;
		[Serialize(3, "animSpeedY")] public float animSpeedY;
		[Serialize(4, "animSyncX")] public float animSyncX;
		[Serialize(5, "animSyncY")] public float animSyncY;
		[Serialize(6, "animAmplitudeX")] public float animAmplitudeX;
		[Serialize(7, "animAmplitudeY")] public float animAmplitudeY;
		[Serialize(8, "animSync")] public float animSync;
		[Serialize(9, "animAngleUsed")] public bool animAngleUsed;
		[Serialize(10, "animAngle")] public Angle animAngle;

		public VertexAnim(Reader reader) : base(reader) {
		}
	}
}
