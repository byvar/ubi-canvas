using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace UbiArt.Animation {
	// See: ITF::AnimPolylineBank::serialize
	public class AnimPolylineBank : CSerializable {
		public CList<AnimPolyline> polylines;
		public KeyArray<int> keys;

		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			polylines = s.SerializeObject<CList<AnimPolyline>>(polylines, name: "polylines");
			keys = s.SerializeObject<KeyArray<int>>(keys, name: "keys");
		}
	}
}
