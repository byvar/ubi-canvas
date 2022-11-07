namespace UbiArt.ITF {
	[Games(GameFlags.RO | GameFlags.LegendsAndUp)]
	public partial class AIFadeAction_Template : AIAction_Template {
		public bool visible;
		public float fadeDuration;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			visible = s.Serialize<bool>(visible, name: "visible");
			fadeDuration = s.Serialize<float>(fadeDuration, name: "fadeDuration");
		}
		public override uint? ClassCRC => 0x26B4AE5C;
	}
}

