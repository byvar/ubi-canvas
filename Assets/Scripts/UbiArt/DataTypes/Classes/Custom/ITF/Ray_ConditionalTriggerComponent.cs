namespace UbiArt.ITF {
	[Games(GameFlags.RO)]
	public partial class Ray_ConditionalTriggerComponent : TriggerComponent {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0xCA970120;
	}
}

