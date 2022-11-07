namespace UbiArt.ITF {
	[Games(GameFlags.VH | GameFlags.RA)]
	public partial class BreakPointDesc : CSerializable {
		public string DephtNodeID;
		public int BreakOnDecide;
		public int BreakOnUpdate;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			DephtNodeID = s.Serialize<string>(DephtNodeID, name: "DephtNodeID");
			BreakOnDecide = s.Serialize<int>(BreakOnDecide, name: "BreakOnDecide");
			BreakOnUpdate = s.Serialize<int>(BreakOnUpdate, name: "BreakOnUpdate");
		}
	}
}

