using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace UbiArt.Animation {
	// See: ITF::AnimTrackPolyline::serialize
	public class AnimTrackPolyline : ICSerializable {
		public float unk;
		public CList<StringID> entries;

		public void Serialize(CSerializerObject s, string name) {
			s.Serialize(ref unk);
			s.Serialize(ref entries);
		}
	}
}
