using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace UbiArt.Animation {
	// See: ITF::AnimTrackFrameSoundEvents::serialize
	public class AnimTrackFrameSoundEvents : CSerializable {
		[Serialize("sid" )] public StringID sid;
		[Serialize("unk0")] public float unk0;
		[Serialize("unk1")] public uint unk1;

		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(sid));
			SerializeField(s, nameof(unk0));
			SerializeField(s, nameof(unk1));
		}
	}
}
