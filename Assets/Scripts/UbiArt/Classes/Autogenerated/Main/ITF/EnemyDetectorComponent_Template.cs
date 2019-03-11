using UnityEngine;

namespace UbiArt.ITF {
	public partial class EnemyDetectorComponent_Template : ShapeDetectorComponent_Template {
		[Serialize("faction"       )] public uint faction;
		[Serialize("noPhantomCheck")] public bool noPhantomCheck;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(faction));
			SerializeField(s, nameof(noPhantomCheck));
		}
		public override uint? ClassCRC => 0x9C2CBBEF;
	}
}

