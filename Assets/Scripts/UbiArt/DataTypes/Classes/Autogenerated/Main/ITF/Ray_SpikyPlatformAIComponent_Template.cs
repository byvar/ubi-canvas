namespace UbiArt.ITF {
	[Games(GameFlags.ROVersion)]
	public partial class Ray_SpikyPlatformAIComponent_Template : ActorComponent_Template {
		public StringID setDown;
		public StringID setUp;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			setDown = s.SerializeObject<StringID>(setDown, name: "setDown");
			setUp = s.SerializeObject<StringID>(setUp, name: "setUp");
		}
		public override uint? ClassCRC => 0x9CB4987E;
	}
}

