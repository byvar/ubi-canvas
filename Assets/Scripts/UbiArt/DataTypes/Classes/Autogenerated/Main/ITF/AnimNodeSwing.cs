namespace UbiArt.ITF {
	[Games(GameFlags.RO | GameFlags.RL)]
	public partial class AnimNodeSwing : CSerializable {
		public Placeholder leafs;
		public Placeholder childData;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.Settings.game == Settings.Game.RL) {
				leafs = s.SerializeObject<Placeholder>(leafs, name: "leafs");
				childData = s.SerializeObject<Placeholder>(childData, name: "childData");
			} else {
			}
		}
		public override uint? ClassCRC => 0x73BAE590;
	}
}

