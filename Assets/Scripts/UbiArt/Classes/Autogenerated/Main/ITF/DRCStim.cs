using UnityEngine;

namespace UbiArt.ITF {
	public partial class DRCStim : EventStim {
		[Serialize("level"    )] public uint level;
		[Serialize("direction")] public Vector2 direction;
		[Serialize("faction"  )] public uint faction;
		[Serialize("fxPos"    )] public Vector3 fxPos;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(level));
			SerializeField(s, nameof(direction));
			SerializeField(s, nameof(faction));
			SerializeField(s, nameof(fxPos));
		}
		public override uint? ClassCRC => 0xC9E31CF9;
	}
}

