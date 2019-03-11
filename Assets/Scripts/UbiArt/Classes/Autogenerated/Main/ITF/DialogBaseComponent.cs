using UnityEngine;

namespace UbiArt.ITF {
	public partial class DialogBaseComponent : ActorComponent {
		[Serialize("playOnce"        )] public bool playOnce;
		[Serialize("loop"            )] public bool loop;
		[Serialize("wordTime_Default")] public float wordTime_Default;
		[Serialize("wordTime_Accel"  )] public float wordTime_Accel;
		[Serialize("endTime_Default" )] public float endTime_Default;
		[Serialize("endTime_Accel"   )] public float endTime_Accel;
		[Serialize("waitInit"        )] public bool waitInit;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Default)) {
				SerializeField(s, nameof(playOnce));
				SerializeField(s, nameof(loop));
				SerializeField(s, nameof(wordTime_Default));
				SerializeField(s, nameof(wordTime_Accel));
				SerializeField(s, nameof(endTime_Default));
				SerializeField(s, nameof(endTime_Accel));
				SerializeField(s, nameof(waitInit));
			}
		}
		public override uint? ClassCRC => 0x3652B80A;
	}
}

