namespace UbiArt.ITF {
	[Games(GameFlags.ROVersion)]
	public partial class Ray_EventAIOrder : EventGeneric {
		public float targetReachedRadius;
		public float playerDetectRadius;
		public ORDERTYPE orderType;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			targetReachedRadius = s.Serialize<float>(targetReachedRadius, name: "targetReachedRadius");
			playerDetectRadius = s.Serialize<float>(playerDetectRadius, name: "playerDetectRadius");
			orderType = s.Serialize<ORDERTYPE>(orderType, name: "orderType");
		}
		public enum ORDERTYPE {
			[Serialize("ORDERTYPE_Unknown"       )] Unknown = 0,
			[Serialize("ORDERTYPE_WaitForPlayer" )] WaitForPlayer = 1,
			[Serialize("ORDERTYPE_WaitForTrigger")] WaitForTrigger = 2,
		}
		public override uint? ClassCRC => 0x3EE79EC4;
	}
}

