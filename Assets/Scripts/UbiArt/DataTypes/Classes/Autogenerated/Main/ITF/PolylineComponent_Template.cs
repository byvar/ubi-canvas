namespace UbiArt.ITF {
	[Games(GameFlags.All)]
	public partial class PolylineComponent_Template : ActorComponent_Template {
		public CListO<PolylineParameters> polylineParams;
		public bool isEnvironment;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			polylineParams = s.SerializeObject<CListO<PolylineParameters>>(polylineParams, name: "polylineParams");
			isEnvironment = s.Serialize<bool>(isEnvironment, name: "isEnvironment");
		}
		public override uint? ClassCRC => 0x72853946;
	}
}

