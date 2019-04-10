using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace UbiArt.Animation {
	// See: ITF::AnimTemplate::serialize
	public class AnimTemplate : CSerializable {
		[Serialize("keys"       )] public KeyArray<int> keys;
		[Serialize("bones"      )] public CList<AnimBone> bones;
		[Serialize("bonesDyn"   )] public CList<AnimBoneDyn> bonesDyn;
		[Serialize("patchPoints")] public CList<AnimPatchPoint> patchPoints;
		[Serialize("patches"    )] public CList<AnimPatch> patches;

		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(keys));
			SerializeField(s, nameof(bones));
			SerializeField(s, nameof(bonesDyn));
			SerializeField(s, nameof(patchPoints));
			SerializeField(s, nameof(patches));
		}

	}
}
