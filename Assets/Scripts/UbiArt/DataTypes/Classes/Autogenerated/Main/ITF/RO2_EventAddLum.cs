namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RAVersion)]
	public partial class RO2_EventAddLum : Event {
		public bool isAccrobatic;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			isAccrobatic = s.Serialize<bool>(isAccrobatic, name: "isAccrobatic");
		}
		public override uint? ClassCRC => 0xFF53A9D7;
	}
}

