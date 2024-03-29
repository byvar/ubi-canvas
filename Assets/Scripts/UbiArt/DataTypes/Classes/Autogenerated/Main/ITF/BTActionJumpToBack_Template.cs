namespace UbiArt.ITF {
	[Games(GameFlags.RO | GameFlags.LegendsAndUp)]
	public partial class BTActionJumpToBack_Template : BTAction_Template {
		public StringID anim;
		public float time = 1f;
		public float zOffset = 0.1f;
		public float height = 2f;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			anim = s.SerializeObject<StringID>(anim, name: "anim");
			time = s.Serialize<float>(time, name: "time");
			zOffset = s.Serialize<float>(zOffset, name: "zOffset");
			height = s.Serialize<float>(height, name: "height");
		}
		public override uint? ClassCRC => 0xA2C8211D;
	}
}

