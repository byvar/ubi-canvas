using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace UbiArt.Animation {
	// See: ITF::AnimPolylineBank::serialize
	public class AnimPolylineBank : CSerializable {
		[Serialize("polylines")] public CList<AnimPolyline> polylines;
		[Serialize("keys"     )] public KeyArray<int> keys;

		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(polylines));
			SerializeField(s, nameof(keys));
		}
	}
}
