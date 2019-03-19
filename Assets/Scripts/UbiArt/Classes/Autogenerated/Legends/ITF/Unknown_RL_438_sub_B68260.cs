using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class Unknown_RL_438_sub_B68260 : CSerializable {
		[Serialize("depth"                         )] public float depth;
		[Serialize("screenBorderScale"             )] public Vector2 screenBorderScale;
		[Serialize("moveDirBlendFactor"            )] public float moveDirBlendFactor;
		[Serialize("moveSpeed"                     )] public float moveSpeed;
		[Serialize("moveDestDeltaDist"             )] public float moveDestDeltaDist;
		[Serialize("moveEjectSpeed"                )] public float moveEjectSpeed;
		[Serialize("moveEjectAbsorptionBlendFactor")] public float moveEjectAbsorptionBlendFactor;
		[Serialize("animBurst"                     )] public StringID animBurst;
		[Serialize("appearRumbleID"                )] public StringID appearRumbleID;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(depth));
			SerializeField(s, nameof(screenBorderScale));
			SerializeField(s, nameof(moveDirBlendFactor));
			SerializeField(s, nameof(moveSpeed));
			SerializeField(s, nameof(moveDestDeltaDist));
			SerializeField(s, nameof(moveEjectSpeed));
			SerializeField(s, nameof(moveEjectAbsorptionBlendFactor));
			SerializeField(s, nameof(animBurst));
			SerializeField(s, nameof(appearRumbleID));
		}
		public override uint? ClassCRC => 0x5A6A3AB9;
	}
}

