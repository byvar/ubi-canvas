namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA)]
	public partial class RO2_UIItemCompetitorsComponent : UIComponent {
		public float firstPlayerOffset;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			firstPlayerOffset = s.Serialize<float>(firstPlayerOffset, name: "firstPlayerOffset");
		}
		public override uint? ClassCRC => 0xCB815F05;
	}
}

