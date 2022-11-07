namespace UbiArt.ITF {
	[Games(GameFlags.RO)]
	public partial class Ray_CageMapAmbianceComponent : ActorComponent {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x7151F144;
	}
}

