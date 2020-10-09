using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RAVersion)]
	public partial class PlayAnimComponent : ActorComponent {
		public CListO<PlayAnimComponent.strPlayAnimParams> SequenceList;
		public bool isLooping;
		public bool startActive;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SequenceList = s.SerializeObject<CListO<PlayAnimComponent.strPlayAnimParams>>(SequenceList, name: "SequenceList");
			isLooping = s.Serialize<bool>(isLooping, name: "isLooping");
			startActive = s.Serialize<bool>(startActive, name: "startActive");
		}
		[Games(GameFlags.VH | GameFlags.RA)]
		public partial class strPlayAnimParams : CSerializable {
			public StringID AnimToPlay;
			public bool WaitAnimEnd;
			public float AnimTime;
			public StringID StringID__0;
			public bool bool__1;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				if (Settings.s.game == Settings.Game.VH) {
					StringID__0 = s.SerializeObject<StringID>(StringID__0, name: "StringID__0");
					bool__1 = s.Serialize<bool>(bool__1, name: "bool__1");
				} else {
					AnimToPlay = s.SerializeObject<StringID>(AnimToPlay, name: "AnimToPlay");
					WaitAnimEnd = s.Serialize<bool>(WaitAnimEnd, name: "WaitAnimEnd");
					AnimTime = s.Serialize<float>(AnimTime, name: "AnimTime");
				}
			}
		}
		public override uint? ClassCRC => 0x6DAA7EAB;
	}
}

