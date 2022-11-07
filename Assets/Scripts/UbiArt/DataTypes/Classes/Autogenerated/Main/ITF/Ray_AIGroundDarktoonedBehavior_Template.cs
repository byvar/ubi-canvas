namespace UbiArt.ITF {
	[Games(GameFlags.RO)]
	public partial class Ray_AIGroundDarktoonedBehavior_Template : Ray_AIGroundRoamBehavior_Template {
		public float stimEmissionSpeedLimit;
		public Vec2d stimEmissionOffset;
		public Vec2d stimEmissionOffsetEnd;
		public uint stimLevel;
		public RECEIVEDHITTYPE stimType;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			stimEmissionSpeedLimit = s.Serialize<float>(stimEmissionSpeedLimit, name: "stimEmissionSpeedLimit");
			stimEmissionOffset = s.SerializeObject<Vec2d>(stimEmissionOffset, name: "stimEmissionOffset");
			stimEmissionOffsetEnd = s.SerializeObject<Vec2d>(stimEmissionOffsetEnd, name: "stimEmissionOffsetEnd");
			stimLevel = s.Serialize<uint>(stimLevel, name: "stimLevel");
			stimType = s.Serialize<RECEIVEDHITTYPE>(stimType, name: "stimType");
		}
		public enum RECEIVEDHITTYPE {
			[Serialize("RECEIVEDHITTYPE_UNKNOWN"    )] UNKNOWN = -1,
			[Serialize("RECEIVEDHITTYPE_FRONTPUNCH" )] FRONTPUNCH = 0,
			[Serialize("RECEIVEDHITTYPE_UPPUNCH"    )] UPPUNCH = 1,
			[Serialize("RECEIVEDHITTYPE_EJECTXY"    )] EJECTXY = 3,
			[Serialize("RECEIVEDHITTYPE_HURTBOUNCE" )] HURTBOUNCE = 4,
			[Serialize("RECEIVEDHITTYPE_DARKTOONIFY")] DARKTOONIFY = 5,
			[Serialize("RECEIVEDHITTYPE_EARTHQUAKE" )] EARTHQUAKE = 6,
			[Serialize("RECEIVEDHITTYPE_SHOOTER"    )] SHOOTER = 7,
		}
		public override uint? ClassCRC => 0xCD9EBCCC;
	}
}

