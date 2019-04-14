using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace UbiArt.Animation {
	// See: ITF::AnimPolylinePoint::serialize
	public class AnimPolylinePoint : CSerializable {
		[Serialize("pos" )] public Vector2 pos;
		[Serialize("name")] public StringID name;

		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(pos));
			SerializeField(s, nameof(name));
		}
	}
}
