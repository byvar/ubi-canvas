using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class Unknown_RL_187_sub_768A20 : ActorComponent_Template {
		public Path levelPainting;
		public CList<Path> teensyRecap10;
		public CList<Path> teensyRecap3;
		public Path levelPaintingH;
		public CList<Path> teensyRecap10H;
		public CList<Path> teensyRecap3H;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			levelPainting = s.SerializeObject<Path>(levelPainting, name: "levelPainting");
			teensyRecap10 = s.SerializeObject<CList<Path>>(teensyRecap10, name: "teensyRecap10");
			teensyRecap3 = s.SerializeObject<CList<Path>>(teensyRecap3, name: "teensyRecap3");
			levelPaintingH = s.SerializeObject<Path>(levelPaintingH, name: "levelPaintingH");
			teensyRecap10H = s.SerializeObject<CList<Path>>(teensyRecap10H, name: "teensyRecap10H");
			teensyRecap3H = s.SerializeObject<CList<Path>>(teensyRecap3H, name: "teensyRecap3H");
		}
		public override uint? ClassCRC => 0x368D19B7;
	}
}

