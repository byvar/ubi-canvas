using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RM)]
	public partial class ActorAttachedToBoneComponent : ActorComponent {
		public StringID boneName;
		public Vec2d posOffset;
		public bool useBoneScale;
		public bool useBoneAngle;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			boneName = s.SerializeObject<StringID>(boneName, name: "boneName");
			posOffset = s.SerializeObject<Vec2d>(posOffset, name: "posOffset");
			useBoneScale = s.Serialize<bool>(useBoneScale, name: "useBoneScale");
			useBoneAngle = s.Serialize<bool>(useBoneAngle, name: "useBoneAngle");
		}
		public override uint? ClassCRC => 0x72CD9667;
	}
}

