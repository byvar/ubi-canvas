namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA)]
	public partial class RO2_CarryPlayersZoneComponent_Template : ActorComponent_Template {
		public StringID regionID;
		public float carryMinParticulePercent;
		public float leaveMinCollidingParticulePercent;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			regionID = s.SerializeObject<StringID>(regionID, name: "regionID");
			carryMinParticulePercent = s.Serialize<float>(carryMinParticulePercent, name: "carryMinParticulePercent");
			leaveMinCollidingParticulePercent = s.Serialize<float>(leaveMinCollidingParticulePercent, name: "leaveMinCollidingParticulePercent");
		}
		public override uint? ClassCRC => 0x2527120E;
	}
}

