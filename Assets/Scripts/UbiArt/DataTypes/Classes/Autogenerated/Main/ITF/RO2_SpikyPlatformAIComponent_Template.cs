namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA)]
	public partial class RO2_SpikyPlatformAIComponent_Template : ActorComponent_Template {
		public StringID setDown;
		public StringID setUp;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			setDown = s.SerializeObject<StringID>(setDown, name: "setDown");
			setUp = s.SerializeObject<StringID>(setUp, name: "setUp");
		}
		public override uint? ClassCRC => 0x0D425D94;
	}
}

