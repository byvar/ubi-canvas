using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class Unknown_RL_187_sub_768A20 : CSerializable {
		[Serialize("levelPainting" )] public Path levelPainting;
		[Serialize("teensyRecap10" )] public Placeholder teensyRecap10;
		[Serialize("teensyRecap3"  )] public Placeholder teensyRecap3;
		[Serialize("levelPaintingH")] public Path levelPaintingH;
		[Serialize("teensyRecap10H")] public Placeholder teensyRecap10H;
		[Serialize("teensyRecap3H" )] public Placeholder teensyRecap3H;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(levelPainting));
			SerializeField(s, nameof(teensyRecap10));
			SerializeField(s, nameof(teensyRecap3));
			SerializeField(s, nameof(levelPaintingH));
			SerializeField(s, nameof(teensyRecap10H));
			SerializeField(s, nameof(teensyRecap3H));
		}
		public override uint? ClassCRC => 0x368D19B7;
	}
}

