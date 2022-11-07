namespace UbiArt.ITF {
	[Games(GameFlags.RO | GameFlags.LegendsAndUp)]
	public partial class PlayAnimBasedOnBoneAngleComponent_Template : ActorComponent_Template {
		public StringID bone;
		public Angle minAngle;
		public Angle maxAngle;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			bone = s.SerializeObject<StringID>(bone, name: "bone");
			minAngle = s.SerializeObject<Angle>(minAngle, name: "minAngle");
			maxAngle = s.SerializeObject<Angle>(maxAngle, name: "maxAngle");
		}
		public override uint? ClassCRC => 0xFE30FA88;
	}
}

