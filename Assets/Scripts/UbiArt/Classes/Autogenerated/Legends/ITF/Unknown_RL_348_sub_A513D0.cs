using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class Unknown_RL_348_sub_A513D0 : CSerializable {
		[Serialize("usedAnim"     )] public StringID usedAnim;
		[Serialize("nextAnim"     )] public StringID nextAnim;
		[Serialize("lockedAnim"   )] public StringID lockedAnim;
		[Serialize("availableAnim")] public StringID availableAnim;
		[Serialize("unlockAnim"   )] public StringID unlockAnim;
		[Serialize("changeFX"     )] public StringID changeFX;
		[Serialize("pressUpShape" )] public Placeholder pressUpShape;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(usedAnim));
			SerializeField(s, nameof(nextAnim));
			SerializeField(s, nameof(lockedAnim));
			SerializeField(s, nameof(availableAnim));
			SerializeField(s, nameof(unlockAnim));
			SerializeField(s, nameof(changeFX));
			SerializeField(s, nameof(pressUpShape));
		}
		public override uint? ClassCRC => 0x5EDC6B33;
	}
}

