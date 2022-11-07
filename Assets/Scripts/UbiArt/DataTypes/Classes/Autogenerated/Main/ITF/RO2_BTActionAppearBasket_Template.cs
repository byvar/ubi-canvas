namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RM)]
	public partial class RO2_BTActionAppearBasket_Template : BTAction_Template {
		public StringID animStand;
		public StringID animAppear;
		public bool waitForTrigger;
		public bool disablePhys;
		public bool resetAngle;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			animStand = s.SerializeObject<StringID>(animStand, name: "animStand");
			animAppear = s.SerializeObject<StringID>(animAppear, name: "animAppear");
			waitForTrigger = s.Serialize<bool>(waitForTrigger, name: "waitForTrigger");
			disablePhys = s.Serialize<bool>(disablePhys, name: "disablePhys");
			resetAngle = s.Serialize<bool>(resetAngle, name: "resetAngle");
		}
		public override uint? ClassCRC => 0x40ED945F;
	}
}

