namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA | GameFlags.RM)]
	public partial class RO2_BreakableStackManagerAIComponent : RO2_AIComponent {
		public uint width = 4;
		public uint height = 4;
		public float gravityFall = 0.1f;
		public bool iceMode;
		public bool syncAnim = true;
		public float speedIceMode = 0.5f;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			width = s.Serialize<uint>(width, name: "width");
			height = s.Serialize<uint>(height, name: "height");
			gravityFall = s.Serialize<float>(gravityFall, name: "gravityFall");
			iceMode = s.Serialize<bool>(iceMode, name: "iceMode");
			syncAnim = s.Serialize<bool>(syncAnim, name: "syncAnim");
			speedIceMode = s.Serialize<float>(speedIceMode, name: "speedIceMode");
		}
		public override uint? ClassCRC => 0x0B18F28F;
	}
}

