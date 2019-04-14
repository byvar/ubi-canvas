using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace UbiArt.Animation {
	// See: ITF::AnimTrackBonesList::serialize
	public class AnimTrackBonesList : CSerializable {
		[Serialize("startPAS" )] public ushort startPAS;
		[Serialize("amountPAS")] public ushort amountPAS;
		[Serialize("startZAL" )] public ushort startZAL;
		[Serialize("amountZAL")] public ushort amountZAL;

		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(startPAS));
			SerializeField(s, nameof(amountPAS));
			SerializeField(s, nameof(startZAL));
			SerializeField(s, nameof(amountZAL));
		}
	}
}
