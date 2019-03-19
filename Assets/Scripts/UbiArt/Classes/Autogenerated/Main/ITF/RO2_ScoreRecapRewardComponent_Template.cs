using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_ScoreRecapRewardComponent_Template : ActorComponent_Template {
		[Serialize("idleTime"              )] public float idleTime;
		[Serialize("finalScale"            )] public float finalScale;
		[Serialize("transitionTime"        )] public float transitionTime;
		[Serialize("appear"                )] public StringID appear;
		[Serialize("idle"                  )] public StringID idle;
		[Serialize("disappear"             )] public StringID disappear;
		[Serialize("nbLoopDuringTransition")] public uint nbLoopDuringTransition;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(idleTime));
			SerializeField(s, nameof(finalScale));
			SerializeField(s, nameof(transitionTime));
			SerializeField(s, nameof(appear));
			SerializeField(s, nameof(idle));
			SerializeField(s, nameof(disappear));
			SerializeField(s, nameof(nbLoopDuringTransition));
		}
		public override uint? ClassCRC => 0x8639B35F;
	}
}

