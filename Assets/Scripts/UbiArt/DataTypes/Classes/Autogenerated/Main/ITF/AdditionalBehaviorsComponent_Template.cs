namespace UbiArt.ITF {
	[Games(GameFlags.All)]
	public partial class AdditionalBehaviorsComponent_Template : ActorComponent_Template {
		public CListO<ExternBehaviorData_Template> externBehaviorDataList;
		public StringID startBhv;
		public StringID onTriggerActiveBhv;
		public StringID onTriggerDesactivateBhv;
		public bool disablePhys;
		public bool onTriggerActiveCheckNextBhv;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.Settings.Game == Game.COL) {
				startBhv = s.SerializeObject<StringID>(startBhv, name: "startBhv");
				onTriggerActiveBhv = s.SerializeObject<StringID>(onTriggerActiveBhv, name: "onTriggerActiveBhv");
				onTriggerDesactivateBhv = s.SerializeObject<StringID>(onTriggerDesactivateBhv, name: "onTriggerDesactivateBhv");
				disablePhys = s.Serialize<bool>(disablePhys, name: "disablePhys");
				onTriggerActiveCheckNextBhv = s.Serialize<bool>(onTriggerActiveCheckNextBhv, name: "onTriggerActiveCheckNextBhv");
			} else {
				externBehaviorDataList = s.SerializeObject<CListO<ExternBehaviorData_Template>>(externBehaviorDataList, name: "externBehaviorDataList");
				startBhv = s.SerializeObject<StringID>(startBhv, name: "startBhv");
				onTriggerActiveBhv = s.SerializeObject<StringID>(onTriggerActiveBhv, name: "onTriggerActiveBhv");
				onTriggerDesactivateBhv = s.SerializeObject<StringID>(onTriggerDesactivateBhv, name: "onTriggerDesactivateBhv");
				disablePhys = s.Serialize<bool>(disablePhys, name: "disablePhys");
				onTriggerActiveCheckNextBhv = s.Serialize<bool>(onTriggerActiveCheckNextBhv, name: "onTriggerActiveCheckNextBhv");
			}
		}
		public override uint? ClassCRC => 0x56987861;
	}
}

