namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_SceneConfig_StartScreen : CSerializable {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0xAD523EEB;
	}
}

