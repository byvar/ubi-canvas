namespace UbiArt.ITF {
	[Games(GameFlags.RO | GameFlags.RLVersion | GameFlags.VH | GameFlags.RA)]
	public partial class WindComponent_Template : PhysForceModifierComponent_Template {
		public CListO<PhysForceModifier> windAreasOrigins;
		public CListO<Generic<PhysForceModifier_Template>> windAreas;
		public bool canInverse = true;
		public bool canStop = true;
		public bool enableAtStart = true;
		public Enum_flags flags;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.Settings.Game == Game.RO) {
				windAreasOrigins = s.SerializeObject<CListO<PhysForceModifier>>(windAreasOrigins, name: "windAreas");
			} else if (s.Settings.Game == Game.RL || s.Settings.Game == Game.COL) {
				windAreas = s.SerializeObject<CListO<Generic<PhysForceModifier_Template>>>(windAreas, name: "windAreas");
			} else {
				windAreas = s.SerializeObject<CListO<Generic<PhysForceModifier_Template>>>(windAreas, name: "windAreas");
				canInverse = s.Serialize<bool>(canInverse, name: "canInverse");
				canStop = s.Serialize<bool>(canStop, name: "canStop");
				enableAtStart = s.Serialize<bool>(enableAtStart, name: "enableAtStart");
				flags = s.Serialize<Enum_flags>(flags, name: "flags");
			}
		}
		public enum Enum_flags {
			[Serialize("OnlyApplyIfNotSticked")] OnlyApplyIfNotSticked = 1,
		}
		public override uint? ClassCRC => 0xCB67A691;
	}
}

