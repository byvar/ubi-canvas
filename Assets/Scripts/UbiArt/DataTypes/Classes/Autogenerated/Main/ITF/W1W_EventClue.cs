namespace UbiArt.ITF {
	[Games(GameFlags.VH)]
	public partial class W1W_EventClue : Event {
		public bool bool__0;
		public bool bool__1;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			bool__0 = s.Serialize<bool>(bool__0, name: "bool__0");
			bool__1 = s.Serialize<bool>(bool__1, name: "bool__1");
		}
		[Games(GameFlags.VH)]
		public partial class stClueItem : CSerializable {
			public uint uint__0;
			public Path Path__1;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				uint__0 = s.Serialize<uint>(uint__0, name: "uint__0");
				Path__1 = s.SerializeObject<Path>(Path__1, name: "Path__1");
			}
		}
		[Games(GameFlags.VH)]
		public partial class stClueBatch : CSerializable {
			public CArrayO<W1W_EventClue.stClueItem> CArray_W1W_EventClue_stClueItem__0;
			public uint uint__1;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				CArray_W1W_EventClue_stClueItem__0 = s.SerializeObject<CArrayO<W1W_EventClue.stClueItem>>(CArray_W1W_EventClue_stClueItem__0, name: "CArray<W1W_EventClue.stClueItem>__0");
				uint__1 = s.Serialize<uint>(uint__1, name: "uint__1");
			}
		}
		public override uint? ClassCRC => 0x98EC2A32;
	}
}

