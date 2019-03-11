using UnityEngine;

namespace UbiArt.ITF {
	public partial class Ray_BossBuboAIComponent_Template : CSerializable {
		[Serialize("invisibleAnim"    )] public StringID invisibleAnim;
		[Serialize("appearAnim"       )] public StringID appearAnim;
		[Serialize("disappearAnim"    )] public StringID disappearAnim;
		[Serialize("hitAnim"          )] public StringID hitAnim;
		[Serialize("deathAnim"        )] public StringID deathAnim;
		[Serialize("allowedFaction"   )] public uint allowedFaction;
		[Serialize("nbRewards"        )] public uint nbRewards;
		[Serialize("triggerActivator" )] public bool triggerActivator;
		[Serialize("delayTrigger"     )] public bool delayTrigger;
		[Serialize("isCrushable"      )] public bool isCrushable;
		[Serialize("isMegaBubo"       )] public bool isMegaBubo;
		[Serialize("megaBuboHitPoints")] public uint megaBuboHitPoints;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(invisibleAnim));
			SerializeField(s, nameof(appearAnim));
			SerializeField(s, nameof(disappearAnim));
			SerializeField(s, nameof(hitAnim));
			SerializeField(s, nameof(deathAnim));
			SerializeField(s, nameof(allowedFaction));
			SerializeField(s, nameof(nbRewards));
			SerializeField(s, nameof(triggerActivator));
			SerializeField(s, nameof(delayTrigger));
			SerializeField(s, nameof(isCrushable));
			SerializeField(s, nameof(isMegaBubo));
			SerializeField(s, nameof(megaBuboHitPoints));
		}
		public override uint? ClassCRC => 0x3003CC7E;
	}
}

