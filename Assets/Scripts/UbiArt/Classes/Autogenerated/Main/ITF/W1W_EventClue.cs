using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.VH)]
	public partial class W1W_EventClue : Event {
		[Serialize("bool__0")] public bool bool__0;
		[Serialize("bool__1")] public bool bool__1;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(bool__0));
			SerializeField(s, nameof(bool__1));
		}
		[Games(GameFlags.VH)]
		public partial class stClueItem : CSerializable {
			[Serialize("uint__0")] public uint uint__0;
			[Serialize("Path__1")] public Path Path__1;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				SerializeField(s, nameof(uint__0));
				SerializeField(s, nameof(Path__1));
			}
		}
		[Games(GameFlags.VH)]
		public partial class stClueBatch : CSerializable {
			[Serialize("CArray<W1W_EventClue.stClueItem>__0")] public CArray<W1W_EventClue.stClueItem> CArray_W1W_EventClue_stClueItem__0;
			[Serialize("uint__1"                            )] public uint uint__1;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				SerializeField(s, nameof(CArray_W1W_EventClue_stClueItem__0));
				SerializeField(s, nameof(uint__1));
			}
		}
		public override uint? ClassCRC => 0x98EC2A32;
	}
}

