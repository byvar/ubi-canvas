namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class RO2_DRCPlayerCineComponent_Template : ActorComponent_Template {
		public StringID toctocRumbleName;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			toctocRumbleName = s.SerializeObject<StringID>(toctocRumbleName, name: "toctocRumbleName");
		}
		public override uint? ClassCRC => 0xBD94FF75;
	}
}

