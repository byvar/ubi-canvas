using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace UbiArt.Animation {
	// See: ITF::AnimPolyline::serialize
	public class AnimPolyline : ICSerializable {
		public CList<AnimPolylinePoint> points;
		public KeyArray<int> keys;
		public StringID name;
		public bool unk;
		public uint unk2;

		public void Serialize(CSerializerObject s, string name) {
			s.Serialize(ref points);
			s.Serialize(ref keys);
			s.Serialize(ref this.name);
			s.Serialize(ref unk);
			s.Serialize(ref unk2);
		}
	}
}
