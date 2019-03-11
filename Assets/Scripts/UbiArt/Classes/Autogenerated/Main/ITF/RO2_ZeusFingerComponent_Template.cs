using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_ZeusFingerComponent_Template : ActorComponent_Template {
		[Serialize("idleAnim"         )] public StringID idleAnim;
		[Serialize("appearAnim"       )] public StringID appearAnim;
		[Serialize("reflexAnim"       )] public StringID reflexAnim;
		[Serialize("chargeAnim"       )] public StringID chargeAnim;
		[Serialize("shootAnim"        )] public StringID shootAnim;
		[Serialize("disappearAnim"    )] public StringID disappearAnim;
		[Serialize("emptyAnim"        )] public StringID emptyAnim;
		[Serialize("shootDuration"    )] public float shootDuration;
		[Serialize("useShootDuration" )] public bool useShootDuration;
		[Serialize("chargeDuration"   )] public float chargeDuration;
		[Serialize("disappearDuration")] public float disappearDuration;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(idleAnim));
			SerializeField(s, nameof(appearAnim));
			SerializeField(s, nameof(reflexAnim));
			SerializeField(s, nameof(chargeAnim));
			SerializeField(s, nameof(shootAnim));
			SerializeField(s, nameof(disappearAnim));
			SerializeField(s, nameof(emptyAnim));
			SerializeField(s, nameof(shootDuration));
			SerializeField(s, nameof(useShootDuration));
			SerializeField(s, nameof(chargeDuration));
			SerializeField(s, nameof(disappearDuration));
		}
		public override uint? ClassCRC => 0x718EE3A8;
	}
}

