namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA)]
	public partial class RO2_BossOceanBodyPart_Template : RO2_SnakeBodyPartActor_Template {
		public Path buboPath;
		public Path missilePath;
		public StringID missileBone;
		public float closeRangeAttackDistance;
		public CArrayO<StringID> buboAttachBones;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			buboPath = s.SerializeObject<Path>(buboPath, name: "buboPath");
			buboAttachBones = s.SerializeObject<CArrayO<StringID>>(buboAttachBones, name: "buboAttachBones");
			missilePath = s.SerializeObject<Path>(missilePath, name: "missilePath");
			missileBone = s.SerializeObject<StringID>(missileBone, name: "missileBone");
			closeRangeAttackDistance = s.Serialize<float>(closeRangeAttackDistance, name: "closeRangeAttackDistance");
		}
		public override uint? ClassCRC => 0x1167622B;
	}
}

