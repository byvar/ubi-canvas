using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace ITF {
	public class SingleAnimData : BaseObject {
		[Serialize(0, "flip")] public bool flip;
		[Serialize(1, "angle")] public Angle angle;
		[Serialize(2, "animName")] public StringID animName;
		[Serialize(3, "offset")] public uint offset;
		[Serialize(4, "pos")] public Vector3 pos;
		[Serialize(5, "scale")] public Vector2 scale;
		[Serialize(6, "color")] public Color color;
		[Serialize(7, "anim")] public uint anim;

		public SingleAnimData(Reader reader) : base(reader) {
		}
	}
}
