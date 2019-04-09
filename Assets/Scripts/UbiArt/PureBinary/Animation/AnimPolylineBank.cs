using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace UbiArt.Animation {
	// See: ITF::AnimPolylineBank::serialize
	public class AnimPolylineBank : ICSerializable {
		public CList<AnimPolyline> polylines;
		public KeyArray<int> keys;

		public void Serialize(CSerializerObject s, string name) {
			s.Serialize(ref polylines);
			s.Serialize(ref keys);
		}
	}
}
