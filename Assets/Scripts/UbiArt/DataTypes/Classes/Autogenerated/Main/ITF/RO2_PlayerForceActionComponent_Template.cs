namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA | GameFlags.RM)]
	public partial class RO2_PlayerForceActionComponent_Template : ActorComponent_Template {
		public bool stackAction;
		public bool DRCInteractActorInZoneTest;
		public int inShadowTest;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.Settings.Game == Game.RL) {
				stackAction = s.Serialize<bool>(stackAction, name: "stackAction");
				inShadowTest = s.Serialize<int>(inShadowTest, name: "inShadowTest");
				DRCInteractActorInZoneTest = s.Serialize<bool>(DRCInteractActorInZoneTest, name: "DRCInteractActorInZoneTest");
			} else {
				stackAction = s.Serialize<bool>(stackAction, name: "stackAction");
				DRCInteractActorInZoneTest = s.Serialize<bool>(DRCInteractActorInZoneTest, name: "DRCInteractActorInZoneTest");
			}
		}
		public override uint? ClassCRC => 0xA4A78483;
	}
}

