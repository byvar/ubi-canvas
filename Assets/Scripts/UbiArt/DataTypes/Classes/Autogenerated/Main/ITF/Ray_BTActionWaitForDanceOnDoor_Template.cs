namespace UbiArt.ITF {
	[Games(GameFlags.RO)]
	public partial class Ray_BTActionWaitForDanceOnDoor_Template : BTAction_Template {
		public StringID anim;
		public float syncRatio;
		public float syncOffset;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			anim = s.SerializeObject<StringID>(anim, name: "anim");
			syncRatio = s.Serialize<float>(syncRatio, name: "syncRatio");
			syncOffset = s.Serialize<float>(syncOffset, name: "syncOffset");
		}
		public override uint? ClassCRC => 0x7F26FDB1;
	}
}

