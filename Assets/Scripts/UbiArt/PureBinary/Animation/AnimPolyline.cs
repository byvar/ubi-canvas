using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace UbiArt.Animation {
	// See: ITF::AnimPolyline::serialize
	public class AnimPolyline : CSerializable {
		[Serialize("points")] public CList<AnimPolylinePoint> points;
		[Serialize("keys"  )] public KeyArray<int> keys;
		[Serialize("name"  )] public StringID name;
		[Serialize("unk"   )] public bool unk;
		[Serialize("unk2"  )] public uint unk2;

		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(points));
			SerializeField(s, nameof(keys));
			SerializeField(s, nameof(name));
			SerializeField(s, nameof(unk));
			SerializeField(s, nameof(unk2));
		}
	}
}
