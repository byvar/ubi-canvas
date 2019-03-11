using UnityEngine;

namespace UbiArt.ITF {
	public partial class SingleAnimData : CSerializable {
		[Serialize("flip"    )] public bool flip;
		[Serialize("animName")] public StringID animName;
		[Serialize("offset"  )] public uint offset;
		[Serialize("scale"   )] public Vector2 scale;
		[Serialize("anim"    )] public uint anim;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(flip));
			SerializeField(s, nameof(animName));
			SerializeField(s, nameof(offset));
			SerializeField(s, nameof(scale));
			SerializeField(s, nameof(anim));
		}
		public override uint? ClassCRC => 0x38A1A554;
	}
}

