namespace UbiArt.ITF {
	[Games(GameFlags.LegendsAndUp)]
	public partial class StaticMeshVertexComponent_Template : GraphicComponent_Template {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0xDCB98BBD;
	}
}

