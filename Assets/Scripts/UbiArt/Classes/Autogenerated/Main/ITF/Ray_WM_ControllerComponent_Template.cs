using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RO)]
	public partial class Ray_WM_ControllerComponent_Template : CSerializable {
		[Serialize("moveX"               )] public float moveX;
		[Serialize("moveFactorMultiplier")] public float moveFactorMultiplier;
		[Serialize("standAnim"           )] public StringID standAnim;
		[Serialize("walkAnim"            )] public StringID walkAnim;
		[Serialize("jumpAnim"            )] public StringID jumpAnim;
		[Serialize("swimAnim"            )] public StringID swimAnim;
		[Serialize("flyAnim"             )] public StringID flyAnim;
		[Serialize("leadAbility"         )] public Placeholder leadAbility;
		[Serialize("followAbility"       )] public Placeholder followAbility;
		[Serialize("heartShield"         )] public Placeholder heartShield;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(moveX));
			SerializeField(s, nameof(moveFactorMultiplier));
			SerializeField(s, nameof(standAnim));
			SerializeField(s, nameof(walkAnim));
			SerializeField(s, nameof(jumpAnim));
			SerializeField(s, nameof(swimAnim));
			SerializeField(s, nameof(flyAnim));
			SerializeField(s, nameof(leadAbility));
			SerializeField(s, nameof(followAbility));
			SerializeField(s, nameof(heartShield));
		}
		public override uint? ClassCRC => 0x2B26168C;
	}
}

