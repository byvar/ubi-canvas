using UnityEngine;

namespace UbiArt.ITF {
	public partial class PlayAnimComponent : ActorComponent {
		[Serialize("SequenceList")] public CList<PlayAnimComponent.strPlayAnimParams> SequenceList;
		[Serialize("isLooping"   )] public bool isLooping;
		[Serialize("startActive" )] public bool startActive;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(SequenceList));
			SerializeField(s, nameof(isLooping));
			SerializeField(s, nameof(startActive));
		}
		public partial class strPlayAnimParams : CSerializable {
			[Serialize("AnimToPlay" )] public StringID AnimToPlay;
			[Serialize("WaitAnimEnd")] public bool WaitAnimEnd;
			[Serialize("AnimTime"   )] public float AnimTime;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				SerializeField(s, nameof(AnimToPlay));
				SerializeField(s, nameof(WaitAnimEnd));
				SerializeField(s, nameof(AnimTime));
			}
		}
		public override uint? ClassCRC => 0x6DAA7EAB;
	}
}

