using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace UbiArt.Animation {
	// See: ITF::AnimTrackPolyline::serialize
	public class AnimTrackPolyline : CSerializable {
		public float unk;
		public CList<StringID> entries;

		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			unk = s.Serialize<float>(unk, name: "unk");
			entries = s.SerializeObject<CList<StringID>>(entries, name: "entries");
		}
	}
}
