namespace UbiArt.ITF {
	[Games(GameFlags.RL)] // Only on Vita!
	public partial class DynamicLightZoneComponent_Template : ActorComponent_Template {

		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0xB8AFB5C9;
	}
}
