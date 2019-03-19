using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RO)]
	public partial class Ray_AIGroundDarktoonedBehavior_Template : Ray_AIGroundRoamBehavior_Template {
		[Serialize("stimEmissionSpeedLimit")] public float stimEmissionSpeedLimit;
		[Serialize("stimEmissionOffset"    )] public Vector2 stimEmissionOffset;
		[Serialize("stimEmissionOffsetEnd" )] public Vector2 stimEmissionOffsetEnd;
		[Serialize("stimLevel"             )] public uint stimLevel;
		[Serialize("stimType"              )] public RECEIVEDHITTYPE stimType;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(stimEmissionSpeedLimit));
			SerializeField(s, nameof(stimEmissionOffset));
			SerializeField(s, nameof(stimEmissionOffsetEnd));
			SerializeField(s, nameof(stimLevel));
			SerializeField(s, nameof(stimType));
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

