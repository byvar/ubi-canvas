namespace UbiArt.ITF {
	[Games(GameFlags.RAVersion)]
	public partial class BreakableStackManagerAIComponent : AIComponent {
		public uint width;
		public uint height;
		public float gravityFall;
		public bool iceMode;
		public bool syncAnim;
		public float speedIceMode;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			width = s.Serialize<uint>(width, name: "width");
			height = s.Serialize<uint>(height, name: "height");
			gravityFall = s.Serialize<float>(gravityFall, name: "gravityFall");
			iceMode = s.Serialize<bool>(iceMode, name: "iceMode");
			syncAnim = s.Serialize<bool>(syncAnim, name: "syncAnim");
			speedIceMode = s.Serialize<float>(speedIceMode, name: "speedIceMode");
		}
		public override uint? ClassCRC => 0xCC0F0FDB;
	}
}

