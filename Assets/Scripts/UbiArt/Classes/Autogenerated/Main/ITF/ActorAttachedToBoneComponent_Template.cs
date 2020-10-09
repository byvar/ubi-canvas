using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RM)]
	public partial class ActorAttachedToBoneComponent_Template : ActorComponent_Template {
		public StringID boneName;
		public bool useBoneScale;
		public bool useBoneAngle;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			boneName = s.SerializeObject<StringID>(boneName, name: "boneName");
			useBoneScale = s.Serialize<bool>(useBoneScale, name: "useBoneScale");
			useBoneAngle = s.Serialize<bool>(useBoneAngle, name: "useBoneAngle");
		}
		public override uint? ClassCRC => 0xD24BD29A;
	}
}

