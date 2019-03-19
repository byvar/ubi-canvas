using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.VH)]
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
		[Games(GameFlags.RA | GameFlags.VH)]
		public partial class strPlayAnimParams : CSerializable {
			[Serialize("AnimToPlay" )] public StringID AnimToPlay;
			[Serialize("WaitAnimEnd")] public bool WaitAnimEnd;
			[Serialize("AnimTime"   )] public float AnimTime;
			[Serialize("StringID__0")] public StringID StringID__0;
			[Serialize("bool__1"    )] public bool bool__1;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				if (Settings.s.game == Settings.Game.VH) {
					SerializeField(s, nameof(StringID__0));
					SerializeField(s, nameof(bool__1));
				} else {
					SerializeField(s, nameof(AnimToPlay));
					SerializeField(s, nameof(WaitAnimEnd));
					SerializeField(s, nameof(AnimTime));
				}
			}
		}
		public override uint? ClassCRC => 0x6DAA7EAB;
	}
}

