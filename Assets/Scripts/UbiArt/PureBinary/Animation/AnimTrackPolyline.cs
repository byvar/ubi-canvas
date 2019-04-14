using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace UbiArt.Animation {
	// See: ITF::AnimTrackPolyline::serialize
	public class AnimTrackPolyline : CSerializable {
		[Serialize("unk"    )] public float unk;
		[Serialize("entries")] public CList<StringID> entries;

		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(unk));
			SerializeField(s, nameof(entries));
		}
	}
}
