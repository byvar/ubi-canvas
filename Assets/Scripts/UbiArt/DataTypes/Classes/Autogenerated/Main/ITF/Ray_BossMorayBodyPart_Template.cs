namespace UbiArt.ITF {
	[Games(GameFlags.RO | GameFlags.RFR)]
	public partial class Ray_BossMorayBodyPart_Template : BodyPart_Template {
		public Path buboPath;
		public CArrayO<StringID> buboAttachBones;
		public Path missilePath;
		public StringID missileBone;
		public float closeRangeAttackDistance;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			buboPath = s.SerializeObject<Path>(buboPath, name: "buboPath");
			buboAttachBones = s.SerializeObject<CArrayO<StringID>>(buboAttachBones, name: "buboAttachBones");
			missilePath = s.SerializeObject<Path>(missilePath, name: "missilePath");
			missileBone = s.SerializeObject<StringID>(missileBone, name: "missileBone");
			closeRangeAttackDistance = s.Serialize<float>(closeRangeAttackDistance, name: "closeRangeAttackDistance");
		}
		public override uint? ClassCRC => 0xFFE973DA;
	}
}

