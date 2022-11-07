namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA | GameFlags.RM)]
	public partial class RO2_BTActionLookAtAttack_Template : BTAction_Template {
		public Generic<PhysShape> enemyDetectionRange;
		public Generic<PhysShape> enemyAttackRange;
		public StringID detectAnim;
		public StringID attackAnim;
		public float lookAtBlend;
		public bool debug;
		public CListO<StringID> fxNames;
		public CListO<StringID> fxMarkerStart;
		public CListO<StringID> fxMarkerStop;
		public StringID lightningStart;
		public StringID lightningStop;
		public StringID lightningCharge;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			enemyDetectionRange = s.SerializeObject<Generic<PhysShape>>(enemyDetectionRange, name: "enemyDetectionRange");
			enemyAttackRange = s.SerializeObject<Generic<PhysShape>>(enemyAttackRange, name: "enemyAttackRange");
			detectAnim = s.SerializeObject<StringID>(detectAnim, name: "detectAnim");
			attackAnim = s.SerializeObject<StringID>(attackAnim, name: "attackAnim");
			lookAtBlend = s.Serialize<float>(lookAtBlend, name: "lookAtBlend");
			debug = s.Serialize<bool>(debug, name: "debug");
			fxNames = s.SerializeObject<CListO<StringID>>(fxNames, name: "fxNames");
			fxMarkerStart = s.SerializeObject<CListO<StringID>>(fxMarkerStart, name: "fxMarkerStart");
			fxMarkerStop = s.SerializeObject<CListO<StringID>>(fxMarkerStop, name: "fxMarkerStop");
			lightningStart = s.SerializeObject<StringID>(lightningStart, name: "lightningStart");
			lightningStop = s.SerializeObject<StringID>(lightningStop, name: "lightningStop");
			lightningCharge = s.SerializeObject<StringID>(lightningCharge, name: "lightningCharge");
		}
		public override uint? ClassCRC => 0x9A0B94EA;
	}
}

