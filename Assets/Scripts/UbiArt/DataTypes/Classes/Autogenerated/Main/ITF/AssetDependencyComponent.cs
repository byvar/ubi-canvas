namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class AssetDependencyComponent : CSerializable {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x1952FB78;
	}
}

