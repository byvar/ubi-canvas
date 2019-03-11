using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_InfoElement : CSerializable {
		[Serialize("isOccupied")] public bool isOccupied;
		[Serialize("reward"    )] public uint reward;
		[Serialize("anim"      )] public AnimationAtlas anim;
		[Serialize("animBreak" )] public AnimationAtlas animBreak;
		[Serialize("fragments" )] public RO2_FragmentsList fragments;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(isOccupied));
			SerializeField(s, nameof(reward));
			SerializeField(s, nameof(anim));
			SerializeField(s, nameof(animBreak));
			SerializeField(s, nameof(fragments));
		}
	}
}

