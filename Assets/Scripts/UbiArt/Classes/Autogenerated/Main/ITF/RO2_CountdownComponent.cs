using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_CountdownComponent : ActorComponent {
		[Serialize("animName"         )] public StringID animName;
		[Serialize("countdownCount"   )] public float countdownCount;
		[Serialize("countdownDuration")] public float countdownDuration;
		[Serialize("goDisplayDuration")] public float goDisplayDuration;
		[Serialize("finishAfterGo"    )] public bool finishAfterGo;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(animName));
			SerializeField(s, nameof(countdownCount));
			SerializeField(s, nameof(countdownDuration));
			SerializeField(s, nameof(goDisplayDuration));
			SerializeField(s, nameof(finishAfterGo));
		}
		public override uint? ClassCRC => 0xF8B2093C;
	}
}

