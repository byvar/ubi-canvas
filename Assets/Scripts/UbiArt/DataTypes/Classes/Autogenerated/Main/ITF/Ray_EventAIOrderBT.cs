namespace UbiArt.ITF {
	[Games(GameFlags.RO)]
	public partial class Ray_EventAIOrderBT : Event {
		public BTAIORDER type;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			type = s.Serialize<BTAIORDER>(type, name: "type");
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
		public override uint? ClassCRC => 0x94DD7761;
	}
}

