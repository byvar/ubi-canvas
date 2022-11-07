namespace UbiArt.ITF {
	[Games(GameFlags.RO)]
	public partial class Ray_AIBTOrderComponent_Template : CSerializable {
		public BTAIORDER type;
		public StringID detectionArea;
		public int removeOnExit;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			type = s.Serialize<BTAIORDER>(type, name: "type");
			detectionArea = s.SerializeObject<StringID>(detectionArea, name: "detectionArea");
			removeOnExit = s.Serialize<int>(removeOnExit, name: "removeOnExit");
		}
		public enum BTAIORDER {
			[Serialize("BTAIORDER_WAITFORPLAYER"       )] WAITFORPLAYER = 1,
			[Serialize("BTAIORDER_WAITFORLAST"         )] WAITFORLAST = 2,
			[Serialize("BTAIORDER_WAITWHILEACTORSALIVE")] WAITWHILEACTORSALIVE = 3,
			[Serialize("BTAIORDER_SETTARGETWAYPOINT"   )] SETTARGETWAYPOINT = 4,
			[Serialize("BTAIORDER_PEDESTAL"            )] PEDESTAL = 5,
			[Serialize("BTAIORDER_SETRESPAWNPOINT"     )] SETRESPAWNPOINT = 6,
			[Serialize("BTAIORDER_DETECTIONAREA"       )] DETECTIONAREA = 7,
			[Serialize("BTAIORDER_REMOVECURRENTORDER"  )] REMOVECURRENTORDER = 8,
		}
		public override uint? ClassCRC => 0x4BAC317D;
	}
}

