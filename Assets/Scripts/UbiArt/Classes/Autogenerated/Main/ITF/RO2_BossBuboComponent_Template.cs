using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_BossBuboComponent_Template : ActorComponent_Template {
		[Serialize("invisibleAnim" )] public StringID invisibleAnim;
		[Serialize("appearAnim"    )] public StringID appearAnim;
		[Serialize("disappearAnim" )] public StringID disappearAnim;
		[Serialize("hitAnim"       )] public StringID hitAnim;
		[Serialize("deathAnim"     )] public StringID deathAnim;
		[Serialize("allowedFaction")] public uint allowedFaction;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(invisibleAnim));
			SerializeField(s, nameof(appearAnim));
			SerializeField(s, nameof(disappearAnim));
			SerializeField(s, nameof(hitAnim));
			SerializeField(s, nameof(deathAnim));
			SerializeField(s, nameof(allowedFaction));
		}
		public override uint? ClassCRC => 0x8F4BA3FD;
	}
}

