namespace UbiArt.ITF {
	[Games(GameFlags.RAVersion)]
	public partial class BTDeciderFactCompare : BTDecider {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0xCCC999B2;
	}
}

