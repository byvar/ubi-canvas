using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.VH)]
	public partial class SingleAnimData : CSerializable {
		[Serialize("flip"    )] public bool flip;
		[Serialize("angle"   )] public Angle angle;
		[Serialize("animName")] public StringID animName;
		[Serialize("offset"  )] public uint offset;
		[Serialize("pos"     )] public Vector3 pos;
		[Serialize("scale"   )] public Vector2 scale;
		[Serialize("color"   )] public Color color;
		[Serialize("anim"    )] public uint anim;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(flip));
			SerializeField(s, nameof(angle));
			SerializeField(s, nameof(animName));
			SerializeField(s, nameof(offset));
			SerializeField(s, nameof(pos));
			SerializeField(s, nameof(scale));
			SerializeField(s, nameof(color));
			SerializeField(s, nameof(anim));
		}
		public override uint? ClassCRC => 0x38A1A554;
	}
}

