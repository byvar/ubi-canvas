using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace UbiArt.Animation {
	// See: ITF::AnimPolyline::serialize
	public class AnimPolyline : CSerializable {
		public CListO<AnimPolylinePoint> points;
		public KeyArray<int> keys;
		public StringID name;
		public bool unk;
		public uint unk2;

		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			points = s.SerializeObject<CListO<AnimPolylinePoint>>(points, name: "points");
			keys = s.SerializeObject<KeyArray<int>>(keys, name: "keys");
			name = s.SerializeObject<StringID>(name, name: "name");
			unk = s.Serialize<bool>(unk, name: "unk");
			unk2 = s.Serialize<uint>(unk2, name: "unk2");
		}
	}
}
